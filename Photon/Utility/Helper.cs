using System.Numerics;

namespace Photon
{
    public static partial class Helper
    {
        public static void FromFloat(this NumericUpDown nud, float f)
        {
            nud.Value = (decimal)f;
        }

        public static float ToFloat(this NumericUpDown nud)
        {
            return (float)nud.Value;
        }

        public static void FromDouble(this NumericUpDown nud, double d)
        {
            nud.Value = (decimal)d;
        }

        public static double ToDouble(this NumericUpDown nud)
        {
            return (double)nud.Value;
        }

        public static void FromInt(this NumericUpDown nud, int i)
        {
            nud.Value = i;
        }

        public static int ToInt(this NumericUpDown nud)
        {
            return (int)nud.Value;
        }

        public static byte ToByte(this bool[] bools)
        {
            byte ret = 0;
            foreach (var b in bools)
            {
                ret <<= 1;
                if (b) ret |= 1;
            }
            return ret;
        }

        public static string ToLongString(this double d)
        {
            return d.ToString("0." + new string('#', 339));
        }

        public static double WrapTo2Pi(double ang) => ang > 0 ? ang % Const.Pi2 : Const.Pi2 + ang % Const.Pi2;

        public static double AcuteBetween(double ang1, double ang2)
        {
            var ret = Math.Abs(ang1 - ang2) % Const.Pi;

            if (ret > Const.PiOver2)
            {
                ret = Const.Pi - ret;
            }

            return ret;
        }

        public static void AscReal(ref Big v1, ref Big v2, ref Big v3, ref Big v4)
        {
            if (v1.IsNaN || v1 > v2) (v1, v2) = (v2, v1);
            if (v3.IsNaN || v3 > v4) (v3, v4) = (v4, v3);
            if (v1.IsNaN || v1 > v3) (v1, v3) = (v3, v1);
            if (v2.IsNaN || v2 > v4) (v2, v4) = (v4, v2);
            if (v2.IsNaN || v2 > v3) (v2, v3) = (v3, v2);
        }

        public static Big[] AscReal(params Big[] values)
        {
            return values.OrderBy(p => !p.IsNaN).ThenBy(p => Math.Abs(p)).ToArray();
        }
    }
}
