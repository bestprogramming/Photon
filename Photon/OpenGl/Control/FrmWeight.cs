using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public partial class FrmWeight : Form
    {
        public static readonly Color[] Colors = new Color[]
        {
            Color.FromArgb(255, 175, 17, 0),
            Color.FromArgb(255, 181, 36, 0),
            Color.FromArgb(255, 187, 56, 0),
            Color.FromArgb(255, 192, 77, 0),
            Color.FromArgb(255, 198, 99, 0),
            Color.FromArgb(255, 204, 122, 0),
            Color.FromArgb(255, 209, 146, 0),
            Color.FromArgb(255, 215, 172, 0),
            Color.FromArgb(255, 221, 198, 0),
            Color.FromArgb(255, 226, 226, 0),
            Color.FromArgb(255, 209, 232, 0),
            Color.FromArgb(255, 190, 238, 0),
            Color.FromArgb(255, 170, 243, 0),
            Color.FromArgb(255, 149, 249, 0),
            Color.FromArgb(255, 127, 255, 0),
            Color.FromArgb(255, 105, 255, 5),
            Color.FromArgb(255, 84, 255, 11),
            Color.FromArgb(255, 64, 254, 17),
            Color.FromArgb(255, 45, 255, 22),
            Color.FromArgb(255, 28, 255, 28),
            Color.FromArgb(255, 34, 254, 56),
            Color.FromArgb(255, 39, 255, 82),
            Color.FromArgb(255, 45, 255, 108),
            Color.FromArgb(255, 51, 255, 132),
            Color.FromArgb(255, 56, 255, 155),
            Color.FromArgb(255, 62, 254, 177),
            Color.FromArgb(255, 67, 255, 198),
            Color.FromArgb(255, 73, 255, 218),
            Color.FromArgb(255, 79, 255, 237),
            Color.FromArgb(255, 85, 255, 254),
            Color.FromArgb(255, 90, 238, 255),
            Color.FromArgb(255, 96, 223, 255),
            Color.FromArgb(255, 102, 209, 255),
            Color.FromArgb(255, 107, 196, 254),
            Color.FromArgb(255, 113, 184, 255),
            Color.FromArgb(255, 119, 173, 255),
            Color.FromArgb(255, 124, 163, 255),
            Color.FromArgb(255, 130, 155, 255),
            Color.FromArgb(255, 135, 147, 255),
            Color.FromArgb(255, 141, 141, 255),
            Color.FromArgb(255, 158, 147, 255),
            Color.FromArgb(255, 173, 153, 254),
            Color.FromArgb(255, 187, 158, 255),
            Color.FromArgb(255, 200, 164, 255),
            Color.FromArgb(255, 212, 170, 255),
            Color.FromArgb(255, 223, 175, 255),
            Color.FromArgb(255, 232, 181, 255),
            Color.FromArgb(255, 241, 187, 255),
            Color.FromArgb(255, 248, 192, 255),
            Color.FromArgb(255, 254, 198, 255),
            Color.FromArgb(255, 255, 203, 249),
            Color.FromArgb(255, 255, 209, 245),
            Color.FromArgb(255, 255, 215, 243),
            Color.FromArgb(255, 255, 221, 241),
            Color.FromArgb(255, 255, 226, 240),
            Color.FromArgb(255, 255, 232, 241),
            Color.FromArgb(255, 255, 238, 243),
            Color.FromArgb(255, 255, 243, 245),
            Color.FromArgb(255, 255, 249, 249),
            Color.FromArgb(255, 255, 255, 255),
        };

        public static readonly Vec4[] Vec4s = new Vec4[]
        {
            new(0.6862745f, 0.06666667f, 0f, 1.0f),
            new(0.70980394f, 0.14117648f, 0f, 1.0f),
            new(0.73333335f, 0.21960784f, 0f, 1.0f),
            new(0.7529412f, 0.3019608f, 0f, 1.0f),
            new(0.7764706f, 0.3882353f, 0f, 1.0f),
            new(0.8f, 0.47843137f, 0f, 1.0f),
            new(0.81960785f, 0.57254905f, 0f, 1.0f),
            new(0.84313726f, 0.6745098f, 0f, 1.0f),
            new(0.8666667f, 0.7764706f, 0f, 1.0f),
            new(0.8862745f, 0.8862745f, 0f, 1.0f),
            new(0.81960785f, 0.9098039f, 0f, 1.0f),
            new(0.74509805f, 0.93333334f, 0f, 1.0f),
            new(0.6666667f, 0.9529412f, 0f, 1.0f),
            new(0.58431375f, 0.9764706f, 0f, 1.0f),
            new(0.49803922f, 1f, 0f, 1.0f),
            new(0.4117647f, 1f, 0.019607844f, 1.0f),
            new(0.32941177f, 1f, 0.043137256f, 1.0f),
            new(0.2509804f, 0.99607843f, 0.06666667f, 1.0f),
            new(0.1764706f, 1f, 0.08627451f, 1.0f),
            new(0.10980392f, 1f, 0.10980392f, 1.0f),
            new(0.13333334f, 0.99607843f, 0.21960784f, 1.0f),
            new(0.15294118f, 1f, 0.32156864f, 1.0f),
            new(0.1764706f, 1f, 0.42352942f, 1.0f),
            new(0.2f, 1f, 0.5176471f, 1.0f),
            new(0.21960784f, 1f, 0.60784316f, 1.0f),
            new(0.24313726f, 0.99607843f, 0.69411767f, 1.0f),
            new(0.2627451f, 1f, 0.7764706f, 1.0f),
            new(0.28627452f, 1f, 0.85490197f, 1.0f),
            new(0.30980393f, 1f, 0.92941177f, 1.0f),
            new(0.33333334f, 1f, 0.99607843f, 1.0f),
            new(0.3529412f, 0.93333334f, 1f, 1.0f),
            new(0.3764706f, 0.8745098f, 1f, 1.0f),
            new(0.4f, 0.81960785f, 1f, 1.0f),
            new(0.41960785f, 0.76862746f, 0.99607843f, 1.0f),
            new(0.44313726f, 0.72156864f, 1f, 1.0f),
            new(0.46666667f, 0.6784314f, 1f, 1.0f),
            new(0.4862745f, 0.6392157f, 1f, 1.0f),
            new(0.50980395f, 0.60784316f, 1f, 1.0f),
            new(0.5294118f, 0.5764706f, 1f, 1.0f),
            new(0.5529412f, 0.5529412f, 1f, 1.0f),
            new(0.61960787f, 0.5764706f, 1f, 1.0f),
            new(0.6784314f, 0.6f, 0.99607843f, 1.0f),
            new(0.73333335f, 0.61960787f, 1f, 1.0f),
            new(0.78431374f, 0.6431373f, 1f, 1.0f),
            new(0.83137256f, 0.6666667f, 1f, 1.0f),
            new(0.8745098f, 0.6862745f, 1f, 1.0f),
            new(0.9098039f, 0.70980394f, 1f, 1.0f),
            new(0.94509804f, 0.73333335f, 1f, 1.0f),
            new(0.972549f, 0.7529412f, 1f, 1.0f),
            new(0.99607843f, 0.7764706f, 1f, 1.0f),
            new(1f, 0.79607844f, 0.9764706f, 1.0f),
            new(1f, 0.81960785f, 0.9607843f, 1.0f),
            new(1f, 0.84313726f, 0.9529412f, 1.0f),
            new(1f, 0.8666667f, 0.94509804f, 1.0f),
            new(1f, 0.8862745f, 0.9411765f, 1.0f),
            new(1f, 0.9098039f, 0.94509804f, 1.0f),
            new(1f, 0.93333334f, 0.9529412f, 1.0f),
            new(1f, 0.9529412f, 0.9607843f, 1.0f),
            new(1f, 0.9764706f, 0.9764706f, 1.0f),
            new(1f, 1f, 1f, 1.0f),
        };

        public static Color ToColor(object weight)
        {
            var w = Convert.ToInt32(weight);            
            var ret = Colors[Math.Abs(w) - 1];
            if (w < 0)
            {
                ret = Color.FromArgb(254, ret.R, ret.G, ret.B);
            }
            return ret;
        }

        public static Vec4 ToVec4(object weight)
        {
            var w = Convert.ToInt32(weight);
            var ret = Vec4s[Math.Abs(w) - 1];
            if (w < 0)
            {
                ret.W = 0.996f;
            }

            return ret;
        }

        public static int FromVec4(in Vec4 color)
        {
            if (color.W == 0.996f)
            {
                return -(Array.IndexOf(Vec4s, new(color.X, color.Y, color.Z, 1.0f)) + 1);
            }
            return Array.IndexOf(Vec4s, color) + 1;
        }

        public int Weight { get; private set; }

        public FrmWeight(int weight)
        {
            InitializeComponent();
            Weight = weight;

            //var s1 = "\t\tpublic static Rgb[] Rgbs = new Rgb[]\r\t\t{";
            //var s2 = "\t\tpublic static Vec4[] Vec4s = new Vec4[]\r\t\t{";
            //for (var w = 1; w <= 60; w++)
            //{
            //    var ratio = 1f / 3 + 4 * w / 360f;
            //    var hsl = new Hsl(6 * w % 361, 1, ratio);

            //    var rgb = Helper.HslToRgb(hsl);
            //    s1 += "\r\t\t\t" + $"new({rgb.R}, {rgb.G}, {rgb.B})" + ",";
            //    s2 += "\r\t\t\t" + $"new({rgb.R / 255f}f, {rgb.G / 255f}f, {rgb.B / 255f}f, 1.0f)" + ",";
            //}
            //s1 += "\r\t\t};";
            //s2 += "\r\t\t};";
            //Debug.WriteLine(s1);
            //Debug.WriteLine(s2);


            foreach (var pnl in Tlp.Controls.OfType<Panel>())
            {
                var w = Convert.ToInt32(pnl.Tag);
                pnl.BackColor = Colors[w - 1];
            }
        }

        private void Pnl_MouseEnter(object sender, EventArgs e)
        {
            var pnl = (Panel)sender;
            var g = pnl.CreateGraphics();
            DrawBorder(g, pnl.ClientRectangle);
        }

        private void Pnl_MouseLeave(object sender, EventArgs e)
        {
            var pnl = (Panel)sender;
            pnl.Refresh();
        }

        private void Pnl_Paint(object sender, PaintEventArgs e)
        {
            var pnl = (Panel)sender;
            var w = Convert.ToInt32(pnl.Tag);
            var absW = Math.Abs(Weight);
            if (w == absW)
            {
                DrawBorder(e.Graphics, pnl.ClientRectangle);
            }
        }

        private void Pnl_Click(object sender, EventArgs e)
        {
            var pnl = (Panel)sender;
            Weight = Convert.ToInt32(pnl.Tag);
            foreach (var p in Tlp.Controls.OfType<Panel>())
            {
                p.Refresh();
            }
        }

        private static void DrawBorder(Graphics g, System.Drawing.Rectangle bounds)
        {
            ControlPaint.DrawBorder(g, bounds, Color.Red, 3, ButtonBorderStyle.Outset, Color.Red,
                3, ButtonBorderStyle.Outset, Color.Red, 3, ButtonBorderStyle.Inset, Color.Red, 3, ButtonBorderStyle.Inset);
        }

        private void BtnNegative_Click(object sender, EventArgs e)
        {
            Weight = -Math.Abs(Weight);
        }

        private void BtnOkPositive_Click(object sender, EventArgs e)
        {
            Weight = Math.Abs(Weight);
        }
    }
}
