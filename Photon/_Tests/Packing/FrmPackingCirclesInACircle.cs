using Photon.FlatScreen;
using Photon.FlatScreenVector;
using Photon.Space;
using Photon.SpaceVector;
using Photon.SphericalScreen;
using Photon.SphericalScreenVector;
using Photon.TestIntersection;
using Photon.TestOpenGl;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Photon.TestPacking
{
    public partial class FrmPackingCirclesInACircle : Form
    {
        private int downX;
        private int downY;
        private FormSetting? downSetting;

        public FrmPackingCirclesInACircle()
        {
            InitializeComponent();
        }

        private void FrmPackingCirclesInACircle_Load(object sender, EventArgs e)
        {
            PnlFill.Focus();
        }


        public class FormSetting
        {
            public decimal Cx;
            public decimal Cy;
            public decimal R;
            public int Count;
            public bool Axis;
            public bool Pixels;
            public bool Bounding;
            public bool FromCenter;

            public static FormSetting Get(FrmPackingCirclesInACircle frm)
            {
                return new FormSetting
                {
                    Cx = frm.NudCx.Value,
                    Cy = frm.NudCy.Value,
                    R = frm.NudR.Value,
                    Count = (int)frm.NudCount.Value,
                    Axis = frm.ChbAxis.Checked,
                    Pixels = frm.ChbPixels.Checked,
                    Bounding = frm.ChbBounding.Checked,
                    FromCenter = frm.ChbFromCenter.Checked,
                };
            }

            public static void Set(FrmPackingCirclesInACircle frm, FormSetting fs)
            {
                frm.DisableChanged();

                frm.NudCx.Value = fs.Cx;
                frm.NudCy.Value = fs.Cy;
                frm.NudR.Value = fs.R;
                frm.NudCount.Value = fs.Count;
                frm.ChbAxis.Checked = fs.Axis;
                frm.ChbPixels.Checked = fs.Pixels;
                frm.ChbBounding.Checked = fs.Bounding;
                frm.ChbFromCenter.Checked = fs.FromCenter;

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
                FormSetting.Write(FormSetting.Get(this), $"{nameof(FrmPackingCirclesInACircle)}.xml");
            }
            else if (sender == SmiLoad)
            {
                var setting = FormSetting.Read($"{nameof(FrmPackingCirclesInACircle)}.xml");
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

                    NudCx.ValueChanged -= FormSetting_Changed;
                    NudCx.Value = downSetting.Cx + offsetX;
                    NudCx.ValueChanged += FormSetting_Changed;

                    NudCy.Value = downSetting.Cy + offsetY;
                }
            }
        }

        private void PnlFill_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                NudCx.Value += 1;
            }
            else if (e.KeyData == Keys.Up)
            {
                NudCy.Value += 1;
            }
            else if (e.KeyData == Keys.Left)
            {
                NudCx.Value -= 1;
            }
            else if (e.KeyData == Keys.Down)
            {
                NudCy.Value -= 1;
            }
        }

        public void DisableChanged()
        {
            NudCx.ValueChanged -= FormSetting_Changed;
            NudCy.ValueChanged -= FormSetting_Changed;
            NudR.ValueChanged -= FormSetting_Changed;
            NudCount.ValueChanged -= FormSetting_Changed;
            ChbAxis.CheckedChanged -= FormSetting_Changed;
            ChbPixels.CheckedChanged -= FormSetting_Changed;
            ChbBounding.CheckedChanged -= FormSetting_Changed;
            ChbFromCenter.CheckedChanged -= FormSetting_Changed;
        }

        public void EnableChanged()
        {
            NudCx.ValueChanged += FormSetting_Changed;
            NudCy.ValueChanged += FormSetting_Changed;
            NudR.ValueChanged += FormSetting_Changed;
            NudCount.ValueChanged += FormSetting_Changed;
            ChbAxis.CheckedChanged += FormSetting_Changed;
            ChbPixels.CheckedChanged += FormSetting_Changed;
            ChbBounding.CheckedChanged += FormSetting_Changed;
            ChbFromCenter.CheckedChanged += FormSetting_Changed;
        }

        private int lastCount;
        private void Draw()
        {
            var cx = NudCx.ToDouble();
            var cy = NudCy.ToDouble();
            var r = NudR.ToDouble();
            var count = NudCount.ToInt();
            var n = count > lastCount ?
                (count >= Packing.CirclesInACircle.Table.Last().Key ? Packing.CirclesInACircle.Table.Last().Key : Packing.CirclesInACircle.Table.First(p => p.Key >= count).Key) :
                (count <= Packing.CirclesInACircle.Table.First().Key ? Packing.CirclesInACircle.Table.First().Key : Packing.CirclesInACircle.Table.Last(p => p.Key <= count).Key);
            lastCount = n;

            if (count != n)
            {
                DisableChanged();
                NudCount.FromInt(n);
                EnableChanged();
            }

            var row = Packing.CirclesInACircle.Table[n];
            var centers = Packing.CirclesInACircle.GetCenters(n);

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
                    g.Circle(Pens.Red, cx, cy, r);
                }

                if (ChbFromCenter.Checked)
                {
                    g.Circle(Pens.Blue, cx, cy, r - r * row.Radius);
                }

                foreach (var center in centers)
                {
                    var cxIn = cx + center.X * r;
                    var cyIn = cy + center.Y * r;
                    if (ChbPixels.Checked)
                    {
                        db.SetPixel(Pens.Green, cxIn, cyIn);
                    }
                    else
                    {
                        g.Circle(Pens.Green, cxIn, cyIn, row.Radius * r);
                    }
                }
            }

            var g1 = PnlFill.CreateGraphics();
            //g1.Clear(Color.LightGray);

            g1.DrawImageUnscaled(db.Bitmap, PnlFill.Width / 2 - db.Width / 2, PnlFill.Height / 2 - db.Height / 2);
        }

        private void BtnGenerateCodes_Click(object sender, EventArgs e)
        {
            var d = new DirectoryInfo(@"C:\Quantum\Web\OpenGl\cci_coords");
            var files = d.GetFiles("*.txt");

            var values = new Dictionary<int, string>();
            foreach (var file in files)
            {
                string s = File.ReadAllText(file.FullName);
                var n = Convert.ToInt32(file.Name.Replace("cci", "").Replace(".txt", ""));
                var matches = Regex.Matches(s, @"([0-9]+)\s+(-?[0-9]+\.?[0-9]*)\s+(-?[0-9]+\.?[0-9]*)");

                values.Add(n, matches.Aggregate("", (current, next) => current + (current != "" ? "," : "") + next.Groups[2].Value + "," + next.Groups[3].Value));
            }

            var code = @"namespace Packing
{
    public static partial class CirclesInACircle
    {
        private static Dictionary<int, double[]>? centers;
        public static Dictionary<int, double[]> Centers
        {
            get
            {
                centers ??= new()
                {
" + values.OrderBy(p => p.Key).Aggregate("", (c, n) => c + (c != "" ? ",\r\n" : "") + "\t\t\t\t\t{ " + n.Key + ", new double[] { " + n.Value + " } }") + @"
                };
                return centers;
            }
        }
    }
}";

            File.WriteAllText("Centers.cs", code);
        }
    }
}
