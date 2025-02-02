using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photon
{
    public static partial class Geogebra
    {
        public static string LineEq(double a, double b, double c, string suffix = "leq")
        {
            return $"\"{suffix}: ({a}x+{b}y+{c}=0)\"";
        }

        public static string LineEq(in Line l, string suffix = "leq")
        {
            return LineEq(l.A, l.B, l.C, suffix);
        }
    }
}
