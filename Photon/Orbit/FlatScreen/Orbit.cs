namespace Photon.FlatScreen
{
    public struct Orbit
    {
        public int N;
        public Circle C;
        public int W;
        public Orbit(int n, in Circle c, int w)
        {
            N = n;
            C = c;
            W = w;
        }
    }
}
