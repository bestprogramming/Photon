namespace Photon.SphericalScreen
{
    public struct Orbit
    {
        public int N;
        public Circle3Projection Cp;
        public int W;
        public Orbit(int n, in Circle3Projection cp, int w)
        {
            N = n;
            Cp = cp;
            W = w;
        }
    }
}
