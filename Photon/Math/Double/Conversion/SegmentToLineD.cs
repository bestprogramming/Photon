namespace Photon
{
    public static partial class Conversion
    {
        public static void SegmentToLineD(double x1, double y1, double x2, double y2, out double a, out double b, out double c)
        {
            a = y2 - y1;
            b = x1 - x2;
            c = x2 * y1 - x1 * y2;
        }

        public static void ToLineD(this SegmentD s, out double a, out double b, out double c)
        {
            SegmentToLineD(s.X1, s.Y1, s.X2, s.Y2, out a, out b, out c);
        }
    }
}
