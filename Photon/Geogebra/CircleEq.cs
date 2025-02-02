using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photon
{
    public static partial class Geogebra
    {
        public static string CircleEq(double x, double y, double r, string suffix = "ceq")
        {
            return $"\"{suffix}: ((x-{x})^2 + (y-{y})^2 = {r}^2)\"";
        }

        public static string CircleEq(in Point p, double r, string suffix = "ceq")
        {
            return CircleEq(p.X, p.Y, r, suffix);
        }
    }
}
