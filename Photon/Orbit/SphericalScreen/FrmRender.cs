using Photon.OpenGl;
using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using Vec3 = System.Numerics.Vector3;

namespace Photon.SphericalScreen
{
    public partial class FrmRender : Form
    {
        private readonly FormSetting setting;

        public FrmRender(FormSetting setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        public PatternSetting Pattern = new();
        public Scene Render = new();

        private void FrmRender_Load(object sender, EventArgs e)
        {
            Bgw.RunWorkerAsync();
        }

        private void FrmRender_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Bgw.IsBusy)
            {
                e.Cancel = true;
                Bgw.CancelAsync();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Bgw.CancelAsync();
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            LblHeader.Invoke(() => { LblHeader.Text = "Loading particles..."; });
            var particles = GetParticles();
            var orbits = particles.Select(p => p.GetOrbits(setting)).ToArray();

            static Pixel3 GetPixel3(in Point3 p, in FormSetting setting)
            {
                return new((int)Math.Round(p.X / setting.RenderClusterSize), (int)Math.Round(p.Y / setting.RenderClusterSize), (int)Math.Round(p.Z / setting.RenderClusterSize));
            }

            var deeps = new ConcurrentDictionary<Pixel3, Big>();
            static void addToDeep(ConcurrentDictionary<Pixel3, Big> deeps, in Pixel3 deepKey, in Big deepValue)
            {
                if (!deeps.ContainsKey(deepKey))
                {
                    deeps[deepKey] = deepValue;
                }
                else
                {
                    deeps[deepKey] += deepValue;
                }
            }

            LblHeader.Invoke(() => { LblHeader.Text = "Processing particles..."; });
            var lastPercent = int.MaxValue;
            var count = 1;
            var total = orbits.Take(orbits.Length - 1).Aggregate(0, (c1, n1) => c1 + orbits.Skip(count++).Aggregate(0, (c2, n2) => c2 + n1.Count * n2.Count));
            count = orbits.Length;
            int progress = 0;

            Parallel.For(0, count, a =>
            {
                var osA = orbits[a];

                Parallel.For(a + 1, count, b =>
                {
                    var osB = orbits[b];

                    foreach (var oA in osA)
                    {
                        foreach (var oB in osB)
                        {
                            Interlocked.Increment(ref progress);
                            var percent = (int)Math.Round(100d * progress / total);
                            if (percent != lastPercent) { Bgw.ReportProgress(percent); lastPercent = percent; }
                            if (Bgw.CancellationPending) { e.Cancel = true; return; }

                            if (oA.Cp.Intersect(oB.Cp, out Point3 p1, out Point3 p2))
                            {
                                //                                if (setting.Screen.Distance(p1) > setting.Screen.R + 0.01)
                                //                                {
                                //                                    var k = 10;
                                //                                    var test = @$"
                                //    s1 = new Sphere({k * setting.Screen.X}, {k * setting.Screen.Y}, {k * setting.Screen.Z}, {k * setting.Screen.R});
                                //    s2 = new Sphere({k * pA.X}, {k * pA.Y}, {k * pA.Z}, {k * pA.R * oA.N * oA.N});
                                //    s3 = new Sphere({k * pB.X}, {k * pB.Y}, {k * pB.Z}, {k * pB.R * oB.N * oB.N});
                                //    ok1 = s1.Intersect(s2, out cp1);
                                //    ok2 = s1.Intersect(s3, out cp2);
                                //    ok3 = cp1.Intersect(cp2, out p1, out p2);
                                //    //Assert.True(ok3 && E(p1.X, ) && E(p1.Y, ) && E(p1.Z, ) && E(p2.X, ) && E(p2.Y, ) && E(p2.Z, ));
                                //";
                                //                                    Debug.WriteLine(test);
                                //                                    Debug.WriteLine("-------------------------------------");
                                //                                }

                                //var deep = Big.One * pA.W * Big.One * pB.W / (Big.One * oA.N * oA.N * oB.N * oB.N);
                                var deep = Big.One * oA.W / (Big.One * oA.N * oA.N) + Big.One * oB.W / (Big.One * oB.N * oB.N);

                                if (PointInRange(p1))
                                {
                                    addToDeep(deeps, GetPixel3(p1, setting), deep);
                                }

                                if (PointInRange(p2))
                                {
                                    addToDeep(deeps, GetPixel3(p2, setting), deep);
                                }
                            }
                        }
                    }
                });
            });



            if (!deeps.IsEmpty)
            {
                var keys = deeps.Keys.ToArray();
                var values = deeps.Values.ToArray();

                var vs = new List<Vertex>();

                LblHeader.Invoke(() => { LblHeader.Text = "Processing render..."; });
                lastPercent = int.MaxValue;

                var max = values.Max();
                var min = values.Min();
                var diff = max - min;

                for (var n = 0; n < keys.Length; n++)
                {
                    if (Bgw.CancellationPending) { e.Cancel = true; return; }

                    var percent = (int)(100L * n / keys.Length);
                    if (percent != lastPercent) { Bgw.ReportProgress(percent); lastPercent = percent; }

                    //var ratio = diff != 0 ? (float)CumulativeDistribution((double)((values[n] - min) / diff), 0.4633, 1.9196) : 1;
                    var ratio = (float)(values[n] / max);

                    var hsl = new Hsl((int)(360 * ratio) % 361, 1, ratio);
                    var color = hsl.ToVec4();

                    //if (color.X != 0 || color.Y != 0 || color.Z != 0)
                    if (ratio > 0.01)
                    {
                        var x = keys[n].X * setting.RenderClusterSize;
                        var y = keys[n].Y * setting.RenderClusterSize;
                        var z = keys[n].Z * setting.RenderClusterSize;

                        vs.Add(new(new((float)x, (float)y, (float)z), color, (float)setting.RenderPointSize));
                    }
                }

                Render.Shapes.Add(new Points(vs.ToArray()));

                var baseSettings = new List<BaseSetting>();
                foreach (var particle in particles)
                {
                    baseSettings.Add(new PointSetting
                    {
                        X = particle.X,
                        Y = particle.Y,
                        Z = particle.Z,
                        Weight = particle.W,
                        OrbitVibrate = particle.OrbitVibrateSetting != null && particle.OrbitVibrateSetting.Count > 0 && particle.OrbitVibrateSetting.Radius > 0,
                        OrbitVibrateSetting = particle.OrbitVibrateSetting,
                    });
                }
                Pattern = new PatternSetting
                {
                    BaseSettings = baseSettings.ToArray(),
                };
            }
            else
            {
                LblHeader.Invoke(() => { LblHeader.Text = "No render"; });
                Thread.Sleep(1000);
            }
        }

        private double CumulativeDistribution(double x, double a, double b)
        {
            return 1 - Math.Pow(1 - Math.Pow(x, a), b);
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Prb.Value = e.ProgressPercentage;
            LblPercent.Text = $"{e.ProgressPercentage} %";
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        public bool PointInRange(in Point3 p)
        {
            return p.X >= setting.RenderMinX && p.Y >= setting.RenderMinY && p.Z >= setting.RenderMinZ && p.X <= setting.RenderMaxX && p.Y <= setting.RenderMaxY && p.Z <= setting.RenderMaxZ;
        }

        public List<Particle> GetParticles()
        {
            var ret = new List<Particle>();

            foreach (var baseSetting in setting.BaseSettings)
            {
                var shape = baseSetting.GetShape();
                baseSetting.RotateAndVibrate(shape);
                foreach (var vertex in shape.Vertices)
                {
                    var particle = new Particle(vertex.Position.X * setting.PatternRatio, vertex.Position.Y * setting.PatternRatio, vertex.Position.Z * setting.PatternRatio, setting.ParticleRadius, baseSetting.Weight, baseSetting.OrbitVibrate ? baseSetting.OrbitVibrateSetting : null);
                    ret.Add(particle);
                }
            }

            return ret;
        }
    }
}
