namespace Photon
{
    public static partial class Closest
    {
        public static void PointOfLineAndPoint(in Big x1, in Big y1, in Big x2, in Big y2, in Big x0, in Big y0, out Pixel p)
        {
            PointOfSegmentAndPoint(x1, y1, x2, y2, x0, y0, out Big x, out Big y);
            p = new Pixel((int)x, (int)y);
        }
    }
}
