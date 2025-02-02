﻿namespace Photon.OpenGl
{
    public class CircleSetting : BaseSetting
    {
        public double X;
        public double Y;
        public double Z;
        public double R;
        public int Count;
        public double From = 0;
        public double To = Const.Pi2;
        public bool End;

        public static CircleSetting Get(UctCircle uct)
        {
            var ret = new CircleSetting
            {
                X = uct.NudX.ToDouble(),
                Y = uct.NudY.ToDouble(),
                Z = uct.NudZ.ToDouble(),
                R = uct.NudR.ToDouble(),
                Count = uct.NudCount.ToInt(),
                From = uct.NudFrom.ToDouble(),
                To = uct.NudTo.ToDouble(),
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
            var uct = (UctCircle)uctShape;
            uct.NudX.FromDouble(X);
            uct.NudY.FromDouble(Y);
            uct.NudZ.FromDouble(Z);
            uct.NudR.FromDouble(R);
            uct.NudCount.FromInt(Count);
            uct.NudFrom.FromDouble(From);
            uct.NudTo.FromDouble(To);
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
            return new Circle(X, Y, Z, R, Count, From, To, End, FrmWeight.ToVec4(Weight), 2);
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
