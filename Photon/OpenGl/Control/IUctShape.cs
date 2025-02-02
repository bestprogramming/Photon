namespace Photon.OpenGl
{
    public interface IUctShape
    {
        IUctShape Clone();
        int Show(bool rotate, bool cloneVibrate, bool orbitVibrate);
        BaseSetting GetSetting();
    }
}
