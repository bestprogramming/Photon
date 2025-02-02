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
using System.Numerics;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using G = Photon.Geogebra;

namespace Photon.TestIntersection
{
    public partial class FrmEllipseAndTangentEllipse : Form
    {
        private readonly DirectBitmap db = new(1910, 1040);

        private int downX;
        private int downY;
        private FormSetting setting;
        private FormSetting downSetting;

        public FrmEllipseAndTangentEllipse()
        {
            InitializeComponent();
            setting = FormSetting.Get(this);
            downSetting = setting;
        }

        private void FrmEllipseAndTangentEllipse_Load(object sender, EventArgs e)
        {
            PnlFill.Focus();
        }

        public struct FormSetting
        {
            public double Ex1;
            public double Ey1;
            public double Ea1;
            public double Eb1;
            public double Rotate1;

            public double Ex2;
            public double Ey2;
            public double Ea2;
            public double Eb2;
            public double Rotate2;
            public bool Nearest;

            public static FormSetting Get(FrmEllipseAndTangentEllipse frm)
            {
                return new FormSetting
                {
                    Ex1 = frm.NudEx1.ToDouble(),
                    Ey1 = frm.NudEy1.ToDouble(),
                    Ea1 = frm.NudEa1.ToDouble(),
                    Eb1 = frm.NudEb1.ToDouble(),
                    Rotate1 = frm.NudRotate1.ToDouble(),

                    Ex2 = frm.NudEx2.ToDouble(),
                    Ey2 = frm.NudEy2.ToDouble(),
                    Ea2 = frm.NudEa2.ToDouble(),
                    Eb2 = frm.NudEb2.ToDouble(),
                    Rotate2 = frm.NudRotate2.ToDouble(),

                    Nearest = frm.ChbNearest.Checked,
                };
            }

            public static void Set(FrmEllipseAndTangentEllipse frm, FormSetting fs)
            {
                frm.DisableChanged();

                frm.NudEx1.FromDouble(fs.Ex1);
                frm.NudEy1.FromDouble(fs.Ey1);
                frm.NudEa1.FromDouble(fs.Ea1);
                frm.NudEb1.FromDouble(fs.Eb1);
                frm.NudRotate1.FromDouble(fs.Rotate1);

                frm.NudEx2.FromDouble(fs.Ex2);
                frm.NudEy2.FromDouble(fs.Ey2);
                frm.NudEa2.FromDouble(fs.Ea2);
                frm.NudEb2.FromDouble(fs.Eb2);
                frm.NudRotate2.FromDouble(fs.Rotate2);

                frm.ChbNearest.Checked = fs.Nearest;

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
                FormSetting.Write(FormSetting.Get(this), $"{nameof(FrmEllipseAndTangentEllipse)}.xml");
            }
            else if (sender == SmiLoad)
            {
                var setting = FormSetting.Read($"{nameof(FrmEllipseAndTangentEllipse)}.xml");
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
                    setting.Ex1 = downSetting.Ex1 + offsetX;
                    setting.Ey1 = downSetting.Ey1 + offsetY;
                    Draw();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    setting.Ex2 = downSetting.Ex2 + offsetX;
                    setting.Ey2 = downSetting.Ey2 + offsetY;
                    Draw();
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
                NudEx1.Value += 1;
            }
            else if (e.KeyData == Keys.Up)
            {
                NudEy1.Value += 1;
            }
            else if (e.KeyData == Keys.Left)
            {
                NudEx1.Value -= 1;
            }
            else if (e.KeyData == Keys.Down)
            {
                NudEy1.Value -= 1;
            }
        }

        public void DisableChanged()
        {
            NudEx1.ValueChanged -= FormSetting_Changed;
            NudEy1.ValueChanged -= FormSetting_Changed;
            NudEa1.ValueChanged -= FormSetting_Changed;
            NudEb1.ValueChanged -= FormSetting_Changed;
            NudRotate1.ValueChanged -= FormSetting_Changed;

            NudEx2.ValueChanged -= FormSetting_Changed;
            NudEy2.ValueChanged -= FormSetting_Changed;
            NudEa2.ValueChanged -= FormSetting_Changed;
            NudEb2.ValueChanged -= FormSetting_Changed;
            NudRotate2.ValueChanged -= FormSetting_Changed;
            ChbNearest.CheckedChanged -= FormSetting_Changed;
        }

        public void EnableChanged()
        {
            NudEx1.ValueChanged += FormSetting_Changed;
            NudEy1.ValueChanged += FormSetting_Changed;
            NudEa1.ValueChanged += FormSetting_Changed;
            NudEb1.ValueChanged += FormSetting_Changed;
            NudRotate1.ValueChanged += FormSetting_Changed;

            NudEx2.ValueChanged += FormSetting_Changed;
            NudEy2.ValueChanged += FormSetting_Changed;
            NudEa2.ValueChanged += FormSetting_Changed;
            NudEb2.ValueChanged += FormSetting_Changed;
            NudRotate2.ValueChanged += FormSetting_Changed;

            ChbNearest.CheckedChanged += FormSetting_Changed;
        }

        public double GetRatio(in Point p)
        {
            var rotate2 = Conversion.Rad(setting.Rotate2);
            var c = Math.Cos(rotate2);
            var s = Math.Sin(rotate2);
            var x2 = Math.Pow(c * (p.X - setting.Ex2) + s * (p.Y - setting.Ey2), 2);
            var y2 = Math.Pow(c * (p.Y - setting.Ey2) - s * (p.X - setting.Ex2), 2);
            var ret = Math.Sqrt(x2 / (setting.Ea2 * setting.Ea2) + y2 / (setting.Eb2 * setting.Eb2));
            return ret;
        }

