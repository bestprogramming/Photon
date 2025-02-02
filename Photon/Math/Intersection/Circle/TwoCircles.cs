namespace Photon
{
    public static partial class Intersection
    {
        public static void TwoCircles(in Big cx1, in Big cy1, in Big r1, in Big cx2, in Big cy2, in Big r2, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            var dx = cx2 - cx1;
            var dy = cy2 - cy1;
            var d = Big.Sqrt(dx * dx + dy * dy);

            if (d > 0)
            {
                var d2 = d * d;
                var (r12, r22) = (r1 * r1, r2 * r2);
                var diff = r12 - r22;
                var a = diff / (2 * d2);
                var l = 2 * (r12 + r22) / d2 - diff * diff / (d2 * d2) - Big.One;

                if (l >= 0)
                {
                    l = Big.Sqrt(l);

                    var fx = (cx1 + cx2) / 2 + a * dx;
                    var gx = l * dy / 2;

                    var fy = (cy1 + cy2) / 2 + a * dy;
                    var gy = -l * dx / 2;

                    x1 = fx + gx;
                    y1 = fy + gy;
                    x2 = fx - gx;
                    y2 = fy - gy;
                    return;
                }
            }

            (x1, y1, x2, y2) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
        }

        public static void TwoCircles(in Big cx1, in Big cy1, in Big r1, in Big cx2, in Big cy2, in Big r2, out Point p1, out Point p2)
        {
            p1 = Point.NaN;
            p2 = Point.NaN;
            TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out p1.X, out p1.Y, out p2.X, out p2.Y);
        }

        public static void Intersect(this Circle c1, in Big cx2, in Big cy2, in Big r2, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            TwoCircles(c1.X, c1.Y, c1.R, cx2, cy2, r2, out x1, out y1, out x2, out y2);
        }

        public static void Intersect(this Circle c1, in Circle c2, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            TwoCircles(c1.X, c1.Y, c1.R, c2.X, c2.Y, c2.R, out x1, out y1, out x2, out y2);
        }

        public static void Intersect(this Circle c1, in Circle c2, out Point p1, out Point p2)
        {
            p1 = Point.NaN;
            p2 = Point.NaN;
            TwoCircles(c1.X, c1.Y, c1.R, c2.X, c2.Y, c2.R, out p1.X, out p1.Y, out p2.X, out p2.Y);
        }
    }
}
