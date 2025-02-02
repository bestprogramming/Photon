namespace Photon
{
    //https://en.wikipedia.org/wiki/Ellipse
    //AX ^ 2 + BXY + CY ^ 2 + DX + EY + F = 0
    public static partial class Conversion
    {
        public static void EllipseGeneralToCanonical(in Big a, in Big b, in Big c, in Big d, in Big e, in Big f, out Big ex, out Big ey, out Big ea, out Big eb, out Big rotate)
        {
            ea = -Big.Sqrt(2 * (a * e * e + c * d * d - b * d * e + (b * b - 4 * a * c) * f) * (a + c + Big.Sqrt((a - c) * (a - c) + b * b))) / (b * b - 4 * a * c);
            eb = -Big.Sqrt(2 * (a * e * e + c * d * d - b * d * e + (b * b - 4 * a * c) * f) * (a + c - Big.Sqrt((a - c) * (a - c) + b * b))) / (b * b - 4 * a * c);
            ex = (2 * c * d - b * e) / (b * b - 4 * a * c);
            ey = (2 * a * e - b * d) / (b * b - 4 * a * c);
            rotate = b != 0 ? Big.Atan2(c - a - Big.Sqrt((a - c) * (a - c) + b * b), b) : b == 0 && a < c ? 0 : Big.PiOver2;
        }


        public static void EllipseCanonicalToGeneral(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, out Big a, out Big b, out Big c, out Big d, out Big e, out Big f)
        {
            Big.SinCos(rotate, out Big sin, out Big cos);

            a = ea * ea * sin * sin + eb * eb * cos * cos;
            b = 2 * eb * eb * cos * sin - 2 * ea * ea * cos * sin;
            c = ea * ea * cos * cos + eb * eb * sin * sin;
            d = -2 * ea * ea * sin * sin * ex - 2 * eb * eb * cos * cos * ex + 2 * ea * ea * cos * ey * sin - 2 * eb * eb * cos * ey * sin;
            e = -2 * ea * ea * cos * cos * ey - 2 * eb * eb * sin * sin * ey + 2 * ea * ea * cos * ex * sin - 2 * eb * eb * cos * ex * sin;
            f = ea * ea * cos * cos * ey * ey + ea * ea * ex * ex * sin * sin + eb * eb * cos * cos * ex * ex + eb * eb * ey * ey * sin * sin + 2 * eb * eb * cos * ex * sin - 2 * ea * ea * cos * ex * ey * sin - ea * ea * eb * eb;
        }

        public static void ToGeneral(this Ellipse ellipse, out Big a, out Big b, out Big c, out Big d, out Big e, out Big f)
        {
            EllipseCanonicalToGeneral(ellipse.X, ellipse.Y, ellipse.A, ellipse.B, ellipse.Rotate, out a, out b, out c, out d, out e, out f);
        }
    }
}
