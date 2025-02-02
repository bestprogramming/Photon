namespace Photon.FlatScreenVector
{
    public struct Orbit
    {
        public int N;
        public Circle C;
        public Big X;
        public Big Y;
        public Big Z;
        public int W;
        public Orbit(int n, in Circle c, in Big x, in Big y, in Big z, int w)
        {
            N = n;
            C = c;
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
}
