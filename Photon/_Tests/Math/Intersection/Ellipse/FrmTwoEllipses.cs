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

namespace Photon.TestIntersection
{
    public partial class FrmTwoEllipses : Form
    {
        private readonly DirectBitmap db = new(1910, 1040);

        private int downX;
        private int downY;
        private FormSetting setting;
        private FormSetting downSetting;

        public FrmTwoEllipses()
        {
            InitializeComponent();
            setting = FormSetting.Get(this);
            downSetting = setting;
        }

        private void FrmTwoEllipses_Load(object sender, EventArgs e)
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

            public double Epsilon;

            public static FormSetting Get(FrmTwoEllipses frm)
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
                };
            }

            public static void Set(FrmTwoEllipses frm, FormSetting fs)
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
                FormSetting.Write(FormSetting.Get(this), $"{nameof(FrmTwoEllipses)}.xml");
            }
            else if (sender == SmiLoad)
            {
                var setting = FormSetting.Read($"{nameof(FrmTwoEllipses)}.xml");
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
        }

        private void Draw()
        {
            var rotate1 = Big.Rad(setting.Rotate1);
            var rotate2 = Big.Rad(setting.Rotate2);
            Intersection.TwoEllipses(setting.Ex1, setting.Ey1, setting.Ea1, setting.Eb1, rotate1, setting.Ex2, setting.Ey2, setting.Ea2, setting.Eb2, rotate2, out Point p1, out Point p2, out Point p3, out Point p4);
            var ps = new[] { p1, p2, p3, p4 };
            bool Many(Point point) => ps.Count(p => p == point) > 1;

            //var test = @$"
            //ex1 = {setting.Ex1};
            //ey1 = {setting.Ey1};
            //ea1 = {setting.Ea1};
            //eb1 = {setting.Eb1};
            //rotate1 = Big.Rad({setting.Rotate1});
            //ex2 = {setting.Ex2};
            //ey2 = {setting.Ey2};
            //ea2 = {setting.Ea2};
            //eb2 = {setting.Eb2};
            //rotate2 = Big.Rad({setting.Rotate2});
            //Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            ////Assert.True(PointsIn(new[] {{x1,y1, x2, y2, x3, y3, x4, y4 }}, ));";
            //Debug.WriteLine(test);
            //Debug.WriteLine("-------------------------------------");

            var grayPen = new Pen(Color.FromArgb(100, 100, 100))
            {
                Width = p1.IsReal() || p2.IsReal() || p3.IsReal() || p4.IsReal() ? 1 : 3
            };

            using (var g = Graphics.FromImage(db.Bitmap))
            {
                g.Clear(Color.Black);
                g.Line(Helper.AxisPen, -db.Width / 2, 0, db.Width / 2, 0);
                g.Line(Helper.AxisPen, 0, -db.Height / 2, 0, db.Height / 2);

                g.Ellipse(p1.IsReal() || p2.IsReal() || p3.IsReal() || p4.IsReal() ? Pens.Red : grayPen, setting.Ex1, setting.Ey1, setting.Ea1, setting.Eb1, rotate1);
                g.Ellipse(p1.IsReal() || p2.IsReal() || p3.IsReal() || p4.IsReal() ? Pens.Blue : grayPen, setting.Ex2, setting.Ey2, setting.Ea2, setting.Eb2, rotate2);

                if (p1.IsReal())
                {
                    g.FillCircle(Many(p1) ? Brushes.Blue : Brushes.White, p1, 5);
                }

                if (p2.IsReal())
                {
                    g.FillCircle(Many(p2) ? Brushes.Blue : Brushes.White, p2, 5);
                }

                if (p3.IsReal())
                {
                    g.FillCircle(Many(p3) ? Brushes.Blue : Brushes.White, p3, 5);
                }

                if (p4.IsReal())
                {
                    g.FillCircle(Many(p4) ? Brushes.Blue : Brushes.White, p4, 5);
                }
            }

            var g1 = PnlFill.CreateGraphics();
            g1.DrawImageUnscaled(db.Bitmap, PnlFill.Width / 2 - db.Width / 2, PnlFill.Height / 2 - db.Height / 2);
        }
    }
}
