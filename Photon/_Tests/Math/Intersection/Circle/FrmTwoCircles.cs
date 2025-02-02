using Photon.FlatScreen;
using Photon.FlatScreenVector;
using Photon.Space;
using Photon.SpaceVector;
using Photon.SphericalScreen;
using Photon.SphericalScreenVector;
using Photon.TestOpenGl;
using Photon.TestPacking;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Photon.TestIntersection
{
    public partial class FrmTwoCircles : Form
    {
        private readonly DirectBitmap db = new(1910, 1040);

        private int downX;
        private int downY;
        private FormSetting setting;
        private FormSetting downSetting;

        public FrmTwoCircles()
        {
            InitializeComponent();
            setting = FormSetting.Get(this);
            downSetting = setting;
        }

        private void FrmTwoCircles_Load(object sender, EventArgs e)
        {
            PnlFill.Focus();
        }

        public struct FormSetting
        {
            public double Cx1;
            public double Cy1;
            public double R1;

            public double Cx2;
            public double Cy2;
            public double R2;

            public double Epsilon;

            public static FormSetting Get(FrmTwoCircles frm)
            {
                return new FormSetting
                {
                    Cx1 = frm.NudCx1.ToDouble(),
                    Cy1 = frm.NudCy1.ToDouble(),
                    R1 = frm.NudR1.ToDouble(),

                    Cx2 = frm.NudCx2.ToDouble(),
                    Cy2 = frm.NudCy2.ToDouble(),
                    R2 = frm.NudR2.ToDouble(),
                };
            }

            public static void Set(FrmTwoCircles frm, FormSetting fs)
            {
                frm.DisableChanged();

                frm.NudCx1.FromDouble(fs.Cx1);
                frm.NudCy1.FromDouble(fs.Cy1);
                frm.NudR1.FromDouble(fs.R1);

                frm.NudCx2.FromDouble(fs.Cx2);
                frm.NudCy2.FromDouble(fs.Cy2);
                frm.NudR2.FromDouble(fs.R2);

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
                FormSetting.Write(FormSetting.Get(this), $"{nameof(FrmTwoCircles)}.xml");
            }
            else if (sender == SmiLoad)
            {
                var setting = FormSetting.Read($"{nameof(FrmTwoCircles)}.xml");
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
                    setting.Cx1 = downSetting.Cx1 + offsetX;
                    setting.Cy1 = downSetting.Cy1 + offsetY;
                    Draw();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    setting.Cx2 = downSetting.Cx2 + offsetX;
                    setting.Cy2 = downSetting.Cy2 + offsetY;
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
                NudCx1.Value += 1;
            }
            else if (e.KeyData == Keys.Up)
            {
                NudCy1.Value += 1;
            }
            else if (e.KeyData == Keys.Left)
            {
                NudCx1.Value -= 1;
            }
            else if (e.KeyData == Keys.Down)
            {
                NudCy1.Value -= 1;
            }
        }

        public void DisableChanged()
        {
            NudCx1.ValueChanged -= FormSetting_Changed;
            NudCy1.ValueChanged -= FormSetting_Changed;
            NudR1.ValueChanged -= FormSetting_Changed;

            NudCx2.ValueChanged -= FormSetting_Changed;
            NudCy2.ValueChanged -= FormSetting_Changed;
            NudR2.ValueChanged -= FormSetting_Changed;
        }

        public void EnableChanged()
        {
            NudCx1.ValueChanged += FormSetting_Changed;
            NudCy1.ValueChanged += FormSetting_Changed;
            NudR1.ValueChanged += FormSetting_Changed;

            NudCx2.ValueChanged += FormSetting_Changed;
            NudCy2.ValueChanged += FormSetting_Changed;
            NudR2.ValueChanged += FormSetting_Changed;
        }

        private void Draw()
        {
            Intersection.TwoCircles(setting.Cx1, setting.Cy1, setting.R1, setting.Cx2, setting.Cy2, setting.R2, out Point p1, out Point p2);
            var ps = new[] { p1, p2 };
            bool Many(Point point) => ps.Count(p => p == point) > 1;

            //var test = @$"
            //cx1 = {setting.Cx1};
            //cy1 = {setting.Cy1};
            //r1 = {setting.R1};
            //cx2 = {setting.Cx2};
            //cy2 = {setting.Cy2};
            //r2 = {setting.R2};
            //ok = Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            ////Assert.True(ok && E(x1, ) && E(y1, ) && E(x2, ) && E(y2, ));";
            //Debug.WriteLine(test);
            //Debug.WriteLine("-------------------------------------");

            var grayPen = new Pen(Color.FromArgb(100, 100, 100))
            {
                Width = p1.IsReal() || p2.IsReal() ? 1 : 3
            };

            using (var g = Graphics.FromImage(db.Bitmap))
            {
                g.Clear(Color.Black);
                g.Line(Helper.AxisPen, -db.Width / 2, 0, db.Width / 2, 0);
                g.Line(Helper.AxisPen, 0, -db.Height / 2, 0, db.Height / 2);

                if (p1.IsReal())
                {
                    g.FillCircle(Many(p1) ? Brushes.Blue : Brushes.White, p1, 5);
                }

                if (p2.IsReal())
                {
                    g.FillCircle(Many(p2) ? Brushes.Blue : Brushes.White, p2, 5);
                }

                g.Circle(p1.IsReal() || p2.IsReal() ? Pens.Red : grayPen, setting.Cx1, setting.Cy1, setting.R1);
                g.Circle(p1.IsReal() || p2.IsReal() ? Pens.Green : grayPen, setting.Cx2, setting.Cy2, setting.R2);
            }

            var g1 = PnlFill.CreateGraphics();
            g1.DrawImageUnscaled(db.Bitmap, PnlFill.Width / 2 - db.Width / 2, PnlFill.Height / 2 - db.Height / 2);
        }
    }
}
