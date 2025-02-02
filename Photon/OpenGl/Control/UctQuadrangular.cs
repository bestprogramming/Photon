using System.Diagnostics;

namespace Photon.OpenGl
{
    public partial class UctQuadrangular : UserControl, IUctShape
    {
        public UctQuadrangular()
        {
            InitializeComponent();
            SetWeight(16);

            LblCount.MouseEnter += Tooltip_SpheresInACube_MouseEnter;
            LblCount.MouseLeave += Tooltip_MouseLeave;

            foreach (var count in Packing.SpheresInACube.Table.Keys)
            {
                CmbCount.Items.Add(count);
            }
            CmbCount.SelectedIndex = CmbCount.Items.IndexOf(29660);
        }

        public void SetFlpChildIndices()
        {
            var n = 1;
            if (Urt != null)
            {
                Flp.Controls.SetChildIndex(Urt, n++);
            }
            if (Ucv != null)
            {
                Flp.Controls.SetChildIndex(Ucv, n++);
            }
            if (Uov != null)
            {
                Flp.Controls.SetChildIndex(Uov, n);
            }
        }

        public UctRotate? Urt
        {
            get
            {
                return  Flp.Controls.OfType<UctRotate>().FirstOrDefault();
            }
            set
            {
                Flp.SuspendLayout();
                var c = Flp.Controls.OfType<UctRotate>().FirstOrDefault();
                if (c != null)
                {
                    Flp.Controls.Remove(c);
                }

                if (value != null)
                {
                    Flp.Controls.Add(value);
                    SetFlpChildIndices();
                }
                Flp.ResumeLayout();
            }
        }

        public UctCloneVibrate? Ucv
        {
            get
            {
                return Flp.Controls.OfType<UctCloneVibrate>().FirstOrDefault();
            }
            set
            {
                Flp.SuspendLayout();
                var c = Flp.Controls.OfType<UctCloneVibrate>().FirstOrDefault();
                if (c != null)
                {
                    Flp.Controls.Remove(c);
                }

                if (value != null)
                {
                    Flp.Controls.Add(value);
                    SetFlpChildIndices();
                }
                Flp.ResumeLayout();
            }
        }

        public UctOrbitVibrate? Uov
        {
            get
            {
                return Flp.Controls.OfType<UctOrbitVibrate>().FirstOrDefault();
            }
            set
            {
                Flp.SuspendLayout();
                var c = Flp.Controls.OfType<UctOrbitVibrate>().FirstOrDefault();
                if (c != null)
                {
                    Flp.Controls.Remove(c);
                }

                if (value != null)
                {
                    Flp.Controls.Add(value);
                    SetFlpChildIndices();
                }
                Flp.ResumeLayout();
            }
        }

        public override string ToString() => $"Quadrangular vertices:{Write(true, true, true)} weight={PnlWeight.Tag}, x={NudX.ToDouble()}, y={NudY.ToDouble()}, z={NudZ.ToDouble()}{(ChbRotate.Checked ? Urt : "")}, width={NudWidth.ToDouble()}, height={NudHeight.ToDouble()}, length={NudLength.ToDouble()}, count={CmbCount.Text}{(ChbCloneVibrate.Checked ? Ucv : "")}{(ChbOrbitVibrate.Checked ? Uov : "")}";

        public void SetWeight(int value)
        {
            PnlWeight.Tag = value;
            PnlWeight.BackColor = FrmWeight.ToColor(PnlWeight.Tag);
            LblWeight.Text = PnlWeight.Tag.ToString();
        }

        private void Tooltip_SpheresInACube_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is IWin32Window window)
            {
                Tlt.Show("from packing 'spheres in a cube'", window);
            }
        }

        private void Tooltip_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is IWin32Window window)
            {
                Tlt.Hide(window);
            }
        }

        private void PnlWeight_Click(object sender, EventArgs e)
        {
            var pnl = (Panel)sender;
            var frm = new FrmWeight(Convert.ToInt32(pnl.Tag));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetWeight(frm.Weight);
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            var count = Show(false, false, false);
            BtnShow.Text = $"Show (vertices: {count})";
        }

        private void ChbRotate_CheckedChanged(object sender, EventArgs e)
        {
            if (Urt != null)
            {
                Urt.Visible = ChbRotate.Checked;
            }
            else if (ChbRotate.Checked)
            {
                Urt = new UctRotate(this)
                {
                    Visible = true,
                };
            }
        }

        private void ChbCloneVibrate_CheckedChanged(object sender, EventArgs e)
        {
            if (Ucv != null)
            {
                Ucv.Visible = ChbCloneVibrate.Checked;
            }
            else if (ChbCloneVibrate.Checked)
            {
                Ucv = new UctCloneVibrate(this)
                {
                    Visible = true,
                };
            }
        }

        private void ChbOrbitVibrate_CheckedChanged(object sender, EventArgs e)
        {
            if (Uov != null)
            {
                Uov.Visible = ChbOrbitVibrate.Checked;
            }
            else if (ChbOrbitVibrate.Checked)
            {
                Uov = new UctOrbitVibrate(this)
                {
                    Visible = true,
                };
            }
        }

        private int Write(bool rotate, bool cloneVibrate, bool orbitVibrate)
        {
            var setting = GetSetting();

            if (!rotate)
            {
                setting.Rotate = false;
                setting.RotateSetting = null;
            }

            if (!cloneVibrate)
            {
                setting.CloneVibrate = false;
                setting.CloneVibrateSetting = null;
            }

            if (!orbitVibrate)
            {
                setting.OrbitVibrate = false;
                setting.OrbitVibrateSetting = null;
            }

            var ps = new PatternSetting
            {
                BaseSettings = new[] { setting },
            };

            PatternSetting.Write(ps, "Pattern.ptpho");

            var scene = new Scene();
            scene.Open("Pattern.ptpho");
            return scene.Shapes.Where(p => p is not Solid.Sphere).SelectMany(p => p.Vertices).Count();
        }

        #region IUctShape
        public IUctShape Clone()
        {
            var ret = new UctQuadrangular();

            ret.NudX.Value = NudX.Value;
            ret.NudY.Value = NudY.Value;
            ret.NudZ.Value = NudZ.Value;
            ret.NudWidth.Value = NudWidth.Value;
            ret.NudHeight.Value = NudHeight.Value;
            ret.NudLength.Value = NudLength.Value;
            ret.CmbCount.Text = CmbCount.Text;
            ret.PnlWeight.Tag = PnlWeight.Tag;
            ret.PnlWeight.BackColor = PnlWeight.BackColor;
            ret.ChbRotate.Checked = ChbRotate.Checked;
            ret.ChbCloneVibrate.Checked = ChbCloneVibrate.Checked;
            ret.ChbOrbitVibrate.Checked = ChbOrbitVibrate.Checked;
            ret.Urt = Urt?.Clone();
            ret.Ucv = Ucv?.Clone();
            ret.Uov = Uov?.Clone();
            return ret;
        }

        public int Show(bool rotate, bool cloneVibrate, bool orbitVibrate)
        {
            var ret = Write(rotate, cloneVibrate, orbitVibrate);
            
            Process.Start("Photon.exe", $"--path Pattern.ptpho --ucs");

            return ret;
        }

        public BaseSetting GetSetting()
        {
            return QuadrangularSetting.Get(this);
        }
        #endregion
    }
}
