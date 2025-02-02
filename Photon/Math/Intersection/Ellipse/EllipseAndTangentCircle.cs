using System.Numerics;

namespace Photon
{
    //file:///C:/Quantum/Files/Images/Math/Intersection/Ellipse/EllipseAndTangentCircle.png
    public static partial class Intersection
    {
        private static void EllipseAndTangentCircleCxGtCy(in Big ea, in Big eb, in Big cx, in Big cy, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            var ea2 = ea * ea;
            var eb2 = eb * eb;

            Algebra.Conic_bde_acf(ea2 - eb2, eb2 * cy, -ea2 * cx, eb2, ea2, -ea2 * eb2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
        }

        public static void EllipseAndTangentCircle(in Big ea, in Big eb, in Big rotate, in Big cx, in Big cy, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            Big.SinCos(rotate, out Big sin, out Big cos);
            var cx1 = cos * cx + sin * cy;
            var cy1 = -sin * cx + cos * cy;

            if (Big.Abs(cy1) > Big.Abs(cx1)) EllipseAndTangentCircleCxGtCy(eb, ea, cy1, cx1, out y1, out x1, out y2, out x2, out y3, out x3, out y4, out x4);
            else EllipseAndTangentCircleCxGtCy(ea, eb, cx1, cy1, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            
            (x1, y1) = (cos * x1 - sin * y1, sin * x1 + cos * y1);
            (x2, y2) = (cos * x2 - sin * y2, sin * x2 + cos * y2);
            (x3, y3) = (cos * x3 - sin * y3, sin * x3 + cos * y3);
            (x4, y4) = (cos * x4 - sin * y4, sin * x4 + cos * y4);
        }

        public static void EllipseAndTangentCircle(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, in Big cx, in Big cy, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            EllipseAndTangentCircle(ea, eb, rotate, cx - ex, cy - ey, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            x1 += ex;
            y1 += ey;
            x2 += ex;
            y2 += ey;
            x3 += ex;
            y3 += ey;
            x4 += ex;
            y4 += ey;
        }

        public static void EllipseAndTangentCircle(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, in Big cx, in Big cy, out Point p1, out Point p2, out Point p3, out Point p4)
        {
            p1 = Point.NaN;
            p2 = Point.NaN;
            p3 = Point.NaN;
            p4 = Point.NaN;
            EllipseAndTangentCircle(ex, ey, ea, eb, rotate, cx, cy, out p1.X, out p1.Y, out p2.X, out p2.Y, out p3.X, out p3.Y, out p4.X, out p4.Y);
        }
    }
}
