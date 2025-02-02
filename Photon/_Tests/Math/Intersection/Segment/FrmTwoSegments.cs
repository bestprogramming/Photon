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
    public partial class FrmTwoSegments : Form
    {
        private readonly DirectBitmap db = new(1910, 1040);

        private int downX;
        private int downY;
        private FormSetting setting;
        private FormSetting downSetting;

        public FrmTwoSegments()
        {
            InitializeComponent();
            setting = FormSetting.Get(this);
            downSetting = setting;
        }

        private void FrmTwoSegments_Load(object sender, EventArgs e)
        {
            PnlFill.Focus();
        }

        public struct FormSetting
        {
            public double X1;
            public double Y1;
            public double X2;
            public double Y2;

            public double X3;
            public double Y3;
            public double X4;
            public double Y4;

            public double Epsilon;

            public static FormSetting Get(FrmTwoSegments frm)
            {
                return new FormSetting
                {
                    X1 = frm.NudX1.ToDouble(),
                    Y1 = frm.NudY1.ToDouble(),
                    X2 = frm.NudX2.ToDouble(),
                    Y2 = frm.NudY2.ToDouble(),

                    X3 = frm.NudX3.ToDouble(),
                    Y3 = frm.NudY3.ToDouble(),
                    X4 = frm.NudX4.ToDouble(),
                    Y4 = frm.NudY4.ToDouble(),
                };
            }

            public static void Set(FrmTwoSegments frm, FormSetting fs)
            {
                frm.DisableChanged();

                frm.NudX1.FromDouble(fs.X1);
                frm.NudY1.FromDouble(fs.Y1);
                frm.NudX2.FromDouble(fs.X2);
                frm.NudY2.FromDouble(fs.Y2);

                frm.NudX3.FromDouble(fs.X3);
                frm.NudY3.FromDouble(fs.Y3);
                frm.NudX4.FromDouble(fs.X4);
                frm.NudY4.FromDouble(fs.Y4);

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
                FormSetting.Write(FormSetting.Get(this), $"{nameof(FrmTwoSegments)}.xml");
            }
            else if (sender == SmiLoad)
            {
                var setting = FormSetting.Read($"{nameof(FrmTwoSegments)}.xml");
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
                    setting.X1 = downSetting.X1 + offsetX;
                    setting.Y1 = downSetting.Y1 + offsetY;
                    setting.X2 = downSetting.X2 + offsetX;
                    setting.Y2 = downSetting.Y2 + offsetY;
                    Draw();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    setting.X3 = downSetting.X3 + offsetX;
                    setting.Y3 = downSetting.Y3 + offsetY;
                    setting.X4 = downSetting.X4 + offsetX;
                    setting.Y4 = downSetting.Y4 + offsetY;
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
                NudX1.Value += 1;
            }
            else if (e.KeyData == Keys.Up)
            {
                NudY1.Value += 1;
            }
            else if (e.KeyData == Keys.Left)
            {
                NudX1.Value -= 1;
            }
            else if (e.KeyData == Keys.Down)
            {
                NudY1.Value -= 1;
            }
        }

        public void DisableChanged()
        {
            NudX1.ValueChanged -= FormSetting_Changed;
            NudY1.ValueChanged -= FormSetting_Changed;
            NudX2.ValueChanged -= FormSetting_Changed;
            NudY2.ValueChanged -= FormSetting_Changed;

            NudX3.ValueChanged -= FormSetting_Changed;
            NudY3.ValueChanged -= FormSetting_Changed;
            NudX4.ValueChanged -= FormSetting_Changed;
            NudY4.ValueChanged -= FormSetting_Changed;
        }

        public void EnableChanged()
        {
            NudX1.ValueChanged += FormSetting_Changed;
            NudY1.ValueChanged += FormSetting_Changed;
            NudX2.ValueChanged += FormSetting_Changed;
            NudY2.ValueChanged += FormSetting_Changed;

            NudX3.ValueChanged += FormSetting_Changed;
            NudY3.ValueChanged += FormSetting_Changed;
            NudX4.ValueChanged += FormSetting_Changed;
            NudY4.ValueChanged += FormSetting_Changed;
        }

        private void Draw()
        {
            Intersection.TwoSegments(setting.X1, setting.Y1, setting.X2, setting.Y2, setting.X3, setting.Y3, setting.X4, setting.Y4, out Big x, out Big y);

            //var test = @$"
            //cx1 = {setting.X1};
            //cy1 = {setting.Y1};
            //cx2 = {setting.X2};
            //cy2 = {setting.Y2};
            //cx3 = {setting.X3};
            //cy3 = {setting.Y3};
            //cx4 = {setting.X4};
            //cy4 = {setting.Y4};
            //ok = Intersection.TwoSegments(x1, y1, x2, y2, x3, y3, x4, y4, out x, out y);
            ////Assert.True(ok.B1 && ok.B2 && E(x, ) && E(y, ));";
            //Debug.WriteLine(test);
            //Debug.WriteLine("-------------------------------------");

            var in1 = Big.In(x, setting.X1, setting.X2) && Big.In(y, setting.Y1, setting.Y2);
            var in2 = Big.In(x, setting.X3, setting.X4) && Big.In(y, setting.Y3, setting.Y4);

            var grayPen = new Pen(Color.FromArgb(100, 100, 100))
            {
                Width = x.IsReal() && y.IsReal() ? 1 : 3
            };

            using (var g = Graphics.FromImage(db.Bitmap))
            {
                g.Clear(Color.Black);
                g.Line(Helper.AxisPen, -db.Width / 2, 0, db.Width / 2, 0);
                g.Line(Helper.AxisPen, 0, -db.Height / 2, 0, db.Height / 2);

                if (x.IsReal() && y.IsReal())
                {
                    g.FillCircle(Brushes.White, x, y, 5);
                }

                g.Line(in1 ? Pens.Red : grayPen, setting.X1, setting.Y1, setting.X2, setting.Y2);
                g.Line(in2 ? Pens.Green : grayPen, setting.X3, setting.Y3, setting.X4, setting.Y4);
            }

            var g1 = PnlFill.CreateGraphics();
            g1.DrawImageUnscaled(db.Bitmap, PnlFill.Width / 2 - db.Width / 2, PnlFill.Height / 2 - db.Height / 2);
        }
    }
}
