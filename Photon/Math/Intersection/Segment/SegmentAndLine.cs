namespace Photon
{
    public static partial class Intersection
    {
        public static void SegmentAndLine(in Big x1, in Big y1, in Big x2, in Big y2, in Big a, in Big b, in Big c, out Big x, out Big y)
        {
            var a2 = y2 - y1;
            var b2 = x1 - x2;
            var c2 = x2 * y1 - x1 * y2;
            var d = a * b2 - a2 * b;

            if (d != Big.Zero)
            {
                x = (b * c2 - b2 * c) / d;
                y = (a2 * c - a * c2) / d;
                return;
            }

            (x, y) = (Big.NaN, Big.NaN);

        }

        public static void SegmentAndLine(in Big x1, in Big y1, in Big x2, in Big y2, in Big a, in Big b, in Big c, out Point p)
        {
            p = Point.NaN;
            SegmentAndLine(x1, y1, x2, y2, a, b, c, out p.X, out p.Y);
        }

        public static void IntersectWithLine(this Segment s, in Big a, in Big b, in Big c, out Big x, out Big y)
        {
            SegmentAndLine(s.X1, s.X2, s.Y1, s.Y2, a, b, c, out x, out y);
        }

        public static void Intersect(this Segment s, in Line l, out Big x, out Big y)
        {
            SegmentAndLine(s.X1, s.X2, s.Y1, s.Y2, l.A, l.B, l.C, out x, out y);
        }
    }
}
