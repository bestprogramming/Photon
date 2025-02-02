namespace Photon
{
    public static partial class Intersection
    {
        public static void TwoLines(in Big a1, in Big b1, in Big c1, in Big a2, in Big b2, in Big c2, out Big x, out Big y)
        {
            var d = a1 * b2 - a2 * b1;

            if (d != Big.Zero)
            {
                x = (b1 * c2 - b2 * c1) / d;
                y = (a2 * c1 - a1 * c2) / d;
                return;
            }

            (x, y) = (Big.NaN, Big.NaN);
        }

        public static void TwoLines(in Big a1, in Big b1, in Big c1, in Big a2, in Big b2, in Big c2, out Point p)
        {
            p = Point.NaN;
            TwoLines(a1, b1, c1, a2, b2, c2, out p.X, out p.Y);
        }

        public static void Intersect(this Line l1, in Big a2, in Big b2, in Big c2, out Big x, out Big y)
        {
            TwoLines(l1.A, l1.B, l1.C, a2, b2, c2, out x, out y);
        }

        public static void Intersect(this Line l1, in Line l2, out Big x, out Big y)
        {
            TwoLines(l1.A, l1.B, l1.C, l2.A, l2.B, l2.C, out x, out y);
        }
    }
}
