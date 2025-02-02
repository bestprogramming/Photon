using System.Diagnostics;
using System.Numerics;
using G = Photon.Geogebra;

namespace Photon
{
    public static partial class Algebra
    {
        //Ax2_Bxy_Cy2_Dx_Ey_F
        public static void Conic_acf_acf(in Big a1, in Big c1, in Big f1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            x1 = Big.Sqrt((c1 * f2 - c2 * f1) / (a1 * c2 - c1 * a2));
            y1 = Big.Sqrt((-f2 - a2 * x1 * x1) / c2);

            (x2, y2, x3, y3, x4, y4) = (-x1, y1, -x1, -y1, x1, -y1);
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F
        public static void ConicD1GtE1_def_acf(in Big d1, in Big e1, in Big f1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            Quadratic(a2 * e1 * e1 + c2 * d1 * d1, 2 * c2 * d1 * f1, f1 * f1 + e1 * e1 * f2, out x1, out x2);
            y1 = (-f1 - d1 * x1) / e1;
            y2 = (-f1 - d1 * x2) / e1;
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F
        public static void Conic_def_acf(in Big d1, in Big e1, in Big f1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            if (Big.Abs(e1) < Big.Abs(d1))
            {
                ConicD1GtE1_def_acf(e1, d1, f1, a2, c2, f2, out y1, out x1, out y2, out x2);
                return;
            }

            ConicD1GtE1_def_acf(d1, e1, f1, a2, c2, f2, out x1, out y1, out x2, out y2);
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F
        public static void Conic_bde_acf(in Big b1, in Big d1, in Big e1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            //var goegebra = G.Execute(
            //    G.Conic(a2, b1, c2, d1, e1, f2, "eq"),
            //    "");

            (x1, x2, x3, x4) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);

            var a = c2 * b1 * b1;
            var b = 2 * b1 * c2 * d1;
            var c = a2 * e1 * e1 + c2 * d1 * d1 + b1 * b1 * f2;
            var d = 2 * b1 * d1 * f2;
            var e = f2 * d1 * d1;

            Quartic(a, b, c, d, e, out y1, out y2, out y3, out y4);
            Helper.AscReal(ref y1, ref y2, ref y3, ref y4);

            static void GetX(in Big y, in Big b1, in Big d1, in Big e1, in Big a2, in Big c2, in Big f2, out Big xx1, out Big xx2)
            {
                var denominator = b1 * y + d1;

                if (denominator == 0)
                {
                    xx1 = Big.Sqrt((-f2 - c2 * y * y) / a2);
                    xx2 = -xx1;
                }
                else
                {
                    xx1 = -e1 * y / denominator;
                    xx2 = Big.NaN;
                }
            }

            if (!y1.IsNaN)
            {
                GetX(y1, b1, d1, e1, a2, c2, f2, out x1, out x2);
            }
            if (!y2.IsNaN && x2.IsNaN)
            {
                GetX(y2, b1, d1, e1, a2, c2, f2, out x2, out x3);
            }
            if (!y3.IsNaN && x3.IsNaN)
            {
                GetX(y3, b1, d1, e1, a2, c2, f2, out x3, out x4);
            }
            if (!y4.IsNaN && x4.IsNaN)
            {
                GetX(y4, b1, d1, e1, a2, c2, f2, out x4, out _);
            }
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F, a1=1,c1=1
        public static void Conic_a1c1def_acf(in Big d1, in Big e1, in Big f1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            (x1, x2, x3, x4) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);

            var a = c2 * c2 - 2 * c2 * a2 + a2 * a2;
            var b = -2 * c2 * a2 * e1 + 2 * e1 * a2 * a2;
            var c = 2 * c2 * f2
                 - 2 * c2 * a2 * f1 + e1 * e1 * a2 * a2 + 2 * f1 * a2 * a2 + c2 * d1 * d1 * a2 - 2 * f2 * a2;
            var d = -2 * f2 * a2 * e1 + 2 * f1 * e1 * a2 * a2;
            var e = f2 * f2 + a2 * a2 * f1 * f1 - 2 * f2 * a2 * f1 + a2 * d1 * d1 * f2;

            Quartic(a, b, c, d, e, out y1, out y2, out y3, out y4);
            Helper.AscReal(ref y1, ref y2, ref y3, ref y4);


            static void GetX(in Big y, in Big d1, in Big e1, in Big f1, in Big a2, in Big c2, in Big f2, in Big denominator, out Big xx1, out Big xx2)
            {
                var y2 = y * y;

                if (denominator == 0)
                {
                    var sqrt = Big.Sqrt(d1 * d1 - 4 * (y2 + e1 * y + f1));

                    if (d1 > 0)
                    {
                        xx1 = 2 * (y2 + e1 * y + f1) / (-d1 - sqrt);
                        xx2 = (-d1 - sqrt) / 2;
                    }
                    else
                    {
                        xx1 = (-d1 + sqrt) / 2;
                        xx2 = 2 * (y2 + e1 * y + f1) / (-d1 + sqrt);
                    }
                    return;
                }

                xx1 = -(f2 + c2 * y2 - a2 * y2 - a2 * e1 * y - a2 * f1) / denominator;
                xx2 = Big.NaN;
            }

            var denominator = -a2 * d1;

            if (!y1.IsNaN)
            {
                GetX(y1, d1, e1, f1, a2, c2, f2, denominator, out x1, out x2);
            }
            if (!y2.IsNaN && x2.IsNaN)
            {
                GetX(y2, d1, e1, f1, a2, c2, f2, denominator, out x2, out x3);
            }
            if (!y3.IsNaN && x3.IsNaN)
            {
                GetX(y3, d1, e1, f1, a2, c2, f2, denominator, out x3, out x4);
            }
            if (!y4.IsNaN && x4.IsNaN)
            {
                GetX(y4, d1, e1, f1, a2, c2, f2, denominator, out x4, out _);
            }
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F
        public static void Conic_abcde_acf(in Big a1, in Big b1, in Big c1, in Big d1, in Big e1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            var goegebra = G.Execute(
                G.Conic(a1, b1, c1, d1, e1, 0, "f1"),
                G.Conic(a2, 0, c2, 0, 0, f2, "f2"));
            //Debug.WriteLine(goegebra);

            if (a1 == 0 && b1 == 0 && c1 == 0)
            {
                Conic_def_acf(d1, e1, 0, a2, c2, f2, out x1, out y1, out x2, out y2);
                (x3, y3, x4, y4) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
                return;
            }
            if (a1 == 0 && c1 == 0)
            {
                Conic_bde_acf(b1, d1, e1, a2, c2, f2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
                return;
            }

            (x1, x2, x3, x4) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);

            var a = a1 * a1 * c2 * c2 - 2 * a1 * c2 * a2 * c1 + a2 * a2 * c1 * c1 + b1 * b1 * a2 * c2;
            var b = 2 * c2 * b1 * a2 * d1 - 2 * a1 * c2 * a2 * e1 + 2 * e1 * c1 * a2 * a2;
            var c = 2 * c2 * f2 * a1 * a1 + f2 * a2 * b1 * b1 + e1 * e1 * a2 * a2 + c2 * d1 * d1 * a2 - 2 * a1 * f2 * a2 * c1;
            var d = -2 * a1 * f2 * a2 * e1 + 2 * f2 * b1 * a2 * d1;
            var e = a1 * a1 * f2 * f2 + a2 * d1 * d1 * f2;

            Quartic(a, b, c, d, e, out y1, out y2, out y3, out y4);
            Helper.AscReal(ref y1, ref y2, ref y3, ref y4);

            static void GetX(in Big y, in Big a1, in Big b1, in Big c1, in Big d1, in Big e1, in Big a2, in Big c2, in Big f2, out Big xx1, out Big xx2)
            {
                var y2 = y * y;
                var denominator = -a2 * b1 * y - a2 * d1;

                if (denominator == 0)
                {
                    Quadratic(a1, b1 * y + d1, c1 * y2 + e1 * y, out xx1, out xx2);
                }
                else
                {
                    xx1 = -(a1 * f2 + a1 * c2 * y2 - a2 * c1 * y2 - a2 * e1 * y) / denominator;
                    xx2 = Big.NaN;
                }
            }

            if (!y1.IsNaN)
            {
                GetX(y1, a1, b1, c1, d1, e1, a2, c2, f2, out x1, out x2);
            }
            if (!y2.IsNaN && x2.IsNaN)
            {
                GetX(y2, a1, b1, c1, d1, e1, a2, c2, f2, out x2, out x3);
            }
            if (!y3.IsNaN && x3.IsNaN)
            {
                GetX(y3, a1, b1, c1, d1, e1, a2, c2, f2, out x3, out x4);
            }
            if (!y4.IsNaN && x4.IsNaN)
            {
                GetX(y4, a1, b1, c1, d1, e1, a2, c2, f2, out x4, out _);
            }
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F
        private static void ConicA2GtA1_abcf_acf(in Big a1, in Big b1, in Big c1, in Big f1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            var a = a1 * a1 * c2 * c2 - 2 * a1 * c2 * a2 * c1 + a2 * a2 * c1 * c1 + b1 * b1 * a2 * c2;
            var c = 2 * c2 * f2 * a1 * a1 + f2 * a2 * b1 * b1 - 2 * a1 * c2 * a2 * f1 + 2 * f1 * c1 * a2 * a2 - 2 * a1 * f2 * a2 * c1;
            var e = a1 * a1 * f2 * f2 + a2 * a2 * f1 * f1 - 2 * a1 * f2 * a2 * f1;

            Quadratic(a, c, e, out Big z0, out Big z1);
            y1 = Big.Sqrt(z0);
            x1 = Big.Sqrt((-f2 - c2 * y1 * y1) / a2);
            (x2, y2) = (-x1, -y1);
            if (Big.Abs(a1 * x2 * x2 + b1 * x2 * y1 + c1 * y1 * y1 + f1) < Big.Abs(a1 * x1 * x1 + b1 * x1 * y1 + c1 * y1 * y1 + f1))
            {
                (x1, x2) = (x2, x1);
            }

            y3 = Big.Sqrt(z1);
            x3 = Big.Sqrt((-f2 - c2 * y3 * y3) / a2);
            (x4, y4) = (-x3, -y3);
            if (Big.Abs(a1 * x4 * x4 + b1 * x4 * y3 + c1 * y3 * y3 + f1) < Big.Abs(a1 * x3 * x3 + b1 * x3 * y3 + c1 * y3 * y3 + f1))
            {
                (x3, x4) = (x4, x3);
            }
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F
        public static void Conic_abcf_acf(in Big a1, in Big b1, in Big c1, in Big f1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            if (Big.Abs(a1) > Big.Abs(a2))
            {
                ConicA2GtA1_abcf_acf(c1, b1, a1, f1, c2, a2, f2, out y1, out x1, out y2, out x2, out y3, out x3, out y4, out x4);
                return;
            }

            ConicA2GtA1_abcf_acf(a1, b1, c1, f1, a2, c2, f2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F
        public static void Conic_acef_acf(in Big a1, in Big c1, in Big e1, in Big f1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            Quadratic(c1 * a2 - a1 * c2, e1 * a2, f1 * a2 - a1 * f2, out y1, out y3);
            (y2, y4) = (y1, y3);

            x1 = Big.Sqrt((-f2 - c2 * y1 * y1) / a2);
            x2 = -x1;

            x3 = Big.Sqrt((-f2 - c2 * y3 * y3) / a2);
            x4 = -x3;
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F
        public static void Conic_acdf_acf(in Big a1, in Big c1, in Big d1, in Big f1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            Quadratic(a1 * c2 - c1 * a2, d1 * c2, f1 * c2 - c1 * f2, out x1, out x3);
            (x2, x4) = (x1, x3);

            y1 = Big.Sqrt((-f2 - a2 * x1 * x1) / c2);
            y2 = -y1;

            y3 = Big.Sqrt((-f2 - a2 * x3 * x3) / c2);
            y4 = -y3;
        }


        //Ax2_Bxy_Cy2_Dx_Ey_F
        private static void ConicA2GtC2_abcdef_acf(in Big a1, in Big b1, in Big c1, in Big d1, in Big e1, in Big f1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            var a = a1 * a1 * c2 * c2 - 2 * a1 * c2 * a2 * c1 + a2 * a2 * c1 * c1 + b1 * b1 * a2 * c2;
            var b = 2 * c2 * b1 * a2 * d1 - 2 * a1 * c2 * a2 * e1 + 2 * e1 * c1 * a2 * a2;
            var c = 2 * c2 * f2 * a1 * a1 + f2 * a2 * b1 * b1 - 2 * a1 * c2 * a2 * f1 + e1 * e1 * a2 * a2 + 2 * f1 * c1 * a2 * a2 + c2 * d1 * d1 * a2 - 2 * a1 * f2 * a2 * c1;
            var d = -2 * a1 * f2 * a2 * e1 + 2 * f1 * e1 * a2 * a2 + 2 * f2 * b1 * a2 * d1;
            var e = a1 * a1 * f2 * f2 + a2 * a2 * f1 * f1 - 2 * a1 * f2 * a2 * f1 + a2 * d1 * d1 * f2;

            Quartic(a, b, c, d, e, out y1, out y2, out y3, out y4);
            //Debug.WriteLine($"y1={y1}, y2={y2}, y3={y3}, y4={y4}");

            x1 = Big.Sqrt((-f2 - c2 * y1 * y1) / a2);
            if (Big.Abs(a1 * x1 * x1 - b1 * x1 * y1 + c1 * y1 * y1 - d1 * x1 + e1 * y1 + f1) < Big.Abs(a1 * x1 * x1 + b1 * x1 * y1 + c1 * y1 * y1 + d1 * x1 + e1 * y1 + f1))
            {
                x1 = -x1;
            }

            x2 = Big.Sqrt((-f2 - c2 * y2 * y2) / a2);
            if (Big.Abs(a1 * x2 * x2 - b1 * x2 * y2 + c1 * y2 * y2 - d1 * x2 + e1 * y2 + f1) < Big.Abs(a1 * x2 * x2 + b1 * x2 * y2 + c1 * y2 * y2 + d1 * x2 + e1 * y2 + f1))
            {
                x2 = -x2;
            }

            x3 = Big.Sqrt((-f2 - c2 * y3 * y3) / a2);
            if (Big.Abs(a1 * x3 * x3 - b1 * x3 * y3 + c1 * y3 * y3 - d1 * x3 + e1 * y3 + f1) < Big.Abs(a1 * x3 * x3 + b1 * x3 * y3 + c1 * y3 * y3 + d1 * x3 + e1 * y3 + f1))
            {
                x3 = -x3;
            }

            x4 = Big.Sqrt((-f2 - c2 * y4 * y4) / a2);
            if (Big.Abs(a1 * x4 * x4 - b1 * x4 * y4 + c1 * y4 * y4 - d1 * x4 + e1 * y4 + f1) < Big.Abs(a1 * x4 * x4 + b1 * x4 * y4 + c1 * y4 * y4 + d1 * x4 + e1 * y4 + f1))
            {
                x4 = -x4;
            }

            //Debug.WriteLine($"x1={x1}, x2={x2}, x3={x3}, x4={x4}");
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F
        public static void Conic_abcdef_acf(in Big a1, in Big b1, in Big c1, in Big d1, in Big e1, in Big f1, in Big a2, in Big c2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            //Debug.WriteLine($"a1={a1}, b1={b1}, c1={c1}, d1={d1}, e1={e1}, f1={f1},   a2={a2}, c2={c2}, f2={f2}");

            if (b1 == 0 && d1 == 0 && e1 == 0)
            {
                Conic_acf_acf(a1, c1, f1, a2, c2, f2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
                return;
            }

            if (b1 == 0 && d1 == 0)
            {
                Conic_acef_acf(a1, c1, e1, f1, a2, c2, f2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
                return;
            }

            if (b1 == 0 && e1 == 0)
            {
                Conic_acdf_acf(a1, c1, d1, f1, a2, c2, f2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
                return;
            }

            if (d1 == 0 && e1 == 0)
            {
                Conic_abcf_acf(a1, b1, c1, f1, a2, c2, f2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
                return;
            }

            if (f1 == 0)
            {
                Conic_abcde_acf(a1, b1, c1, d1, e1, a2, c2, f2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
                return;
            }

            if (Big.Abs(c2) > Big.Abs(a2))
            {
                ConicA2GtC2_abcdef_acf(c1, b1, a1, e1, d1, f1, c2, a2, f2, out y1, out x1, out y2, out x2, out y3, out x3, out y4, out x4);
                return;
            }

            ConicA2GtC2_abcdef_acf(a1, b1, c1, d1, e1, f1, a2, c2, f2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
        }

        //Ax2_Bxy_Cy2_Dx_Ey_F
        public static void Conic(in Big a1, in Big b1, in Big c1, in Big d1, in Big e1, in Big f1, in Big a2, in Big b2, in Big c2, in Big d2, in Big e2, in Big f2, out Big x1, out Big y1, out Big x2, out Big y2, out Big x3, out Big y3, out Big x4, out Big y4)
        {
            (x1, x2, x3, x4) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);

            var a = a1 * a1 * c2 * c2 - 2 * a1 * c2 * a2 * c1 + a2 * a2 * c1 * c1 - b1 * a1 * b2 * c2 - b1 * b2 * a2 * c1 + b1 * b1 * a2 * c2 + c1 * a1 * b2 * b2;
            var b = -2 * a1 * a2 * c1 * e2 + e2 * a2 * b1 * b1 + 2 * c2 * b1 * a2 * d1 - c1 * a2 * b2 * d1 + b2 * b2 * a1 * e1 - e2 * b2 * a1 * b1 - 2 * a1 * c2 * a2 * e1
                - e1 * a2 * b2 * b1 - c2 * b2 * a1 * d1 + 2 * e2 * c2 * a1 * a1 + 2 * e1 * c1 * a2 * a2 - c1 * a2 * d2 * b1 + 2 * d2 * b2 * a1 * c1 - c2 * d2 * a1 * b1;
            var c = e2 * e2 * a1 * a1 + 2 * c2 * f2 * a1 * a1 - e1 * a2 * d2 * b1 + f2 * a2 * b1 * b1 - e1 * a2 * b2 * d1 - f2 * b2 * a1 * b1 - 2 * a1 * e2 * a2 * e1
                + 2 * d2 * b2 * a1 * e1 - c2 * d2 * a1 * d1 - 2 * a1 * c2 * a2 * f1 + b2 * b2 * a1 * f1 + 2 * e2 * b1 * a2 * d1 + e1 * e1 * a2 * a2 - c1 * a2 * d2 * d1
                - e2 * b2 * a1 * d1 + 2 * f1 * c1 * a2 * a2 - f1 * a2 * b2 * b1 + c2 * d1 * d1 * a2 + d2 * d2 * a1 * c1 - e2 * d2 * a1 * b1 - 2 * a1 * f2 * a2 * c1;
            var d = e2 * d1 * d1 * a2 - f2 * d2 * a1 * b1 - 2 * a1 * f2 * a2 * e1 - f1 * a2 * b2 * d1 + 2 * d2 * b2 * a1 * f1 + 2 * e2 * f2 * a1 * a1
                + d2 * d2 * a1 * e1 - e2 * d2 * a1 * d1 - 2 * a1 * e2 * a2 * f1 - f1 * a2 * d2 * b1 + 2 * f1 * e1 * a2 * a2 - f2 * b2 * a1 * d1
                - e1 * a2 * d2 * d1 + 2 * f2 * b1 * a2 * d1;
            var e = f1 * a1 * d2 * d2 + a1 * a1 * f2 * f2 - d1 * a1 * d2 * f2 + a2 * a2 * f1 * f1 - 2 * a1 * f2 * a2 * f1 - d1 * d2 * a2 * f1 + a2 * d1 * d1 * f2;

            Quartic(a, b, c, d, e, out y1, out y2, out y3, out y4);
            Helper.AscReal(ref y1, ref y2, ref y3, ref y4);

            static void GetX(in Big y, in Big a1, in Big b1, in Big c1, in Big d1, in Big e1, in Big f1, in Big a2, in Big b2, in Big c2, in Big d2, in Big e2, in Big f2, out Big xx1, out Big xx2)
            {
                var y2 = y * y;
                var denominator = a1 * b2 * y + a1 * d2 - a2 * b1 * y - a2 * d1;

                if (denominator == 0)
                {
                    Quadratic(a1, b1 * y + d1, c1 * y2 + e1 * y + f1, out xx1, out xx2);
                }
                else
                {
                    xx1 = -(a1 * f2 + a1 * c2 * y2 - a2 * c1 * y2 + a1 * e2 * y - a2 * e1 * y - a2 * f1) / denominator;
                    xx2 = Big.NaN;
                }
            }

            if (!y1.IsNaN)
            {
                GetX(y1, a1, b1, c1, d1, e1, f1, a2, b2, c2, d2, e2, f2, out x1, out x2);
            }
            if (!y2.IsNaN && x2.IsNaN)
            {
                GetX(y2, a1, b1, c1, d1, e1, f1, a2, b2, c2, d2, e2, f2, out x2, out x3);
            }
            if (!y3.IsNaN && x3.IsNaN)
            {
                GetX(y3, a1, b1, c1, d1, e1, f1, a2, b2, c2, d2, e2, f2, out x3, out x4);
            }
            if (!y4.IsNaN && x4.IsNaN)
            {
                GetX(y4, a1, b1, c1, d1, e1, f1, a2, b2, c2, d2, e2, f2, out x4, out _);
            }
        }
    }
}
