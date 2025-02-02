﻿namespace Photon.OpenGl
{
    public class QuadrangularSetting : BaseSetting
    {
        public double X;
        public double Y;
        public double Z;
        public double Width;
        public double Height;
        public double Length;
        public string Count = "";

        public static QuadrangularSetting Get(UctQuadrangular uct)
        {
            var ret = new QuadrangularSetting
            {
                X = uct.NudX.ToDouble(),
                Y = uct.NudY.ToDouble(),
                Z = uct.NudZ.ToDouble(),
                Width = uct.NudWidth.ToDouble(),
                Height = uct.NudHeight.ToDouble(),
                Length = uct.NudLength.ToDouble(),
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
            var uct = (UctQuadrangular)uctShape;
            uct.NudX.FromDouble(X);
            uct.NudY.FromDouble(Y);
            uct.NudZ.FromDouble(Z);
            uct.NudWidth.FromDouble(Width);
            uct.NudHeight.FromDouble(Height);
            uct.NudLength.FromDouble(Length);
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
            return new Quadrangular(X, Y, Z, Width, Height, Length, Convert.ToInt32(Count), FrmWeight.ToVec4(Weight), 2);
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
