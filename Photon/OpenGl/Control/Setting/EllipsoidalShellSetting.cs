namespace Photon.OpenGl
{
    public class EllipsoidalShellSetting : BaseSetting
    {
        public double X;
        public double Y;
        public double Z;
        public double A;
        public double B;
        public double C;
        public string Count = "";

        public static EllipsoidalShellSetting Get(UctEllipsoidalShell uct)
        {
            var ret = new EllipsoidalShellSetting
            {
                X = uct.NudX.ToDouble(),
                Y = uct.NudY.ToDouble(),
                Z = uct.NudZ.ToDouble(),
                A = uct.NudA.ToDouble(),
                B = uct.NudB.ToDouble(),
                C = uct.NudC.ToDouble(),
                Count = uct.CmbCount.Text,
                Weight = (int)uct.PnlWeight.Tag,
                Rotate = uct.ChbRotate.Checked,
                CloneVibrate = uct.ChbCloneVibrate.Checked,
                OrbitVibrate = uct.ChbOrbitVibrate.Checked,
                RotateSetting = uct.Urt?.GetSetting(),
                CloneVibrateSetting = uct.Ucv?.GetSetting(),
                OrbitVibrateSetting = uct.Uov?.GetSetting(),
                Selected = uct.Visible,
            };

            return ret;
        }

        public override void Set(IUctShape uctShape)
        {
            var uct = (UctEllipsoidalShell)uctShape;
            uct.NudX.FromDouble(X);
            uct.NudY.FromDouble(Y);
            uct.NudZ.FromDouble(Z);
            uct.NudA.FromDouble(A);
            uct.NudB.FromDouble(B);
            uct.NudC.FromDouble(C);
            uct.CmbCount.Text = Count;
            uct.SetWeight(Weight);
            uct.Urt = RotateSetting != null ? new(uct) : null;
            uct.ChbRotate.Checked = Rotate;
            uct.Ucv = CloneVibrateSetting != null ? new(uct) : null;
            uct.ChbCloneVibrate.Checked = CloneVibrate;
            uct.Uov = OrbitVibrateSetting != null ? new(uct) : null;
            uct.ChbOrbitVibrate.Checked = OrbitVibrate;
            RotateSetting?.Set(uct.Urt);
            CloneVibrateSetting?.Set(uct.Ucv);
            OrbitVibrateSetting?.Set(uct.Uov);
            uct.Visible = Selected;
        }

        public override Shape GetShape()
        {
            return new EllipsoidalShell(X, Y, Z, A, B, C, Convert.ToInt32(Count), FrmWeight.ToVec4(Weight), 2);
        }

        public override void AddTo(Scene scene)
        {
            var shape = GetShape();
            scene.Shapes.Add(shape);
            AddTo(scene, shape);

            base.AddTo(scene);
        }
    }
}