        public void Geogebra(in Point p1, in Point p2, in Point p3, in Point p4)
        {
            var test = @$"
            ex1 = {setting.Ex1};
            ey1 = {setting.Ey1};
            ea1 = {setting.Ea1};
            eb1 = {setting.Eb1};
            rotate1 = Big.Rad({setting.Rotate1});
            ex2 = {setting.Ex2};
            ey2 = {setting.Ey2};
            ea2 = {setting.Ea2};
            eb2 = {setting.Eb2};
            unit = Math.Max(Math.Max(ea1, eb1), Math.Max(ea2, eb2));
            rotate2 = Big.Rad({setting.Rotate2});
            Intersection.EllipseAndTangentEllipse(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            //Assert.True(PointsIn(new[] {{ x1, y1, x2, y2, x3, y3, x4, y4 }}, unit, ));";
            Debug.WriteLine(test);
            Debug.WriteLine("-------------------------------------");

            var rotate1 = Conversion.Rad(setting.Rotate1);
            var rotate2 = Conversion.Rad(setting.Rotate2);
            var geogebra = G.Execute(
                G.EllipseXy(setting.Ex1, setting.Ey1, setting.Ea1, setting.Eb1, rotate1, "E1"),
                G.EllipseXy(setting.Ex2, setting.Ey2, setting.Ea2, setting.Eb2, rotate2, "E2"),
                G.Point(setting.Ex2, setting.Ey2, "CP2"),
                p1.IsReal() ? G.EllipseXy(setting.Ex2, setting.Ey2, setting.Ea2 * GetRatio(p1), setting.Eb2 * GetRatio(p1), rotate2, "TE1") + "," + G.Point(p1, "P1") : "",
                p2.IsReal() ? G.EllipseXy(setting.Ex2, setting.Ey2, setting.Ea2 * GetRatio(p2), setting.Eb2 * GetRatio(p2), rotate2, "TE2") + "," + G.Point(p2, "P2") : "",
                p3.IsReal() ? G.EllipseXy(setting.Ex2, setting.Ey2, setting.Ea2 * GetRatio(p3), setting.Eb2 * GetRatio(p3), rotate2, "TE3") + "," + G.Point(p3, "P3") : "",
                p4.IsReal() ? G.EllipseXy(setting.Ex2, setting.Ey2, setting.Ea2 * GetRatio(p4), setting.Eb2 * GetRatio(p4), rotate2, "TE4") + "," + G.Point(p4, "P4") : "",
                "");
            Debug.WriteLine(geogebra);
        }

        private void Draw()
        {
            var rotate1 = Big.Rad(setting.Rotate1);
            var rotate2 = Big.Rad(setting.Rotate2);
            Intersection.EllipseAndTangentEllipse(setting.Ex1, setting.Ey1, setting.Ea1, setting.Eb1, rotate1, setting.Ex2, setting.Ey2, setting.Ea2, setting.Eb2, rotate2, out Point p1, out Point p2, out Point p3, out Point p4);

            Geogebra(p1, p2, p3, p4);

            using (var g = Graphics.FromImage(db.Bitmap))
            {
                g.Clear(Color.Black);
                g.Line(Helper.AxisPen, -db.Width / 2, 0, db.Width / 2, 0);
                g.Line(Helper.AxisPen, 0, -db.Height / 2, 0, db.Height / 2);

                if (setting.Nearest)
                {
                    var ps = new Point[] { p1, p2, p3, p4 };
                    Closest.NearestOrder(setting.Ex2, setting.Ey2, ref ps, 0, out _);
                    if (ps[0].IsReal())
                    {
                        g.FillCircle(Brushes.Red, ps[0], 5);
                        var ratio = GetRatio(ps[0]);
                        g.Ellipse(Pens.White, setting.Ex2, setting.Ey2, setting.Ea2 * ratio, setting.Eb2 * ratio, rotate2);
                    }
                }
                else
                {
                    if (p1.IsReal())
                    {
                        g.FillCircle(Brushes.Red, p1, 5);
                        var ratio = GetRatio(p1);
                        g.Ellipse(Pens.White, setting.Ex2, setting.Ey2, setting.Ea2 * ratio, setting.Eb2 * ratio, rotate2);
                    }

                    if (p2.IsReal())
                    {
                        g.FillCircle(Brushes.Green, p2, 5);
                        var ratio = GetRatio(p2);
                        g.Ellipse(Pens.White, setting.Ex2, setting.Ey2, setting.Ea2 * ratio, setting.Eb2 * ratio, rotate2);
                    }

                    if (p3.IsReal())
                    {
                        g.FillCircle(Brushes.Blue, p3, 5);
                        var ratio = GetRatio(p3);
                        g.Ellipse(Pens.White, setting.Ex2, setting.Ey2, setting.Ea2 * ratio, setting.Eb2 * ratio, rotate2);
                    }

                    if (p4.IsReal())
                    {
                        g.FillCircle(Brushes.White, p4, 5);
                        var ratio = GetRatio(p4);
                        g.Ellipse(Pens.White, setting.Ex2, setting.Ey2, setting.Ea2 * ratio, setting.Eb2 * ratio, rotate2);
                    }
                }

                g.Ellipse(Pens.Red, setting.Ex1, setting.Ey1, setting.Ea1, setting.Eb1, rotate1);
                g.Ellipse(Pens.Green, setting.Ex2, setting.Ey2, setting.Ea2, setting.Eb2, rotate2);
            }

            var g1 = PnlFill.CreateGraphics();
            g1.DrawImageUnscaled(db.Bitmap, PnlFill.Width / 2 - db.Width / 2, PnlFill.Height / 2 - db.Height / 2);
        }
    }
}
