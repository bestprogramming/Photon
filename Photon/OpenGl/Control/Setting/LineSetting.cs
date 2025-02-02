namespace Photon.OpenGl
{
    public class LineSetting : BaseSetting
    {
        public double X1;
        public double Y1;
        public double Z1;
        public double X2;
        public double Y2;
        public double Z2;
        public int Count;
        public bool End;

        public static LineSetting Get(UctLine uct)
        {
            var ret = new LineSetting
            {
                X1 = uct.NudX1.ToDouble(),
                Y1 = uct.NudY1.ToDouble(),
                Z1 = uct.NudZ1.ToDouble(),
                X2 = uct.NudX2.ToDouble(),
                Y2 = uct.NudY2.ToDouble(),
                Z2 = uct.NudZ2.ToDouble(),
                Count = uct.NudCount.ToInt(),
                End = uct.ChbEnd.Checked,
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
            var uct = (UctLine)uctShape;
            uct.NudX1.FromDouble(X1);
            uct.NudY1.FromDouble(Y1);
            uct.NudZ1.FromDouble(Z1);
            uct.NudX2.FromDouble(X2);
            uct.NudY2.FromDouble(Y2);
            uct.NudZ2.FromDouble(Z2);
            uct.NudCount.FromInt(Count);
            uct.ChbEnd.Checked = End;
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
            return new Line(X1, Y1, Z1, X2, Y2, Z2, Count, End, FrmWeight.ToVec4(Weight), 2);
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
