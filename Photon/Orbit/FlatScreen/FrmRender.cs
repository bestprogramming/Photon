using Photon.OpenGl;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;
using Vec3 = System.Numerics.Vector3;

namespace Photon.FlatScreen
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

            static Pixel GetPixel(in Point p, in FormSetting setting)
            {
                return new((int)Math.Round(p.X / setting.RenderClusterSize), (int)Math.Round(p.Y / setting.RenderClusterSize));
            }

            var deeps = new ConcurrentDictionary<Pixel, Big>();
            static void addToDeep(ConcurrentDictionary<Pixel, Big> deeps, in Pixel deepKey, in Big deepValue)
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

                            oA.C.Intersect(oB.C, out Point p1, out Point p2);

                            if (p1.IsReal() && p2.IsReal())
                            {
                                //var deep = Big.One * oA.W * oB.W / (Big.One * oA.N * oA.N * oB.N * oB.N);
                                var deep = Big.One * oA.W / (oA.N * oA.N) + Big.One * oB.W / (oB.N * oB.N);
                                //var deep = Big.One * oA.W / oA.N + Big.One * oB.W / oB.N;

                                if (p1.In(setting.Screen))
                                {
                                    addToDeep(deeps, GetPixel(p1, setting), deep);
                                }

                                if (p2.In(setting.Screen))
                                {
                                    addToDeep(deeps, GetPixel(p2, setting), deep);
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

                        var position = setting.ScreenPlane == ScreenPlane.Xy ? new Vec3((float)x, (float)y, (float)setting.ScreenZ) :
                            setting.ScreenPlane == ScreenPlane.Xz ? new Vec3((float)x, (float)setting.ScreenY, (float)y) :
                            new Vec3((float)setting.ScreenX, (float)x, (float)y);
                        vs.Add(new(position, color, (float)setting.RenderPointSize));
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

        private static double CumulativeDistribution(double x, double a, double b)
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
