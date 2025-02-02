using System.Diagnostics;
using G = Photon.Geogebra;

namespace Photon
{
    public static partial class Algebra
    {
        //ax^2 + bx + c = 0
        public static void Quadratic(in Big a, in Big b, in Big c, out Big x1, out Big x2)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    (x1, x2) = (Big.NaN, Big.NaN);
                    return;
                }
                x1 = -c / b;
                x2 = Big.NaN;
            }
            else
            {
                var sqrt = Big.Sqrt(b * b - 4 * a * c);

                if (sqrt == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else if (b > 0)
                {
                    x1 = 2 * c / (-b - sqrt);
                    x2 = (-b - sqrt) / (2 * a);
                }
                else
                {
                    x1 = (-b + sqrt) / (2 * a);
                    x2 = 2 * c / (-b + sqrt);
                }
            }
        }
    }
}
