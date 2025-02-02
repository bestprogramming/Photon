using System.Diagnostics;

namespace Photon.OpenGl
{
    public partial class UctCloneVibrate : UserControl
    {
        public IUctShape Shape { get; }

        public UctCloneVibrate(IUctShape shape)
        {
            InitializeComponent();
            Visible = false;
            Shape = shape;
            CmbVibrateBy.SelectedIndex = 0;
        }

        public int Count { get; set; }

        public override string ToString() => $" Clone vibrate={NudRadius.ToDouble()} (({NudCount.ToDouble()},{CmbVibrateBy.Text}))";

        public UctCloneVibrate Clone()
        {
            var ret = new UctCloneVibrate(Shape)
            {
                Count = Count
            };
            ret.NudRadius.Value = NudRadius.Value;
            ret.NudCount.Value = NudCount.Value;
            ret.CmbVibrateBy.SelectedIndex = CmbVibrateBy.SelectedIndex;

            return ret;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            var count = Shape?.Show(true, true, false);
            BtnShow.Text = $"Show (vertices: {count})";
        }

        public CloneVibrateSetting GetSetting()
        {
            return CloneVibrateSetting.Get(this);
        }
    }
}
