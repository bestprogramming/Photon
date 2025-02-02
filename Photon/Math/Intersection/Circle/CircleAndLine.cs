namespace Photon
{
    public static partial class Intersection
    {
        public static void CircleAndLine(in Big r, in Big a, in Big b, in Big c, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            var d1 = a * a + b * b;
            if (d1 != Big.Zero)
            {
                var d = d1 * r * r - c * c;
                if (d >= 0)
                {
                    d = Big.Sqrt(d);

                    var x0 = Big.MinusOne * a * c;
                    var y0 = Big.MinusOne * b * c;

                    x1 = (x0 + b * d) / d1;
                    y1 = (y0 - a * d) / d1;
                    x2 = (x0 - b * d) / d1;
                    y2 = (y0 + a * d) / d1;
                    return;
                }
            }

            (x1, y1, x2, y2) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
        }

        public static void CircleAndLine(in Big cx, in Big cy, in Big r, in Big a, in Big b, in Big c, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            var nc = c + a * cx + b * cy;
            var d1 = a * a + b * b;
            if (d1 != Big.Zero)
            {
                var d = d1 * r * r - nc * nc;
                if (d >= 0)
                {
                    d = Big.Sqrt(d);

                    var x0 = -a * nc;
                    var y0 = -b * nc;

                    x1 = cx + (x0 + b * d) / d1;
                    y1 = cy + (y0 - a * d) / d1;
                    x2 = cx + (x0 - b * d) / d1;
                    y2 = cy + (y0 + a * d) / d1;
                    return;
                }
            }

            (x1, y1, x2, y2) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
        }

        public static void CircleAndLine(in Big cx, in Big cy, in Big r, in Big a, in Big b, in Big c, out Point p1, out Point p2)
        {
            p1 = Point.NaN;
            p2 = Point.NaN;
            CircleAndLine(cx, cy, r, a, b, c, out p1.X, out p1.Y, out p2.X, out p2.Y);
        }

        public static void IntersectWithLine(this Circle circle, in Big a, in Big b, in Big c, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            CircleAndLine(circle.X, circle.Y, circle.R, a, b, c, out x1, out y1, out x2, out y2);
        }

        public static void Intersect(this Circle c, in Line l, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            CircleAndLine(c.X, c.Y, c.R, l.A, l.B, l.C, out x1, out y1, out x2, out y2);
        }
    }
}
