namespace Photon.OpenGl
{
    public class RotateSetting
    {
        public double Angle;
        public double X1;
        public double Y1;
        public double Z1;
        public double X2;
        public double Y2;
        public double Z2;

        public static RotateSetting Get(UctRotate uct)
        {
            return new RotateSetting
            {
                Angle = uct.NudAngle.ToDouble(),
                X1 = uct.NudX1.ToDouble(),
                Y1 = uct.NudY1.ToDouble(),
                Z1 = uct.NudZ1.ToDouble(),
                X2 = uct.NudX2.ToDouble(),
                Y2 = uct.NudY2.ToDouble(),
                Z2 = uct.NudZ2.ToDouble(),
            };
        }

        public void Set(UctRotate? uct)
        {
            if (uct != null)
            {
                uct.NudAngle.FromDouble(Angle);
                uct.NudX1.FromDouble(X1);
                uct.NudY1.FromDouble(Y1);
                uct.NudZ1.FromDouble(Z1);
                uct.NudX2.FromDouble(X2);
                uct.NudY2.FromDouble(Y2);
                uct.NudZ2.FromDouble(Z2);
            }
        }
    }
}
