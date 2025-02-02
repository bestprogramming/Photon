using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photon
{
    public static partial class Geogebra
    {
        public static string Mx2_Nxy_Py2_r_0(double m, double n, double p, double r, string suffix = "f")
        {
            return $"\"{suffix}:({m}x^2+{n}xy+{p}y^2+{r}=0)\"";
        }

        public static string Quadratic(double a, double b, double c, string suffix = "f")
        {
            return $"\"{suffix}:(y={a}x^2+{b}x+{c})\"";
        }

        public static string Cubic(double a, double b, double c, double d, string suffix = "f")
        {
            return $"\"{suffix}:(y={a}x^3+{b}x^2+{c}x+{d})\"";
        }

        public static string Quartic(double a, double b, double c, double d, double e, string suffix = "f")
        {
            return $"\"{suffix}:(y={a}x^4+{b}x^3+{c}x^2+{d}x+{e})\"";
        }


        public static string Conic(double a, double b, double c, double d, double e, double f, string suffix = "f")
        {
            return $"\"{suffix}:({a}x^2+{b}xy+{c}y^2+{d}x+{e}y+{f}=0)\"";
        }
    }
}
