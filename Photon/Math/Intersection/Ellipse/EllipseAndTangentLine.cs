using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Photon
{
    //file:///C:/Quantum/Files/Images/Math/Intersection/Ellipse/EllipseAndTangentLine.png
    public static partial class Intersection
    {
        public static void TangentLineOfEllipse(in Big ea, in Big eb, in Big a, in Big b, out Big c)
        {
            c = Big.Sqrt(eb * eb * b * b + ea * ea * a * a);
        }

        public static void TangentLineOfEllipse(in Big ea, in Big eb, in Big rotate, in Big a, in Big b, out Big c)
        {
            Big.SinCos(rotate, out Big sin, out Big cos);
            TangentLineOfEllipse(ea, eb, a * cos + b * sin, b * cos - a * sin, out c);
        }

        public static void TangentLineOfEllipse(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, in Big a, in Big b, out Big c1, out Big c2)
        {
            TangentLineOfEllipse(ea, eb, rotate, a, b, out Big c);
            var d = a * ex + b * ey;
            c1 = c - d;
            c2 = -c - d;
        }


        private static void EllipseAndTangentLineBGtA(in Big ea, in Big eb, in Big a, in Big b, out Big c, out Big x, out Big y)
        {
            TangentLineOfEllipse(ea, eb, a, b, out c);

            var ea2 = ea * ea;
            x = -ea2 * a * c / (b * b * eb * eb + a * a * ea2);
            y = (-c - a * x) / b;
        }

        public static void EllipseAndTangentLine(in Big ea, in Big eb, in Big rotate, in Big a, in Big b, out Big c, out Big x, out Big y)
        {
            Big.SinCos(rotate, out Big sin, out Big cos);
            var a1 = a * cos + b * sin;
            var b1 = b * cos - a * sin;
            
            if (Big.Abs(a1) > Big.Abs(b1)) EllipseAndTangentLineBGtA(eb, ea, b1, a1, out c, out y, out x);
            else EllipseAndTangentLineBGtA(ea, eb, a1, b1, out c, out x, out y);
            
            (x, y) = (cos * x - sin * y, sin * x + cos * y);
        }

        public static void EllipseAndTangentLine(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, in Big a, in Big b, out Big c1, out Big c2, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            EllipseAndTangentLine(ea, eb, rotate, a, b, out c1, out x1, out y1);

            var d = a * ex + b * ey;
            (c1, c2, x1, y1, x2, y2) = (c1 - d, -c1 - d, ex + x1, ey + y1, ex - x1, ey - y1);
        }
    }
}
