namespace Photon.OpenGl
{
    public class CloneVibrateSetting
    {
        public double Radius;
        public int Count;
        public VibrateBy VibrateBy;

        public static CloneVibrateSetting Get(UctCloneVibrate uct)
        {
            return new CloneVibrateSetting
            {
                Radius = uct.NudRadius.ToDouble(),
                Count = uct.NudCount.ToInt(),
                VibrateBy = (VibrateBy)uct.CmbVibrateBy.SelectedIndex,
            };
        }

        public void Set(UctCloneVibrate? uct)
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
