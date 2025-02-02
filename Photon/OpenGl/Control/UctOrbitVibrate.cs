using System.Diagnostics;

namespace Photon.OpenGl
{
    public partial class UctOrbitVibrate : UserControl
    {
        public IUctShape Shape { get; }

        public UctOrbitVibrate(IUctShape shape)
        {
            InitializeComponent();
            Visible = false;
            Shape = shape;
            CmbVibrateBy.SelectedIndex = 0;
        }

        public override string ToString() => $" Orbit vibrate={NudRadius.ToDouble()} (({NudCount.ToDouble()},{CmbVibrateBy.Text}))";

        public UctOrbitVibrate Clone()
        {
            var ret = new UctOrbitVibrate(Shape);

            ret.NudRadius.Value = NudRadius.Value;
            ret.NudCount.Value = NudCount.Value;
            ret.CmbVibrateBy.SelectedIndex = CmbVibrateBy.SelectedIndex;

            return ret;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            var count = Shape?.Show(true, true, true);
            BtnShow.Text = $"Show (vertices: {count})";
        }

        public OrbitVibrateSetting GetSetting()
        {
            return OrbitVibrateSetting.Get(this);
        }
    }
}
