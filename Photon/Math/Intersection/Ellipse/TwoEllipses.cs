using static System.Windows.Forms.AxHost;
using G = Photon.Geogebra;

namespace Photon
{
    public static partial class Intersection
    {
        public static void TwoEllipses(in Big ea1, in Big eb1, in Big ex2, in Big ey2, in Big ea2, in Big eb2, in Big rotate2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            var c = Big.Cos(rotate2);
            var s = Big.Sin(rotate2);

            var c2 = c * c;
            var s2 = s * s;

            var ex22 = ex2 * ex2;
            var ey22 = ey2 * ey2;
            var a2 = ea2 * ea2;
            var b2 = eb2 * eb2;

            var aa2 = ea1 * ea1;
            var bb2 = eb1 * eb1;

            Algebra.Conic_abcdef_acf(
                a2 * s2 + b2 * c2,
                2 * b2 * c * s - 2 * a2 * c * s,
                a2 * c2 + b2 * s2,
                -2 * a2 * s2 * ex2 - 2 * b2 * c2 * ex2 + 2 * a2 * c * ey2 * s - 2 * b2 * c * ey2 * s,
                -2 * a2 * c2 * ey2 - 2 * b2 * s2 * ey2 + 2 * a2 * c * ex2 * s - 2 * b2 * c * ex2 * s,
                a2 * c2 * ey22 + a2 * ex22 * s2 + b2 * c2 * ex22 + b2 * ey22 * s2 + 2 * b2 * c * ex2 * ey2 * s - 2 * a2 * c * ex2 * ey2 * s - a2 * b2,

                bb2, aa2, -aa2 * bb2,
                out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
        }

        public static void TwoEllipses(in Big ea1, in Big eb1, in Big rotate1, in Big ex2, in Big ey2, in Big ea2, in Big eb2, in Big rotate2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            Big.SinCos(rotate1, out Big sin, out Big cos);
            var ex3 = cos * ex2 + sin * ey2;
            var ey3 = -sin * ex2 + cos * ey2;
            TwoEllipses(ea1, eb1, ex3, ey3, ea2, eb2, rotate2 - rotate1, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            (x1, y1) = (cos * x1 - sin * y1, sin * x1 + cos * y1);
            (x2, y2) = (cos * x2 - sin * y2, sin * x2 + cos * y2);
            (x3, y3) = (cos * x3 - sin * y3, sin * x3 + cos * y3);
            (x4, y4) = (cos * x4 - sin * y4, sin * x4 + cos * y4);
        }

        public static void TwoEllipses(in Big ex1, in Big ey1, in Big ea1, in Big eb1, in Big rotate1, in Big ex2, in Big ey2, in Big ea2, in Big eb2, in Big rotate2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            var geogebra = G.Execute(G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"), G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"), G.Intersect("E1", "E2", "i"));

            if (Conversion.EllipseToSegment(ex1, ey1, ea1, eb1, rotate1, out Big sx1, out Big sy1, out Big sx2, out Big sy2))
            {
                EllipseAndSegment(ex2, ey2, ea2, eb2, rotate2, sx1, sy1, sx2, sy2, out x1, out y1, out x3, out y3);
                (x2, y2, x4, y4) = (x1, y1, x3, y3);
                if (!Big.In(x1, sx1, sx2) || !Big.In(y1, sy1, sy2))
                {
                    (x1, y1, x2, y2) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
                }
                if (!Big.In(x3, sx1, sx2) || !Big.In(y3, sy1, sy2))
                {
                    (x3, y3, x4, y4) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
                }
                return;
            }

            if (Conversion.EllipseToSegment(ex2, ey2, ea2, eb2, rotate2, out sx1, out sy1, out sx2, out sy2))
            {
                EllipseAndSegment(ex1, ey1, ea1, eb1, rotate1, sx1, sy1, sx2, sy2, out x1, out y1, out x3, out y3);
                (x2, y2, x4, y4) = (x1, y1, x3, y3);
                if (!Big.In(x1, sx1, sx2) || !Big.In(y1, sy1, sy2))
                {
                    (x1, y1, x2, y2) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
                }
                if (!Big.In(x3, sx1, sx2) || !Big.In(y3, sy1, sy2))
                {
                    (x3, y3, x4, y4) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
                }
                return;
            }

            if (ea1 == eb1)
            {
                EllipseAndCircle(ex2, ey2, ea2, eb2, rotate2, ex1, ey1, ea1, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
                return;
            }

            if (ea2 == eb2)
            {
                EllipseAndCircle(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
                return;
            }


            TwoEllipses(ea1, eb1, rotate1, ex2 - ex1, ey2 - ey1, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            x1 += ex1;
            y1 += ey1;
            x2 += ex1;
            y2 += ey1;
            x3 += ex1;
            y3 += ey1;
            x4 += ex1;
            y4 += ey1;
        }

        public static void TwoEllipses(in Big ex1, in Big ey1, in Big ea1, in Big eb1, in Big rotate1, in Big ex2, in Big ey2, in Big ea2, in Big eb2, in Big rotate2, out Point p1, out Point p2, out Point p3, out Point p4)
        {
            (p1, p2, p3, p4) = (Point.NaN, Point.NaN, Point.NaN, Point.NaN);
            TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out p1.X, out p1.Y, out p2.X, out p2.Y, out p3.X, out p3.Y, out p4.X, out p4.Y);
        }

        public static void Intersect(this Ellipse e1, in Ellipse e2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            TwoEllipses(e1.X, e1.Y, e1.A, e1.B, e1.Rotate, e2.X, e2.Y, e2.A, e2.B, e2.Rotate, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
        }

        public static void Intersect(this Ellipse e1, in Ellipse e2, out Point p1, out Point p2, out Point p3, out Point p4)
        {
            (p1, p2, p3, p4) = (Point.NaN, Point.NaN, Point.NaN, Point.NaN);
            TwoEllipses(e1.X, e1.Y, e1.A, e1.B, e1.Rotate, e2.X, e2.Y, e2.A, e2.B, e2.Rotate, out p1.X, out p1.Y, out p2.X, out p2.Y, out p3.X, out p3.Y, out p4.X, out p4.Y);
        }
    }
}
