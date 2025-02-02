namespace Photon
{
    public static partial class Conversion
    {
        public static void SegmentToLine(in Big x1, in Big y1, in Big x2, in Big y2, out Big a, out Big b, out Big c)
        {
            a = y2 - y1;
            b = x1 - x2;
            c = x2 * y1 - x1 * y2;
        }

        public static void ToLine(this Segment s, out Big a, out Big b, out Big c)
        {
            SegmentToLine(s.X1, s.Y1, s.X2, s.Y2, out a, out b, out c);
        }
    }
}
