using Photon;
using Photon.FlatScreen;
using Photon.FlatScreenVector;
using Photon.Space;
using Photon.SpaceVector;
using Photon.SphericalScreen;
using Photon.SphericalScreenVector;
using Photon.TestOpenGl;
using Photon.TestPacking;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Photon.TestIntersection
{
    public partial class FrmQuartic : Form
    {
        private readonly DirectBitmap db = new(1910, 1040);

        private int downX;
        private int downY;
        private FormSetting setting;
        private FormSetting downSetting;

        public FrmQuartic()
        {
            InitializeComponent();
            setting = FormSetting.Get(this);
            downSetting = setting;
        }

        private void FrmQuartic_Load(object sender, EventArgs e)
        {
            PnlFill.Focus();

            RefreshValues(null);
        }

        public struct FormSetting
        {
            public double MinA;
            public double A;
            public double MaxA;

            public double MinB;
            public double B;
            public double MaxB;

            public double MinC;
            public double C;
            public double MaxC;

            public double MinD;
            public double D;
            public double MaxD;

            public double MinE;
            public double E;
            public double MaxE;

            public double Epsilon;

            public override string ToString()
            {
                return $"a={A}, b={B}, c={C}, d={D}, e={E}";
            }

            public static FormSetting Get(FrmQuartic frm)
            {
                return new FormSetting
                {
                    MinA = frm.NudMinA.ToDouble(),
                    A = frm.NudA.ToDouble(),
                    MaxA = frm.NudMaxA.ToDouble(),

                    MinB = frm.NudMinB.ToDouble(),
                    B = frm.NudB.ToDouble(),
                    MaxB = frm.NudMaxB.ToDouble(),

                    MinC = frm.NudMinC.ToDouble(),
                    C = frm.NudC.ToDouble(),
                    MaxC = frm.NudMaxC.ToDouble(),

                    MinD = frm.NudMinD.ToDouble(),
                    D = frm.NudD.ToDouble(),
                    MaxD = frm.NudMaxD.ToDouble(),

                    MinE = frm.NudMinE.ToDouble(),
                    E = frm.NudE.ToDouble(),
                    MaxE = frm.NudMaxE.ToDouble(),
                };
            }

            public static void Set(FrmQuartic frm, FormSetting fs)
            {
                frm.DisableChanged();

                frm.NudMinA.FromDouble(Math.Min(fs.MinA, fs.A));
                frm.NudMaxA.FromDouble(Math.Max(fs.MaxA, fs.A));

                frm.NudMinB.FromDouble(Math.Min(fs.MinB, fs.B));
                frm.NudMaxB.FromDouble(Math.Max(fs.MaxB, fs.B));

                frm.NudMinC.FromDouble(Math.Min(fs.MinC, fs.C));
                frm.NudMaxC.FromDouble(Math.Max(fs.MaxC, fs.C));

                frm.NudMinD.FromDouble(Math.Min(fs.MinD, fs.D));
                frm.NudMaxD.FromDouble(Math.Max(fs.MaxD, fs.D));

                frm.NudMinE.FromDouble(Math.Min(fs.MinE, fs.E));
                frm.NudMaxE.FromDouble(Math.Max(fs.MaxE, fs.E));

                frm.EnableChanged();


                frm.RefreshValues(null);


                frm.DisableChanged();

                frm.NudA.FromDouble(fs.A);
                frm.NudB.FromDouble(fs.B);
                frm.NudC.FromDouble(fs.C);
                frm.NudD.FromDouble(fs.D);
                frm.NudE.FromDouble(fs.E);

                frm.EnableChanged();
            }

            public static void Write(FormSetting fs, string path)
            {
                var serializer = new XmlSerializer(fs.GetType());
                var directory = Path.GetDirectoryName(path);
                if (!string.IsNullOrWhiteSpace(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                using var writer = XmlWriter.Create(path);
                serializer.Serialize(writer, fs);
            }

            public static FormSetting Read(string path)
            {
                var serializer = new XmlSerializer(typeof(FormSetting));
                using var reader = XmlReader.Create(path);
                var fs = (FormSetting?)serializer.Deserialize(reader);
                return fs ?? new FormSetting();
            }
        }

        private void Smi_Click(object sender, EventArgs e)
        {
            if (sender == SmiSave)
            {
                FormSetting.Write(FormSetting.Get(this), $"{nameof(FrmQuartic)}.xml");
            }
            else if (sender == SmiLoad)
            {
                var setting = FormSetting.Read($"{nameof(FrmQuartic)}.xml");
                FormSetting.Set(this, setting);
            }
            else if (sender == SmiInc)
            {
                var frm = new FrmIncTimer
                {
                    Nud = nudInc,
                };
                frm.Show();
            }

            else if (sender == SmiPackingCirclesInACircle)
            {
                new FrmPackingCirclesInACircle().Show();
            }
            else if (sender == SmiPackingCirclesInASquare)
            {
                new FrmPackingCirclesInASquare().Show();
            }
            else if (sender == SmiPackingCirclesInARectangle)
            {
                new FrmPackingCirclesInARectangle().Show();
            }

            else if (sender == SmiQuadratic)
            {
                new FrmQuadratic().Show();
            }
            else if (sender == SmiCubic)
            {
                new FrmCubic().Show();
            }
            else if (sender == SmiQuartic)
            {
                new FrmQuartic().Show();
            }

            else if (sender == SmiCircleAndSegment)
            {
                new FrmCircleAndSegment().Show();
            }
            else if (sender == SmiTwoCircles)
            {
                new FrmTwoCircles().Show();
            }

            else if (sender == SmiEllipseAndTangentLine)
            {
                new FrmEllipseAndTangentLine().Show();
            }
            else if (sender == SmiEllipseAndSegment)
            {
                new FrmEllipseAndSegment().Show();
            }
            else if (sender == SmiEllipseAndTangentCircle)
            {
                new FrmEllipseAndTangentCircle().Show();
            }
            else if (sender == SmiEllipseAndCircle)
            {
                new FrmEllipseAndCircle().Show();
            }
            else if (sender == SmiEllipseAndTangentEllipse)
            {
                new FrmEllipseAndTangentEllipse().Show();
            }
            else if (sender == SmiTwoEllipses)
            {
                new FrmTwoEllipses().Show();
            }

            else if (sender == SmiTwoSegments)
            {
                new FrmTwoSegments().Show();
            }

            else if (sender == SmiOpenGl)
            {
                new FrmOpenGl().Show();
            }
            else if (sender == SmiTwoCircle3Projections)
            {
                Process.Start("Photon.exe", "TwoCircle3Projections");
            }

            else if (sender == SmiFlatScreen)
            {
                new FrmFlatScreen().Show();
            }
            else if (sender == SmiFlatScreenVector)
            {
                new FrmFlatScreenVector().Show();
            }
            else if (sender == SmiSphericalScreen)
            {
                new FrmSphericalScreen().Show();
            }
            else if (sender == SmiSphericalScreenVector)
            {
                new FrmSphericalScreenVector().Show();
            }
            else if (sender == SmiSpace)
            {
                new FrmSpace().Show();
            }
            else if (sender == SmiSpaceVector)
            {
                new FrmSpaceVector().Show();
            }
        }

        private void FormSetting_Changed(object? sender, EventArgs e)
        {
            RefreshValues(sender);

            setting = FormSetting.Get(this);
            Draw();
        }

        private NumericUpDown? nudInc;
        private void NudInc_Click(object sender, EventArgs e)
        {
            var nud = (NumericUpDown)sender;
            SmiInc.Text = "Increase " + nud.Name["Nud".Length..];
            nudInc = nud;
        }

        private void Trb_ValueChanged(object? sender, EventArgs e)
        {
            if (sender == TrbA)
            {
                NudA.Value = TrbA.Value * (NudMaxA.Value - NudMinA.Value) / TrbA.Maximum + NudMinA.Value;
            }
            else if (sender == TrbB)
            {
                NudB.Value = TrbB.Value * (NudMaxB.Value - NudMinB.Value) / TrbB.Maximum + NudMinB.Value;
            }
            else if (sender == TrbC)
            {
                NudC.Value = TrbC.Value * (NudMaxC.Value - NudMinC.Value) / TrbC.Maximum + NudMinC.Value;
            }
            else if (sender == TrbD)
            {
                NudD.Value = TrbD.Value * (NudMaxD.Value - NudMinD.Value) / TrbD.Maximum + NudMinD.Value;
            }
            else if (sender == TrbE)
            {
                NudE.Value = TrbE.Value * (NudMaxE.Value - NudMinE.Value) / TrbE.Maximum + NudMinE.Value;
            }
        }

        private void PnlFill_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void PnlFill_MouseDown(object sender, MouseEventArgs e)
        {
            PnlFill.Focus();

            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                PnlFill.Tag = true;

                downX = e.X;
                downY = e.Y;
                downSetting = setting;
            }
        }

        private void PnlFill_MouseMove(object sender, MouseEventArgs e)
        {
            if ((bool?)PnlFill.Tag == true)
            {
                var offsetX = e.X - downX;
                var offsetY = downY - e.Y;

                if (e.Button == MouseButtons.Left)
                {
                    Offset(downSetting, offsetX, offsetY);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Scale(downSetting, -0.001 * offsetX, 0.001 * offsetY);
                }
            }
        }

        private void PnlFill_MouseUp(object sender, MouseEventArgs e)
        {
            if ((bool?)PnlFill.Tag == true)
            {
                FormSetting.Set(this, setting);
                PnlFill.Tag = null;
            }
        }

        private void PnlFill_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                Offset(setting, 1, 0);
                FormSetting.Set(this, setting);
            }
            else if (e.KeyData == Keys.Up)
            {
                Offset(setting, 0, 1);
                FormSetting.Set(this, setting);
            }
            else if (e.KeyData == Keys.Left)
            {
                Offset(setting, -1, 0);
                FormSetting.Set(this, setting);
            }
            else if (e.KeyData == Keys.Down)
            {
                Offset(setting, 0, -1);
                FormSetting.Set(this, setting);
            }
        }

        public void DisableChanged()
        {
            NudMinA.ValueChanged -= FormSetting_Changed;
            NudA.ValueChanged -= FormSetting_Changed;
            NudMaxA.ValueChanged -= FormSetting_Changed;
            TrbA.ValueChanged -= Trb_ValueChanged;

            NudMinB.ValueChanged -= FormSetting_Changed;
            NudB.ValueChanged -= FormSetting_Changed;
            NudMaxB.ValueChanged -= FormSetting_Changed;
            TrbB.ValueChanged -= Trb_ValueChanged;

            NudMinC.ValueChanged -= FormSetting_Changed;
            NudC.ValueChanged -= FormSetting_Changed;
            NudMaxC.ValueChanged -= FormSetting_Changed;
            TrbC.ValueChanged -= Trb_ValueChanged;

            NudMinD.ValueChanged -= FormSetting_Changed;
            NudD.ValueChanged -= FormSetting_Changed;
            NudMaxD.ValueChanged -= FormSetting_Changed;
            TrbD.ValueChanged -= Trb_ValueChanged;

            NudMinE.ValueChanged -= FormSetting_Changed;
            NudE.ValueChanged -= FormSetting_Changed;
            NudMaxE.ValueChanged -= FormSetting_Changed;
            TrbE.ValueChanged -= Trb_ValueChanged;
        }

        public void EnableChanged()
        {
            NudMinA.ValueChanged += FormSetting_Changed;
            NudA.ValueChanged += FormSetting_Changed;
            NudMaxA.ValueChanged += FormSetting_Changed;
            TrbA.ValueChanged += Trb_ValueChanged;

            NudMinB.ValueChanged += FormSetting_Changed;
            NudB.ValueChanged += FormSetting_Changed;
            NudMaxB.ValueChanged += FormSetting_Changed;
            TrbB.ValueChanged += Trb_ValueChanged;

            NudMinC.ValueChanged += FormSetting_Changed;
            NudC.ValueChanged += FormSetting_Changed;
            NudMaxC.ValueChanged += FormSetting_Changed;
            TrbC.ValueChanged += Trb_ValueChanged;

            NudMinD.ValueChanged += FormSetting_Changed;
            NudD.ValueChanged += FormSetting_Changed;
            NudMaxD.ValueChanged += FormSetting_Changed;
            TrbD.ValueChanged += Trb_ValueChanged;

            NudMinE.ValueChanged += FormSetting_Changed;
            NudE.ValueChanged += FormSetting_Changed;
            NudMaxE.ValueChanged += FormSetting_Changed;
            TrbE.ValueChanged += Trb_ValueChanged;
        }

        public void RefreshValues(object? sender)
        {
            DisableChanged();

            #region A
            if (sender == null || sender == NudMinA)
            {
                if (NudMinA.Value >= NudMaxA.Value)
                {
                    NudMaxA.Value = NudMinA.Value + 1;
                    NudA.Maximum = NudMaxA.Value;
                }
                NudA.Minimum = NudMinA.Value;
            }

            if (sender == null || sender == NudMaxA)
            {
                if (NudMaxA.Value <= NudMinA.Value)
                {
                    NudMinA.Value = NudMaxA.Value - 1;
                    NudA.Minimum = NudMinA.Value;
                }
                NudA.Maximum = NudMaxA.Value;
            }

            NudA.Increment = (NudA.Maximum - NudA.Minimum) / 10;

            if (sender == null || sender == NudA)
            {
                TrbA.Value = (int)(TrbA.Maximum * (NudA.Value - NudMinA.Value) / (NudMaxA.Value - NudMinA.Value));
            }
            #endregion

            #region B
            if (sender == null || sender == NudMinB)
            {
                if (NudMinB.Value >= NudMaxB.Value)
                {
                    NudMaxB.Value = NudMinB.Value + 1;
                    NudB.Maximum = NudMaxB.Value;
                }
                NudB.Minimum = NudMinB.Value;
            }

            if (sender == null || sender == NudMaxB)
            {
                if (NudMaxB.Value <= NudMinB.Value)
                {
                    NudMinB.Value = NudMaxB.Value - 1;
                    NudB.Minimum = NudMinB.Value;
                }
                NudB.Maximum = NudMaxB.Value;
            }

            if (sender == null || sender == NudB)
            {
                TrbB.Value = (int)(TrbB.Maximum * (NudB.Value - NudMinB.Value) / (NudMaxB.Value - NudMinB.Value));
            }
            #endregion

            #region C
            if (sender == null || sender == NudMinC)
            {
                if (NudMinC.Value >= NudMaxC.Value)
                {
                    NudMaxC.Value = NudMinC.Value + 1;
                    NudC.Maximum = NudMaxC.Value;
                }
                NudC.Minimum = NudMinC.Value;
            }

            if (sender == null || sender == NudMaxC)
            {
                if (NudMaxC.Value <= NudMinC.Value)
                {
                    NudMinC.Value = NudMaxC.Value - 1;
                    NudC.Minimum = NudMinC.Value;
                }
                NudC.Maximum = NudMaxC.Value;
            }

            if (sender == null || sender == NudC)
            {
                TrbC.Value = (int)(TrbC.Maximum * (NudC.Value - NudMinC.Value) / (NudMaxC.Value - NudMinC.Value));
            }
            #endregion

            #region D
            if (sender == null || sender == NudMinD)
            {
                if (NudMinD.Value >= NudMaxD.Value)
                {
                    NudMaxD.Value = NudMinD.Value + 1;
                    NudD.Maximum = NudMaxD.Value;
                }
                NudD.Minimum = NudMinD.Value;
            }

            if (sender == null || sender == NudMaxD)
            {
                if (NudMaxD.Value <= NudMinD.Value)
                {
                    NudMinD.Value = NudMaxD.Value - 1;
                    NudD.Minimum = NudMinD.Value;
                }
                NudD.Maximum = NudMaxD.Value;
            }

            NudD.Increment = (NudD.Maximum - NudD.Minimum) / 10;

            if (sender == null || sender == NudD)
            {
                TrbD.Value = (int)(TrbD.Maximum * (NudD.Value - NudMinD.Value) / (NudMaxD.Value - NudMinD.Value));
            }
            #endregion

            #region E
            if (sender == null || sender == NudMinE)
            {
                if (NudMinE.Value >= NudMaxE.Value)
                {
                    NudMaxE.Value = NudMinE.Value + 1;
                    NudE.Maximum = NudMaxE.Value;
                }
                NudE.Minimum = NudMinE.Value;
            }

            if (sender == null || sender == NudMaxE)
            {
                if (NudMaxE.Value <= NudMinE.Value)
                {
                    NudMinE.Value = NudMaxE.Value - 1;
                    NudE.Minimum = NudMinE.Value;
                }
                NudE.Maximum = NudMaxE.Value;
            }

            NudE.Increment = (NudE.Maximum - NudE.Minimum) / 10;

            if (sender == null || sender == NudE)
            {
                TrbE.Value = (int)(TrbE.Maximum * (NudE.Value - NudMinE.Value) / (NudMaxE.Value - NudMinE.Value));
            }
            #endregion


            EnableChanged();
        }

        public void Offset(FormSetting fs, double dx, double dy)
        {
            (setting.B, setting.C, setting.D, setting.E) = (
                fs.B - 4 * fs.A * dx,
                fs.C - 3 * fs.B * dx + 6 * fs.A * dx * dx,
                3 * fs.B * dx * dx - 4 * fs.A * dx * dx * dx - 2 * fs.C * dx + fs.D,
                fs.A * dx * dx * dx * dx - fs.B * dx * dx * dx + fs.C * dx * dx - fs.D * dx + fs.E + dy
            );
            Draw();
        }

        public void Scale(FormSetting fs, double dx, double dy)
        {
            (setting.A, setting.B, setting.C, setting.D, setting.E) = (
                fs.A * (1 + dx) * (1 + dx) * (1 + dx) * (1 + dx) / (1 + dy),
                fs.B * (1 + dx) * (1 + dx) * (1 + dx) / (1 + dy),
                fs.C * (1 + dx) * (1 + dx) / (1 + dy),
                fs.D * (1 + dx) / (1 + dy),
                fs.E / (1 + dy));

            Draw();
        }

        private void DrawFunction(Bitmap bmp, Color color)
        {
            var a = setting.A;
            var b = setting.B;
            var c = setting.C;
            var d = setting.D;
            var e = setting.E;

            var lastY = double.NaN;

            var w_2 = bmp.Width / 2.0;
            var h_2 = bmp.Height / 2.0;

            for (var x = -w_2; x <= w_2; x++)
            {
                var y = a * x * x * x * x + b * x * x * x + c * x * x + d * x + e;

                var px = x + w_2;
                var py = h_2 - y;
                if (px >= 0 && py >= 0 && px < bmp.Width && py < bmp.Height)
                {
                    bmp.SetPixel((int)px, (int)py, color);

                    if (!double.IsNaN(lastY))
                    {
                        var diff = Math.Abs(y - lastY);
                        if (diff > 1)
                        {
                            var step = 1 / diff;
                            for (var n = 1; n < diff; n++)
                            {
                                px = x + n * step;
                                py = a * px * px * px * px + b * px * px * px + c * px * px + d * px + e;

                                px += w_2;
                                py = h_2 - py;

                                if (px >= 0 && py >= 0 && px < bmp.Width && py < bmp.Height)
                                {
                                    bmp.SetPixel((int)px, (int)py, color);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }

                lastY = y;
            }
        }

        private void Draw()
        {
            Algebra.Quartic(setting.A, setting.B, setting.C, setting.D, setting.E, out Big x1, out Big x2, out Big x3, out Big x4);

            //var test = @$"
            //a = {setting.A};
            //b = {setting.B};
            //c = {setting.C};
            //d = {setting.D};
            //e = {setting.E};
            //Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            ////Assert.True(ValuesIn(new[] {{ x1, x2, x3, x4 }}, ));";
            //Debug.WriteLine(test);
            //Debug.WriteLine("-------------------------------------");

            var grayPen = new Pen(Color.FromArgb(100, 100, 100))
            {
                Width = !x1.IsNaN || !x2.IsNaN || !x3.IsNaN || !x4.IsNaN ? 1 : 3
            };

            using (var g = Graphics.FromImage(db.Bitmap))
            {
                g.Clear(Color.Black);
                g.Line(Helper.AxisPen, -db.Width / 2, 0, db.Width / 2, 0);
                g.Line(Helper.AxisPen, 0, -db.Height / 2, 0, db.Height / 2);

                var i1 = !x1.IsNaN;
                var i2 = !x2.IsNaN;
                var i3 = !x3.IsNaN;
                var i4 = !x4.IsNaN;

                if (i1)
                {
                    g.FillCircle(Brushes.White, x1, 0, 5);
                }

                if (i2)
                {
                    g.FillCircle(Brushes.White, x2, 0, 5);
                }

                if (i3)
                {
                    g.FillCircle(Brushes.White, x3, 0, 5);
                }

                if (i4)
                {
                    g.FillCircle(Brushes.White, x4, 0, 5);
                }

                DrawFunction(db.Bitmap, i1 || i2 || i3 || i4 ? Color.Red : grayPen.Color);
            }

            var g1 = PnlFill.CreateGraphics();
            g1.DrawImageUnscaled(db.Bitmap, PnlFill.Width / 2 - db.Width / 2, PnlFill.Height / 2 - db.Height / 2);
        }
    }
}
