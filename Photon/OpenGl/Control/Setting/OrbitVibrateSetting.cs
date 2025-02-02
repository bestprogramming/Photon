namespace Photon.OpenGl
{
    public class OrbitVibrateSetting
    {
        public double Radius;
        public int Count;
        public VibrateBy VibrateBy;

        public static OrbitVibrateSetting Get(UctOrbitVibrate uct)
        {
            return new OrbitVibrateSetting
            {
                Radius = uct.NudRadius.ToDouble(),
                Count = uct.NudCount.ToInt(),
                VibrateBy = (VibrateBy)uct.CmbVibrateBy.SelectedIndex,
            };
        }

        public void Set(UctOrbitVibrate? uct)
        {
            if (uct != null)
            {
                uct.NudRadius.FromDouble(Radius);
                uct.NudCount.FromInt(Count);
                uct.CmbVibrateBy.SelectedIndex = (byte)VibrateBy;
            }
        }
    }
}
