namespace Photon.Space
{
    public struct Orbit
    {
        public int N;
        public Sphere S;
        public int W;
        public Orbit(int n, in Sphere s, int w)
        {
            N = n;
            S = s;
            W = w;
        }
    }
}
