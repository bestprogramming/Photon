using System.Diagnostics;
using System.Numerics;
using G = Photon.Geogebra;

namespace Photon
{
    public static partial class Algebra
    {
        //ax^3 + bx^2 + cx + d = 0
        public static void Cubic(in Big a, in Big b, in Big c, in Big d, out Big x1, out Big x2, out Big x3)
        {
            (x2, x3) = (Big.NaN, Big.NaN);

            if (a == 0)
            {
                Quadratic(b, c, d, out x1, out x2);
                return;
            }

            var a0 = d / a;
            var a1 = c / a;
            var a2 = b / a;

            var Q = (3 * a1 - a2 * a2) / 9;
            var R = (9 * a2 * a1 - 27 * a0 - 2 * a2 * a2 * a2) / 54;

            var Q3 = Q * Q * Q;
            var D = Q3 + R * R;

            var shift = -a2 / 3;

            if (D >= 0)
            {
                var sqrtD = Big.Sqrt(D);

                var S = Big.Cbrt(R + sqrtD);
                var T = Big.Cbrt(R - sqrtD);
                x1 = shift + (S + T);
                if (D == 0)
                {
                    x2 = shift - S;
                    x3 = x2;
                }
            }
            else
            {
                var theta = Big.Acos(R / Big.Sqrt(-Q3));
                x1 = 2 * Big.Sqrt(-Q) * Big.Cos(theta / 3) + shift;
                x2 = 2 * Big.Sqrt(-Q) * Big.Cos((theta + Big.Pi2) / 3) + shift;
                x3 = 2 * Big.Sqrt(-Q) * Big.Cos((theta - Big.Pi2) / 3) + shift;
            }
        }
    }
}
