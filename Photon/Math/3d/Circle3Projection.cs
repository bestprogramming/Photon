namespace Photon
{
    public partial struct Circle3Projection
    {
        public Ellipse Xy;
        public Ellipse Yz;
        public Ellipse Zx;

        public Circle3Projection(in Ellipse xy, in Ellipse yz, in Ellipse zx)
        {
            Xy = xy;
            Yz = yz;
            Zx = zx;
        }
    }
}
