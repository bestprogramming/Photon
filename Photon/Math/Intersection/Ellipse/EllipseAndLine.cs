namespace Photon
{
    public static partial class Intersection
    {
        private static void EllipseAndLineBGtA(in Big ea, in Big eb, in Big a, in Big b, in Big c, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            var ea2 = ea * ea;
            var eb2 = eb * eb;
            var b2 = b * b;

            Algebra.Quadratic(eb2 * b2 + ea2 * a * a, 2 * ea2 * a * c, ea2 * c * c - ea2 * eb2 * b2, out x1, out x2);

            y1 = (-c - a * x1) / b;
            y2 = (-c - a * x2) / b;
        }

        private static void EllipseAndLine(in Big ea, in Big eb, in Big rotate, in Big a, in Big b, in Big c, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            Big.SinCos(rotate, out Big sin, out Big cos);

            var a1 = a * cos + b * sin;
            var b1 = a * sin - b * cos;
            if (Big.Abs(a1) > Big.Abs(b1)) EllipseAndLineBGtA(eb, ea, b1, a1, c, out y1, out x1, out y2, out x2);
            else EllipseAndLineBGtA(ea, eb, a1, b1, c, out x1, out y1, out x2, out y2);

            (x1, y1) = (cos * x1 + sin * y1, sin * x1 - cos * y1);
            (x2, y2) = (cos * x2 + sin * y2, sin * x2 - cos * y2);
        }

        public static void EllipseAndLine(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, in Big a, in Big b, in Big c, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            EllipseAndLine(ea, eb, rotate, a, b, c + a * ex + b * ey, out x1, out y1, out x2, out y2);
            x1 += ex;
            y1 += ey;
            x2 += ex;
            y2 += ey;
        }

        public static void EllipseAndLine(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, in Big a, in Big b, in Big c, out Point p1, out Point p2)
        {
            p1 = Point.NaN;
            p2 = Point.NaN;
            EllipseAndLine(ex, ey, ea, eb, rotate, a, b, c, out p1.X, out p1.Y, out p2.X, out p2.Y);
        }
    }
}
