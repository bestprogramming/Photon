namespace Photon.SphericalScreenVector
{
    public struct Orbit
    {
        public int N;
        public Circle3Projection Cp;
        public Big X;
        public Big Y;
        public Big Z;
        public int W;
        public Orbit(int n, in Circle3Projection cp, in Big x, in Big y, in Big z, int w)
        {
            N = n;
            Cp = cp;
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
}
