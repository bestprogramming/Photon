using System.Diagnostics;
using static System.Windows.Forms.AxHost;

namespace Photon
{
    //file:///C:/Quantum/Files/Images/Math/Intersection/Ellipse/EllipseAndTangentEllipse.png
    public static partial class Intersection
    {
        public static void EllipseAndTangentEllipse(in Big ea1, in Big eb1, in Big ex2, in Big ey2, in Big ea2, in Big eb2, in Big rotate2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            var ea12 = ea1 * ea1;
            var eb12 = eb1 * eb1;

            Conversion.EllipseCanonicalToGeneral(ex2, ey2, ea2, eb2, rotate2, out Big a, out Big b, out Big c, out Big d, out Big e, out _);
            Algebra.Conic_abcde_acf(
               b * eb12,
               -2 * a * ea12 + 2 * c * eb12,
               -b * ea12,
               e * eb12,
               -d * ea12,
                eb12, ea12, -ea12 * eb12,
                out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4
            );
        }

        public static void EllipseAndTangentEllipse(in Big ea1, in Big eb1, in Big rotate1, in Big ex2, in Big ey2, in Big ea2, in Big eb2, in Big rotate2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            Big.SinCos(rotate1, out Big sin, out Big cos);
            var ex3 = cos * ex2 + sin * ey2;
            var ey3 = -sin * ex2 + cos * ey2;
            EllipseAndTangentEllipse(ea1, eb1, ex3, ey3, ea2, eb2, rotate2 - rotate1, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            (x1, y1) = (cos * x1 - sin * y1, sin * x1 + cos * y1);
            (x2, y2) = (cos * x2 - sin * y2, sin * x2 + cos * y2);
            (x3, y3) = (cos * x3 - sin * y3, sin * x3 + cos * y3);
            (x4, y4) = (cos * x4 - sin * y4, sin * x4 + cos * y4);
        }

        public static void EllipseAndTangentEllipse(in Big ex1, in Big ey1, in Big ea1, in Big eb1, in Big rotate1, in Big ex2, in Big ey2, in Big ea2, in Big eb2, in Big rotate2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            EllipseAndTangentEllipse(ea1, eb1, rotate1, ex2 - ex1, ey2 - ey1, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            x1 += ex1;
            y1 += ey1;
            x2 += ex1;
            y2 += ey1;
            x3 += ex1;
            y3 += ey1;
            x4 += ex1;
            y4 += ey1;
        }

        public static void EllipseAndTangentEllipse(in Big ex1, in Big ey1, in Big ea1, in Big eb1, in Big rotate1, in Big ex2, in Big ey2, in Big ea2, in Big eb2, in Big rotate2, out Point p1, out Point p2, out Point p3, out Point p4)
        {
            p1 = Point.NaN;
            p2 = Point.NaN;
            p3 = Point.NaN;
            p4 = Point.NaN;
            EllipseAndTangentEllipse( ex1,  ey1,  ea1,  eb1,  rotate1,  ex2,  ey2,  ea2,  eb2,  rotate2, out p1.X, out p1.Y, out p2.X, out p2.Y, out p3.X, out p3.Y, out p4.X, out p4.Y);
        }
    }
}