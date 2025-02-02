namespace Photon
{
    public static partial class Dimension
    {
        public static double LengthOfSegment(Pixel p1, Pixel p2)
        {
            return LengthOfSegment(p1.X, p1.Y, p2.X, p2.Y);
        }
    }
}
