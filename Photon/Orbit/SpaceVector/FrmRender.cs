using Photon.OpenGl;
using System.Collections.Concurrent;
using System.ComponentModel;
using Vec3 = System.Numerics.Vector3;

namespace Photon.SpaceVector
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

        public static Vector3 GetVector(in OrbitIntersection oiA, in OrbitIntersection oiB, in Point3 p)
        {
            Dimension.Lerp(p.X, p.Y, p.Z, oiA.Orbit1.S.X, oiA.Orbit1.S.Y, oiA.Orbit1.S.Z, oiA.Orbit1.W / (oiA.Orbit1.N * oiA.Orbit1.N), out Vector3 fa1);
            Dimension.Lerp(p.X, p.Y, p.Z, oiA.Orbit2.S.X, oiA.Orbit2.S.Y, oiA.Orbit2.S.Z, oiA.Orbit2.W / (oiA.Orbit2.N * oiA.Orbit2.N), out Vector3 fa2);

            Dimension.Lerp(p.X, p.Y, p.Z, oiB.Orbit1.S.X, oiB.Orbit1.S.Y, oiB.Orbit1.S.Z, oiB.Orbit1.W / (oiB.Orbit1.N * oiB.Orbit1.N), out Vector3 fb1);
            Dimension.Lerp(p.X, p.Y, p.Z, oiB.Orbit2.S.X, oiB.Orbit2.S.Y, oiB.Orbit2.S.Z, oiB.Orbit2.W / (oiB.Orbit2.N * oiB.Orbit2.N), out Vector3 fb2);

            return fa1 + fa2 + fb1 + fb2;
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            var particles = GetParticles();
            var orbits = particles.Select(p => p.GetOrbits(setting)).ToArray();

            var orbitIntersections = new List<OrbitIntersection>();

            LblHeader.Invoke(() => { LblHeader.Text = "Processing particles..."; });
            var lastPercent = int.MaxValue;
            var count = 1;
            var total = orbits.Take(orbits.Length - 1).Aggregate(0, (c1, n1) => c1 + orbits.Skip(count++).Aggregate(0, (c2, n2) => c2 + n1.Count * n2.Count));
            count = orbits.Length;
            int progress = 0;

            Parallel.For(0, orbits.Length, a =>
            {
                var osA = orbits[a];

                Parallel.For(a + 1, orbits.Length, b =>
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

                            if (oA.S.Intersect(oB.S, out Circle3Projection cp))
                            {
                                orbitIntersections.Add(new(cp, oA, oB));
                            }
                        }
                    }
                });
            });

            static Pixel3 GetPixel3(in Point3 p, in FormSetting setting)
            {
                return new((int)Math.Round(p.X / setting.RenderClusterSize), (int)Math.Round(p.Y / setting.RenderClusterSize), (int)Math.Round(p.Z / setting.RenderClusterSize));
            }

            var deeps = new ConcurrentDictionary<Pixel3, Vector3>();
            static void addToDeep(ConcurrentDictionary<Pixel3, Vector3> deeps, in Pixel3 deepKey, in Vector3 deepValue)
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

            LblHeader.Invoke(() => { LblHeader.Text = "Processing orbits..."; });
            lastPercent = int.MaxValue;
            count = orbitIntersections.Count;
            progress = 0;

            Parallel.For(0, count, a =>
            {
                Interlocked.Increment(ref progress);
                var percent = (int)Math.Round(100d * progress / count);
                if (percent != lastPercent) { Bgw.ReportProgress(percent); lastPercent = percent; }

                var oiA = orbitIntersections[a];

                Parallel.For(a + 1, count, b =>
                {
                    if (Bgw.CancellationPending) { e.Cancel = true; return; }

                    var oiB = orbitIntersections[b];

                    if (oiA.Cp.Intersect(oiB.Cp, out Point3 p1, out Point3 p2))
                    {
                        if (PointInRange(p1))
                        {
                            addToDeep(deeps, GetPixel3(p1, setting), GetVector(oiA, oiB, p1));
                        }

                        if (PointInRange(p2))
                        {
                            addToDeep(deeps, GetPixel3(p2, setting), GetVector(oiA, oiB, p2));
                        }
                    }
                });
            });


            if (!deeps.IsEmpty)
            {
                var keys = deeps.Keys.ToArray();
                var values = deeps.Values.Select(p => p.Length()).ToArray();

                var vs = new List<Vertex>();

                LblHeader.Invoke(() => { LblHeader.Text = "Processing render..."; });
                lastPercent = int.MaxValue;

                var max = values.Max();
                //var min = values.Min();
                //var diff = max - min;

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
