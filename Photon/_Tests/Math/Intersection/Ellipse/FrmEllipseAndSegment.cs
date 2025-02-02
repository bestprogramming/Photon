﻿using Photon;
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
    public partial class FrmEllipseAndSegment : Form
    {
        private readonly DirectBitmap db = new(1910, 1040);

        private int downX;
        private int downY;
        private FormSetting setting;
        private FormSetting downSetting;

        public FrmEllipseAndSegment()
        {
            InitializeComponent();
            setting = FormSetting.Get(this);
            downSetting = setting;
        }

        private void FrmEllipseAndSegment_Load(object sender, EventArgs e)
        {
            PnlFill.Focus();
        }

        public struct FormSetting
        {
            public double Ex;
            public double Ey;
            public double Ea;
            public double Eb;
            public double Rotate;

            public double X1;
            public double Y1;
            public double X2;
            public double Y2;

            public double Epsilon;

            public static FormSetting Get(FrmEllipseAndSegment frm)
            {
                return new FormSetting
                {
                    Ex = frm.NudEx.ToDouble(),
                    Ey = frm.NudEy.ToDouble(),
                    Ea = frm.NudEa.ToDouble(),
                    Eb = frm.NudEb.ToDouble(),
                    Rotate = frm.NudRotate.ToDouble(),

                    X1 = frm.NudX1.ToDouble(),
                    Y1 = frm.NudY1.ToDouble(),
                    X2 = frm.NudX2.ToDouble(),
                    Y2 = frm.NudY2.ToDouble(),
                };
            }

            public static void Set(FrmEllipseAndSegment frm, FormSetting fs)
            {
                frm.DisableChanged();

                frm.NudEx.FromDouble(fs.Ex);
                frm.NudEy.FromDouble(fs.Ey);
                frm.NudEa.FromDouble(fs.Ea);
                frm.NudEb.FromDouble(fs.Eb);
                frm.NudRotate.FromDouble(fs.Rotate);

                frm.NudX1.FromDouble(fs.X1);
                frm.NudY1.FromDouble(fs.Y1);
                frm.NudX2.FromDouble(fs.X2);
                frm.NudY2.FromDouble(fs.Y2);

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
                FormSetting.Write(FormSetting.Get(this), $"{nameof(FrmEllipseAndSegment)}.xml");
            }
            else if (sender == SmiLoad)
            {
                var setting = FormSetting.Read($"{nameof(FrmEllipseAndSegment)}.xml");
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
                    setting.Ex = downSetting.Ex + offsetX;
                    setting.Ey = downSetting.Ey + offsetY;
                    Draw();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    setting.X1 = downSetting.X1 + offsetX;
                    setting.Y1 = downSetting.Y1 + offsetY;
                    setting.X2 = downSetting.X2 + offsetX;
                    setting.Y2 = downSetting.Y2 + offsetY;
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
                NudEx.Value += 1;
            }
            else if (e.KeyData == Keys.Up)
            {
                NudEy.Value += 1;
            }
            else if (e.KeyData == Keys.Left)
            {
                NudEx.Value -= 1;
            }
            else if (e.KeyData == Keys.Down)
            {
                NudEy.Value -= 1;
            }
        }

        public void DisableChanged()
        {
            NudEx.ValueChanged -= FormSetting_Changed;
            NudEy.ValueChanged -= FormSetting_Changed;
            NudEa.ValueChanged -= FormSetting_Changed;
            NudEb.ValueChanged -= FormSetting_Changed;
            NudRotate.ValueChanged -= FormSetting_Changed;

            NudX1.ValueChanged -= FormSetting_Changed;
            NudY1.ValueChanged -= FormSetting_Changed;
            NudX2.ValueChanged -= FormSetting_Changed;
            NudY2.ValueChanged -= FormSetting_Changed;
        }

        public void EnableChanged()
        {
            NudEx.ValueChanged += FormSetting_Changed;
            NudEy.ValueChanged += FormSetting_Changed;
            NudEa.ValueChanged += FormSetting_Changed;
            NudEb.ValueChanged += FormSetting_Changed;
            NudRotate.ValueChanged += FormSetting_Changed;

            NudX1.ValueChanged += FormSetting_Changed;
            NudY1.ValueChanged += FormSetting_Changed;
            NudX2.ValueChanged += FormSetting_Changed;
            NudY2.ValueChanged += FormSetting_Changed;
        }

        private void Draw()
        {
            var rotate = Big.Rad(setting.Rotate);
            Intersection.EllipseAndSegment(setting.Ex, setting.Ey, setting.Ea, setting.Eb, rotate, setting.X1, setting.Y1, setting.X2, setting.Y2, out Point p1, out Point p2);
            var ps = new[] { p1, p2 };
            bool Many(Point point) => ps.Count(p => p == point) > 1;

            var test = @$"
            ex = {setting.Ex};
            ey = {setting.Ey};
            ea = {setting.Ea};
            eb = {setting.Eb};
            rotate = {setting.Rotate};
            sx1 = {setting.X1};
            sy1 = {setting.Y1};
            sx2 = {setting.X2};
            sy2 = {setting.Y2};
            ok = Intersection.EllipseAndSegment(ex, ey, ea, eb, rotate, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            //Assert.True(ok.B1 && ok.B2 && E(x1, ) && E(y1, ) && E(x2, ) && E(y2, ));";
            Debug.WriteLine(test);
            Debug.WriteLine("-------------------------------------");

            var in1 = Big.In(p1.X, setting.X1, setting.X2) && Big.In(p1.Y, setting.Y1, setting.Y2);
            var in2 = Big.In(p2.X, setting.X1, setting.X2) && Big.In(p2.Y, setting.Y1, setting.Y2);

            var grayPen = new Pen(Color.FromArgb(100, 100, 100))
            {
                Width = p1.IsReal() || p2.IsReal() ? 1 : 3
            };
            var grayBrush = new SolidBrush(grayPen.Color);

            using (var g = Graphics.FromImage(db.Bitmap))
            {
                g.Clear(Color.Black);
                g.Line(Helper.AxisPen, -db.Width / 2, 0, db.Width / 2, 0);
                g.Line(Helper.AxisPen, 0, -db.Height / 2, 0, db.Height / 2);

                if (p1.IsReal())
                {
                    g.FillCircle(Many(p1) ? Brushes.Blue : in1 ? Brushes.White : grayBrush, p1, 5);
                }

                if (p2.IsReal())
                {
                    g.FillCircle(Many(p2) ? Brushes.Blue : in2 ? Brushes.White : grayBrush, p2, 5);
                }

                g.Ellipse(in1 || in2 ? Pens.Red : grayPen, setting.Ex, setting.Ey, setting.Ea, setting.Eb, rotate);
                g.Line(in1 || in2 ? Pens.Green : grayPen, setting.X1, setting.Y1, setting.X2, setting.Y2);
            }

            var g1 = PnlFill.CreateGraphics();
            g1.DrawImageUnscaled(db.Bitmap, PnlFill.Width / 2 - db.Width / 2, PnlFill.Height / 2 - db.Height / 2);
        }
    }
}
