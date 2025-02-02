using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using G = Photon.Geogebra;

namespace Photon
{
    public static partial class Intersection
    {
        private static void EllipseAndCircleCxGtCy(in Big ea, in Big eb, in Big cx, in Big cy, in Big r, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            var geogebra = G.Execute(G.EllipseXy(0, 0, ea, eb, 0, "E"), G.Circle(cx, cy, r, "C"), G.Intersect("E", "C", "i"));

            var ea2 = ea * ea;
            var eb2 = eb * eb;

            Algebra.Conic_a1c1def_acf(
                -2 * cx, -2 * cy, cx * cx + cy * cy - r * r,
                eb2, ea2, -ea2 * eb2,
                out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4
            );
        }

        private static void EllipseAndCircle(in Big ea, in Big eb, in Big rotate, in Big cx, in Big cy, in Big r, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            Big.SinCos(rotate, out Big sin, out Big cos);
            var x = cos * cx + sin * cy;
            var y = -sin * cx + cos * cy;

            if (Big.Abs(y) > Big.Abs(x)) EllipseAndCircleCxGtCy(eb, ea, y, x, r, out y1, out x1, out y2, out x2, out y3, out x3, out y4, out x4);
            else EllipseAndCircleCxGtCy(ea, eb, x, y, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);

            if (!x1.IsNaN && !y1.IsNaN)
            {
                (x1, y1) = (cos * x1 - sin * y1, sin * x1 + cos * y1);
            }
            if (!x2.IsNaN && !y2.IsNaN)
            {
                (x2, y2) = (cos * x2 - sin * y2, sin * x2 + cos * y2);
            }
            if (!x3.IsNaN && !y3.IsNaN)
            {
                (x3, y3) = (cos * x3 - sin * y3, sin * x3 + cos * y3);
            }
            if (!x4.IsNaN && !y4.IsNaN)
            {
                (x4, y4) = (cos * x4 - sin * y4, sin * x4 + cos * y4);
            }
        }

        public static void EllipseAndCircle(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, in Big cx, in Big cy, in Big r, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            if (Conversion.EllipseToSegment(ex, ey, ea, eb, rotate, out Big sx1, out Big sy1, out Big sx2, out Big sy2))
            {
                CircleAndSegment(cx, cy, r, sx1, sy1, sx2, sy2, out x1, out y1, out x3, out y3);
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

            if (ea == eb)
            {
                TwoCircles(ex, ey, ea, cx, cy, r, out x1, out y1, out x2, out y2);
                (x3, y3, x4, y4) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
                return;
            }

            EllipseAndCircle(ea, eb, rotate, cx - ex, cy - ey, r, out  x1, out  y1, out  x2, out  y2, out  x3, out  y3, out  x4, out  y4);
            x1 += ex;
            y1 += ey;
            x2 += ex;
            y2 += ey;
            x3 += ex;
            y3 += ey;
            x4 += ex;
            y4 += ey;
        }

        public static void EllipseAndCircle(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, in Big cx, in Big cy, in Big r, out Point p1, out Point p2, out Point p3, out Point p4)
        {
            p1 = Point.NaN;
            p2 = Point.NaN;
            p3 = Point.NaN;
            p4 = Point.NaN;
            EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out p1.X, out p1.Y, out p2.X, out p2.Y, out p3.X, out p3.Y, out p4.X, out p4.Y);
        }
    }
}
