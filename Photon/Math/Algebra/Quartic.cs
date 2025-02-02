using System.Diagnostics;
using System.Numerics;
using G = Photon.Geogebra;

namespace Photon
{
    public static partial class Algebra
    {
        //ax^4 + bx^3 + cx^2 + dx + e = 0
        public static void Quartic(in Big a, in Big b, in Big c, in Big d, in Big e, out Big x1, out Big x2, out Big x3, out Big x4)
        {
            //var geogebra = G.Execute(
            //    G.Quartic(a, b, c, d, e, "f"),
            //    G.Intersect("f", "xAxis", "i"),
            //    "");
            //Debug.WriteLine(geogebra);

            if (b == 0 && d == 0) //case: Biquadratic
            {
                Quadratic(a, c, e, out Big z0, out Big z1);

                x1 = Big.Sqrt(z0);
                x2 = -x1;

                x3 = Big.Sqrt(z1);
                x4 = -x3;
            }
            else if (a == 0)
            {
                Cubic(b, c, d, e, out x1, out x2, out x3);
                x4 = Big.NaN;
            }
            else
            {
                var D0 = c * c - 3 * b * d + 12 * a * e;
                var D1 = 2 * c * c * c - 9 * b * c * d + 27 * b * b * e + 27 * a * d * d - 72 * a * c * e;
                if (D0 == 0 && D1 == 0) //case: At least three roots are equal 
                {
                    var sqrt = Big.Sqrt(9 * b * b - 24 * a * c);
                    Big r1, r2;
                    if (sqrt == 0)
                    {
                        r1 = -b / (4 * a);
                        r2 = r1;
                    }
                    else if (b > 0)
                    {
                        r1 = 2 * c / (-3 * b - sqrt);
                        r2 = (-3 * b - sqrt) / (12 * a);
                    }
                    else
                    {
                        r1 = (-3 * b + sqrt) / (12 * a);
                        r2 = 2 * c / (-3 * b + sqrt);
                    }

                    if (Big.Abs(a * r1 * r1 * r1 * r1 + b * r1 * r1 * r1 + c * r1 * r1 + d * r1 + e) < Big.Abs(a * r2 * r2 * r2 * r2 + b * r2 * r2 * r2 + c * r2 * r2 + d * r2 + e))
                    {
                        (x1, x2, x3, x4) = (r1, r1, r1, -b / a - 3 * r1);
                    }
                    else
                    {
                        (x1, x2, x3, x4) = (r2, r2, r2, -b / a - 3 * r2);
                    }

                    return;
                }

                var p = (8 * a * c - 3 * b * b) / (8 * a * a);
                var q = (b * b * b - 4 * a * b * c + 8 * a * a * d) / (8 * a * a * a);
                var D = (D1 * D1 - 4 * D0 * D0 * D0) / -27;
                //Debug.WriteLine($"D:{D}, D0:{D0}, D1:{D1}, p:{p}, q: {q}");
                //if (D == 0) //case: Polynomial is reducible
                //{

                //}
                
                Big S;
                if (D > 0)
                {
                    var phi = Big.Acos(D1 / (2 * Big.Sqrt(D0 * D0 * D0)));
                    S = 1d / 2 * Big.Sqrt(-2d / 3 * p + 2 / (3 * a) * Big.Sqrt(D0) * Big.Cos(phi / 3));
                }
                else
                {
                    var Q = Big.Cbrt((D1 + Big.Sqrt(D1 * D1 - 4 * D0 * D0 * D0)) / 2);
                    S = Big.Sqrt(-2 * p / 3 + (Q + D0 / Q) / (3 * a)) / 2;
                }

                var u = Big.Sqrt(-4 * S * S - 2 * p + q / S) / 2;
                var v = Big.Sqrt(-4 * S * S - 2 * p - q / S) / 2;
                x1 = -b / (4 * a) - S + u;
                x2 = -b / (4 * a) - S - u;
                x3 = -b / (4 * a) + S + v;
                x4 = -b / (4 * a) + S - v;
            }
        }
    }
}
