using System.Numerics;

namespace Photon
{
    public static partial class Intersection
    {
        public static void EllipseAndSegment(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, in Big sx1, in Big sy1, in Big sx2, in Big sy2, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            Conversion.SegmentToLine(sx1, sy1, sx2, sy2, out Big a, out Big b, out Big c);
            EllipseAndLine(ea, eb, rotate, a, b, c + a * ex + b * ey, out x1, out y1, out x2, out y2);
            x1 += ex;
            y1 += ey;
            x2 += ex;
            y2 += ey;
        }

        public static void EllipseAndSegment(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, in Big sx1, in Big sy1, in Big sx2, in Big sy2, out Point p1, out Point p2)
        {
            p1 = Point.NaN;
            p2 = Point.NaN;
            EllipseAndSegment(ex, ey, ea, eb, rotate, sx1, sy1, sx2, sy2, out p1.X, out p1.Y, out p2.X, out p2.Y);
        }

        public static void Intersect(this Ellipse e, in Segment s, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            EllipseAndSegment(e.X, e.Y, e.A, e.B, e.Rotate, s.X1, s.Y1, s.X2, s.Y2, out x1, out y1, out x2, out y2);
        }
    }
}
