using Photon.OpenGl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photon.OpenGl
{
    public partial class UctRotate : UserControl
    {
        public IUctShape Shape { get; }

        public UctRotate(IUctShape shape)
        {
            InitializeComponent();
            Visible = false;
            Shape = shape;
        }

        public override string ToString() => $" Rotate={NudAngle.ToDouble()} (({NudX1.ToDouble()},{NudY1.ToDouble()},{NudZ1.ToDouble()}), ({NudX2.ToDouble()},{NudY2.ToDouble()},{NudZ2.ToDouble()}))";

        public UctRotate Clone()
        {
            var ret = new UctRotate(Shape);

            ret.NudAngle.Value = NudAngle.Value;
            ret.NudX1.Value = NudX1.Value;
            ret.NudY1.Value = NudY1.Value;
            ret.NudZ1.Value = NudZ1.Value;
            ret.NudX2.Value = NudX2.Value;
            ret.NudY2.Value = NudY2.Value;
            ret.NudZ2.Value= NudZ2.Value;
            return ret;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            var count = Shape?.Show(true, false, false);
            BtnShow.Text = $"Show (vertices: {count})";
        }

        public RotateSetting GetSetting()
        {
            return RotateSetting.Get(this);
        }
    }
}
