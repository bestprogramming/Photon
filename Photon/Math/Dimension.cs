using Vec2 = System.Numerics.Vector2;

namespace Photon
{
    public static partial class Dimension
    {
        public static Big LengthOfSegment(in Big x1, in Big y1, in Big x2, in Big y2)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            return Big.Sqrt(dx * dx + dy * dy);
        }

        public static Big LengthOfSegment(in Big x1, in Big y1, in Point p2)
        {
            return LengthOfSegment(x1, y1, p2.X, p2.Y);
        }

        public static Big LengthOfSegment(in Point p1, in Point p2)
        {
            return LengthOfSegment(p1.X, p1.Y, p2.X, p2.Y);
        }

        public static Big Length(this Segment s)
        {
            return LengthOfSegment(s.X1, s.Y1, s.X2, s.Y2);
        }

        public static Big LengthOfVector(in Big x, in Big y)
        {
            return Big.Sqrt(x * x + y * y);
        }

        public static Big DistanceOfLineAndPoint(in Big a, in Big b, in Big c, in Big x, in Big y)
        {
            return Big.Abs(a * x + b * y + c) / Big.Sqrt(a * a + b * b);
        }

        public static Big DistanceOfLineAndPoint(in Big a, in Big b, in Big c, in Point p)
        {
            return DistanceOfLineAndPoint(a, b, c, p.X, p.Y);
        }

        public static Big Distance(this Line l, in Big x, in Big y)
        {
            return DistanceOfLineAndPoint(l.A, l.B, l.C, x, y);
        }

        public static Big Distance(this Line l, in Point p)
        {
            return DistanceOfLineAndPoint(l.A, l.B, l.C, p.X, p.Y);
        }


        public static Big DistanceOfSegmentAndPoint(in Big x1, in Big y1, in Big x2, in Big y2, in Big x, in Big y)
        {
            return DistanceOfLineAndPoint(y2 - y1, x1 - x2, x2 * y1 - x1 * y2, x, y);
        }

        public static Big Distance(this Segment s, in Big x, in Big y)
        {
            return DistanceOfSegmentAndPoint(s.X1, s.Y1, s.X2, s.Y2, x, y);
        }

        public static Big Distance(this Segment s, in Point p)
        {
            return DistanceOfSegmentAndPoint(s.X1, s.Y1, s.X2, s.Y2, p.X, p.Y);
        }


        public static Big LawOfCosines(in Big a, in Big b, in Big ang)
        {
            return Big.Sqrt(a * a + b * b - 2 * a * b * Big.Cos(ang));
        }

        public static void Lerp(in Big x1, in Big y1, in Big x2, in Big y2, in Big amount, out Big x, out Big y)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            var l = Big.Sqrt(dx * dx + dy * dy);

            x = x1 + amount * dx / l;
            y = y1 + amount * dy / l;
        }

        public static void Lerp(in Big x1, in Big y1, in Big x2, in Big y2, in Big amount, out Vector v)
        {
            v = Vector.NaN;
            Lerp(x1, y1, x2, y2, amount, out v.X, out v.Y);
        }

        public static void Lerp(in Big x1, in Big y1, in Big x2, in Big y2, in Big amount, out Vec2 v)
        {
            Lerp(x1, y1, x2, y2, amount, out Big px, out Big py);
            v = new((float)px, (float)py);
        }

        public static void Lerp(in Big x1, in Big y1, in Vector v2, in Big amount, out Big x, out Big y)
        {
            Lerp(x1, y1, v2.X, v2.Y, amount, out x, out y);
        }

        public static void Lerp(in Big x1, in Big y1, in Vector v2, in Big amount, out Vec2 v)
        {
            Lerp(x1, y1, v2.X, v2.Y, amount, out Big px, out Big py);
            v = new((float)px, (float)py);
        }

        public static void Lerp(this Vector v1, in Big x2, in Big y2, in Big amount, out Big x, out Big y)
        {
            Lerp(v1.X, v1.Y, x2, y2, amount, out x, out y);
        }

        public static void Lerp(this Vector v1, in Vector v2, in Big amount, out Big x, out Big y)
        {
            Lerp(v1.X, v1.Y, v2.X, v2.Y, amount, out x, out y);
        }

        public static Vector Lerp(this Vector v1, in Vector v2, in Big amount)
        {
            Lerp(v1.X, v1.Y, v2.X, v2.Y, amount, out Big x, out Big y);
            return new(x, y);
        }
    }
}
