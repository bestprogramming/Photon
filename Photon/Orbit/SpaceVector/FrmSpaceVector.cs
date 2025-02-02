using Photon.FlatScreen;
using Photon.FlatScreenVector;
using Photon.OpenGl;
using Photon.Space;
using Photon.SphericalScreen;
using Photon.SphericalScreenVector;
using Photon.TestIntersection;
using Photon.TestOpenGl;
using Photon.TestPacking;
using System.Diagnostics;
using System.Xml;
using G = Photon.Geogebra;

namespace Photon.SpaceVector
{
    public partial class FrmSpaceVector : Form
    {
        public readonly string Header;

        public FrmSpaceVector()
        {
            InitializeComponent();
            Header = Text;
        }

        private void FrmSpaceVector_Load(object sender, EventArgs e)
        {
            SmiDrawMenu_Click(SmiPoint, EventArgs.Empty);
        }

        private void Smi_Click(object sender, EventArgs e)
        {
            if (sender == SmiSave)
            {
                FormSetting.Write(FormSetting.Get(this), $"{nameof(FrmSpaceVector)}.xml");
            }
            else if (sender == SmiLoad)
            {
                var setting = FormSetting.Read($"{nameof(FrmSpaceVector)}.xml");
                FormSetting.Set(this, setting);
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

        private void SmiDrawMenu_Click(object sender, EventArgs e)
        {
            var smi = (ToolStripMenuItem)sender;
            if (!smi.Checked)
            {
                foreach (ToolStripMenuItem smiItem in SmiDrawMenu.DropDownItems)
                {
                    smiItem.Checked = false;
                }

                var type = Type.GetType($"Photon.OpenGl.{smi.Tag}");

                if (type != null)
                {
                    FlpContent.SuspendLayout();
                    var ok = false;
                    foreach (UserControl uct in FlpContent.Controls)
                    {
                        uct.Visible = uct.GetType().FullName == type.FullName;
                        if (uct.Visible)
                        {
                            ok = true;
                        }
                    }

                    if (!ok)
                    {
                        var uct = (UserControl?)Activator.CreateInstance(type);
                        if (uct != null)
                        {
                            FlpContent.Controls.Add(uct);
                        }
                    }
                    FlpContent.ResumeLayout();

                    SmiDrawMenu.Tag = smi.Tag;
                }

                smi.Checked = true;
            }
        }

        private void BtnAddToList_Click(object sender, EventArgs e)
        {
            IUctShape? shape = null;
            foreach (UserControl uct in FlpContent.Controls)
            {
                if (uct.Visible)
                {
                    shape = (IUctShape)uct;
                    break;
                }
            }

            if (shape != null)
            {
                Lsb.Items.Add(shape.Clone());
            }

            RefreshButtons();
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            Lsb.Items.Clear();
            RefreshButtons();
        }

        private void Lsb_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            Lsb.Items.RemoveAt(Lsb.SelectedIndex);
        }

        private void BtnShowList_Click(object sender, EventArgs e)
        {
            var fs = FormSetting.Get(this);
            var ps = new PatternSetting
            {
                BaseSettings = fs.BaseSettings,
            };
            PatternSetting.Write(ps, "Pattern.ptpho");

            var scene = new Scene();
            scene.Open("Pattern.ptpho");
            var count = scene.Shapes.Where(p => p is not OpenGl.Solid.Sphere).SelectMany(p => p.Vertices).Count();
            BtnShowList.Text = $"Show list (vertices: {count})";

            Process.Start("Photon.exe", $"--path Pattern.ptpho --ucs");
        }

        public void RefreshButtons()
        {
            BtnRemoveSelected.Enabled = Lsb.SelectedIndex != -1;
            BtnClearList.Enabled = Lsb.Items.Count > 0;
            BtnShowList.Enabled = Lsb.Items.Count > 0;
        }

        private static void RenderFile(FormSetting setting, string dir, bool openRender = true)
        {
            var frm = new FrmRender(setting);
            if (frm.ShowDialog() == DialogResult.OK && frm.Render.Shapes.Count > 0)
            {
                var directory = $"Renders-SpaceVector/{dir}";
                Directory.CreateDirectory(directory);
                FormSetting.Write(setting, $"{directory}/{nameof(FrmSpaceVector)}.xml");
                PatternSetting.Write(frm.Pattern, $"{directory}/Pattern.ptpho");
                frm.Render.Save($"{directory}/Render.rnpho");

                if (openRender)
                {
                    Process.Start("Photon.exe", $"--path \"{directory}/Render.rnpho\" --ucs");
                }
            }
        }

        private void BtnRenderCurrentShape_Click(object sender, EventArgs e)
        {
            var fs = FormSetting.Get(this);
            fs.BaseSettings = fs.ContentSettings.Where(p => p.Selected).ToArray();
            var dir = Guid.NewGuid().ToString();
            RenderFile(fs, dir);
        }

        private void BtnRenderList_Click(object sender, EventArgs e)
        {
            var fs = FormSetting.Get(this);
            var dir = Guid.NewGuid().ToString();
            RenderFile(fs, dir);
        }

        private void BtnSaveList_Click(object sender, EventArgs e)
        {
            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                FormSetting.Write(FormSetting.Get(this), Sfd.FileName);
            }
        }

        private void BtnLoadList_Click(object sender, EventArgs e)
        {
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                var fs = FormSetting.Read(Ofd.FileName);
                FormSetting.Set(this, fs);
                Text = $"{Header} - {Ofd.SafeFileName}";
            }
        }

        private void BtnRenderFolder_Click(object sender, EventArgs e)
        {
            if (Fbd.ShowDialog() == DialogResult.OK)
            {
                var di = new DirectoryInfo(Fbd.SelectedPath);
                var files = di.GetFiles("*.xml");
                foreach (var file in files.OrderBy(p => p.CreationTime))
                {
                    Text = $"{Header} - {file.Name}";
                    var fs = FormSetting.Read(file.FullName);
                    var dir = Path.GetFileNameWithoutExtension(file.Name);
                    RenderFile(fs, dir, false);
                }
            }
        }

        private void BtnRenderFolderAndSubfolders_Click(object sender, EventArgs e)
        {
            if (Fbd.ShowDialog() == DialogResult.OK)
            {
                var di = new DirectoryInfo(Fbd.SelectedPath);
                var files = di.GetFiles("*.xml", SearchOption.AllDirectories);
                foreach (var file in files.OrderBy(p => p.CreationTime))
                {
                    Text = $"{Header} - {file.Name}";
                    var fs = FormSetting.Read(file.FullName);
                    var dir = file.FullName.Replace(di.FullName, "").Replace(Path.GetExtension(file.FullName), "");
                    RenderFile(fs, dir, false);
                }
            }
        }

        private void BtnToGeogebraCurrentShape_Click(object sender, EventArgs e)
        {
            var fs = FormSetting.Get(this);
            var frm = new FrmRender(fs);
            var strings = new List<string>();

            var n = 1;
            foreach (var p in frm.GetParticles())
            {
                var suffix = $"P{n++}";
                strings.Add(G.Point(p.X, p.Y, p.Z, suffix));
                strings.Add(G.SetColor(suffix, FrmWeight.ToColor(p.W)));
            }

            var geogebra = G.Execute(
                strings.Aggregate((c, n) => c + (c != "" ? "," : "") + n),
                "");
            Clipboard.SetText(geogebra);
        }
    }
}
