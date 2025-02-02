namespace Photon
{
    public static partial class Intersection
    {
        public static void TwoSegments(in Big sx1, in Big sy1, in Big sx2, in Big sy2, in Big sx3, in Big sy3, in Big sx4, in Big sy4, out Big x, out Big y)
        {
            var dx1 = sx1 - sx2;
            var dy1 = sy1 - sy2;
            var dx2 = sx3 - sx4;
            var dy2 = sy3 - sy4;

            var d = dx1 * dy2 - dy1 * dx2;

            if (d != Big.Zero)
            {
                var d1 = sx1 * sy2 - sy1 * sx2;
                var d2 = sx3 * sy4 - sy3 * sx4;
                x = (d1 * dx2 - dx1 * d2) / d;
                y = (d1 * dy2 - dy1 * d2) / d;
                return;
            }

            (x, y) = (Big.NaN, Big.NaN);
        }

        public static void TwoSegments(in Big sx1, in Big sy1, in Big sx2, in Big sy2, in Big sx3, in Big sy3, in Big sx4, in Big sy4, out Point p)
        {
            p = Point.NaN;
            TwoSegments(sx1, sy1, sx2, sy2, sx3, sy3, sx4, sy4, out p.X, out p.Y);
        }

        public static void TwoSegments(in Point p1, in Point p2, in Point p3, in Point p4, out Big x, out Big y)
        {
            TwoSegments(p1.X, p1.Y, p2.X, p2.Y, p3.X, p3.Y, p4.X, p4.Y, out x, out y);
        }

        public static void Intersect(this Segment s1, in Segment s2, out Big x, out Big y)
        {
            TwoSegments(s1.X1, s1.Y1, s1.X2, s1.Y2, s2.X1, s2.Y1, s2.X2, s2.Y2, out x, out y);
        }
    }
}
