namespace Photon
{
    public static partial class Intersection
    {
        public static void CircleAndSegment(in Big r, in Big sx1, in Big sy1, in Big sx2, in Big sy2, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            var dx = sx2 - sx1;
            var dy = sy2 - sy1;
            var d1 = dx * dx + dy * dy;

            if (d1 != Big.Zero)
            {
                var d2 = sx1 * sy2 - sx2 * sy1;
                var d = d1 * r * r - d2 * d2;
                if (d >= 0)
                {
                    d = Big.Sqrt(d);

                    var sgn = dy < 0 ? Big.MinusOne : Big.One;
                    x1 = (d2 * dy - sgn * dx * d) / d1;
                    y1 = (-d2 * dx - Big.Abs(dy) * d) / d1;
                    x2 = (d2 * dy + sgn * dx * d) / d1;
                    y2 = (-d2 * dx + Big.Abs(dy) * d) / d1;
                    return;
                }
            }

            (x1, y1, x2, y2) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
        }

        public static void CircleAndSegment(in Big cx, in Big cy, in Big r, in Big sx1, in Big sy1, in Big sx2, in Big sy2, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            var nsx1 = sx1 - cx;
            var nsy1 = sy1 - cy;
            var nsx2 = sx2 - cx;
            var nsy2 = sy2 - cy;

            var dx = nsx2 - nsx1;
            var dy = nsy2 - nsy1;
            var d1 = dx * dx + dy * dy;

            if (d1 != Big.Zero)
            {
                var d2 = nsx1 * nsy2 - nsx2 * nsy1;
                var d = d1 * r * r - d2 * d2;
                if (d >= 0)
                {
                    d = Big.Sqrt(d);

                    var sgn = dy < 0 ? Big.MinusOne : Big.One;
                    x1 = cx + (d2 * dy - sgn * dx * d) / d1;
                    y1 = cy + (-d2 * dx - Big.Abs(dy) * d) / d1;
                    x2 = cx + (d2 * dy + sgn * dx * d) / d1;
                    y2 = cy + (-d2 * dx + Big.Abs(dy) * d) / d1;
                    return;
                }
            }

            (x1, y1, x2, y2) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
        }

        public static void CircleAndSegment(in Big cx, in Big cy, in Big r, in Big sx1, in Big sy1, in Big sx2, in Big sy2, out Point p1, out Point p2)
        {
            p1 = Point.NaN;
            p2 = Point.NaN;
            CircleAndSegment(cx, cy, r, sx1, sy1, sx2, sy2, out p1.X, out p1.Y, out p2.X, out p2.Y);
        }

        public static void IntersectWithSegment(this Circle circle, in Big sx1, in Big sy1, in Big sx2, in Big sy2, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            CircleAndSegment(circle.X, circle.Y, circle.R, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
        }

        public static void Intersect(this Circle c, in Segment s, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            CircleAndSegment(c.X, c.Y, c.R, s.X1, s.Y1, s.X2, s.Y2, out x1, out y1, out x2, out y2);
        }


        public static bool IsCircleAndHorizontalSegmentIntersect(in Big cx, in Big cy, in Big r, in Big x, in Big y, in Big length)
        {
            var d = x - cx;
            d = r * r - d * d;
            if (d >= 0)
            {
                d = Big.Sqrt(d);
                return cy - d >= y && cy - d <= y + length ||
                    cy + d >= y && cy + d <= y + length;
            }

            return false;
        }

        public static bool IsCircleAndVerticalSegmentIntersect(in Big cx, in Big cy, in Big r, in Big x, in Big y, in Big length)
        {
            var d = y - cy;
            d = r * r - d * d;
            if (d >= 0)
            {
                d = Big.Sqrt(d);
                return cx - d >= x && cx - d <= x + length ||
                    cx + d >= x && cx + d <= x + length;
            }

            return false;
        }
    }
}
