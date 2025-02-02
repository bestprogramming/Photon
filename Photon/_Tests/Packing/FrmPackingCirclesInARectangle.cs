using Photon.FlatScreen;
using Photon.FlatScreenVector;
using Photon.Space;
using Photon.SpaceVector;
using Photon.SphericalScreen;
using Photon.SphericalScreenVector;
using Photon.TestIntersection;
using Photon.TestOpenGl;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Photon.TestPacking
{
    public partial class FrmPackingCirclesInARectangle : Form
    {
        private int downX;
        private int downY;
        private FormSetting? downSetting;

        public FrmPackingCirclesInARectangle()
        {
            InitializeComponent();
        }

        private void FrmPackingCirclesInARectangle_Load(object sender, EventArgs e)
        {
            PnlFill.Focus();
        }

        public class FormSetting
        {
            public decimal X;
            public decimal Y;
            public decimal Width;
            public decimal Height;
            public int Count;
            public bool Axis;
            public bool Pixels;
            public bool Bounding;
            public bool FromCenter;
            public bool Area;

            public static FormSetting Get(FrmPackingCirclesInARectangle frm)
            {
                return new FormSetting
                {
                    X = frm.NudX.Value,
                    Y = frm.NudY.Value,
                    Width = frm.NudWidth.Value,
                    Height = frm.NudHeight.Value,
                    Count = (int)frm.NudCount.Value,
                    Axis = frm.ChbAxis.Checked,
                    Pixels = frm.ChbPixels.Checked,
                    Bounding = frm.ChbBounding.Checked,
                    FromCenter = frm.ChbFromCenter.Checked,
                    Area = frm.ChbArea.Checked,
                };
            }

            public static void Set(FrmPackingCirclesInARectangle frm, FormSetting fs)
            {
                frm.DisableChanged();

                frm.NudX.Value = fs.X;
                frm.NudY.Value = fs.Y;
                frm.NudWidth.Value = fs.Width;
                frm.NudHeight.Value = fs.Height;
                frm.NudCount.Value = fs.Count;
                frm.ChbAxis.Checked = fs.Axis;
                frm.ChbPixels.Checked = fs.Pixels;
                frm.ChbBounding.Checked = fs.Bounding;
                frm.ChbFromCenter.Checked = fs.FromCenter;
                frm.ChbArea.Checked = fs.Area;

                frm.EnableChanged();
                frm.Draw();
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
                FormSetting.Write(FormSetting.Get(this), $"{nameof(FrmPackingCirclesInARectangle)}.xml");
            }
            else if (sender == SmiLoad)
            {
                var setting = FormSetting.Read($"{nameof(FrmPackingCirclesInARectangle)}.xml");
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
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                downX = e.X;
                downY = e.Y;
                downSetting = FormSetting.Get(this);
            }
        }

        private void PnlFill_MouseMove(object sender, MouseEventArgs e)
        {
            var offsetX = e.X - downX;
            var offsetY = downY - e.Y;

            if (e.Button == MouseButtons.Left)
            {
                if (downSetting != null)
                {
                    PnlFill.Focus();

                    NudX.ValueChanged -= FormSetting_Changed;
                    NudX.Value = downSetting.X + offsetX;
                    NudX.ValueChanged += FormSetting_Changed;

                    NudY.Value = downSetting.Y + offsetY;
                }
            }
        }

        private void PnlFill_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                NudX.Value += 1;
            }
            else if (e.KeyData == Keys.Up)
            {
                NudY.Value += 1;
            }
            else if (e.KeyData == Keys.Left)
            {
                NudX.Value -= 1;
            }
            else if (e.KeyData == Keys.Down)
            {
                NudY.Value -= 1;
            }
        }

        public void DisableChanged()
        {
            NudX.ValueChanged -= FormSetting_Changed;
            NudY.ValueChanged -= FormSetting_Changed;
            NudWidth.ValueChanged -= FormSetting_Changed;
            NudCount.ValueChanged -= FormSetting_Changed;
            ChbAxis.CheckedChanged -= FormSetting_Changed;
            ChbPixels.CheckedChanged -= FormSetting_Changed;
            ChbBounding.CheckedChanged -= FormSetting_Changed;
            ChbFromCenter.CheckedChanged -= FormSetting_Changed;
            ChbArea.CheckedChanged -= FormSetting_Changed;
        }

        public void EnableChanged()
        {
            NudX.ValueChanged += FormSetting_Changed;
            NudY.ValueChanged += FormSetting_Changed;
            NudWidth.ValueChanged += FormSetting_Changed;
            NudCount.ValueChanged += FormSetting_Changed;
            ChbAxis.CheckedChanged += FormSetting_Changed;
            ChbPixels.CheckedChanged += FormSetting_Changed;
            ChbBounding.CheckedChanged += FormSetting_Changed;
            ChbFromCenter.CheckedChanged += FormSetting_Changed;
            ChbArea.CheckedChanged += FormSetting_Changed;
        }

        private int lastCount;
        private void Draw()
        {
            var x = NudX.ToDouble();
            var y = NudY.ToDouble();
            var width = NudWidth.ToDouble();
            var count = NudCount.ToInt();
            var n = count > lastCount ?
                (count >= Packing.CirclesInARectangle.Table.Last().Key ? Packing.CirclesInARectangle.Table.Last().Key : Packing.CirclesInARectangle.Table.First(p => p.Key >= count).Key) :
                (count <= Packing.CirclesInARectangle.Table.First().Key ? Packing.CirclesInARectangle.Table.First().Key : Packing.CirclesInARectangle.Table.Last(p => p.Key <= count).Key);
            lastCount = n;


            if (count != n)
            {
                DisableChanged();

                NudCount.FromInt(n);

                EnableChanged();
            }

            var row = Packing.CirclesInARectangle.Table[n];
            NudHeight.FromDouble(row.Height * width);
            var height = NudHeight.ToDouble();
            var centers = ChbArea.Checked ? Packing.CirclesInARectangle.GetAreaCenters(n) : Packing.CirclesInARectangle.GetBorderCenters(n);

            var db = new DirectBitmap(1910, 1040);

            using (var g = Graphics.FromImage(db.Bitmap))
            {
                g.Clear(Color.Black);
                if (ChbAxis.Checked)
                {
                    g.Line(Pens.Gray, -db.Width / 2, 0, db.Width / 2, 0);
                    g.Line(Pens.Gray, 0, -db.Height / 2, 0, db.Height / 2);
                }

                if (ChbBounding.Checked)
                {
                    var a_2 = width / 2;
                    var b_2 = height / 2;
                    g.Rectangle(Pens.Red, x - a_2, y - b_2, width, height);
                }

                if (ChbFromCenter.Checked)
                {
                    var aIn = width - 2 * width * row.Radius;
                    var a_2 = aIn / 2;
                    var bIn = height - 2 * width * row.Radius;
                    var b_2 = bIn / 2;
                    g.Rectangle(Pens.Blue, x - a_2, y - b_2, aIn, bIn);
                }

                foreach (var center in centers)
                {
                    var cxIn = x + center.X * width;
                    var cyIn = y + center.Y * width;
                    if (ChbPixels.Checked)
                    {
                        db.SetPixel(Pens.Green, cxIn, cyIn);
                    }
                    else
                    {
                        g.Circle(Pens.Green, cxIn, cyIn, row.Radius * width);
                    }
                }
            }

            var g1 = PnlFill.CreateGraphics();
            g1.DrawImageUnscaled(db.Bitmap, PnlFill.Width / 2 - db.Width / 2, PnlFill.Height / 2 - db.Height / 2);
        }
    }
}
