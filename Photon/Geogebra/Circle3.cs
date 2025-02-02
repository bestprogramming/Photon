namespace Photon
{
    public static partial class Geogebra
    {
        public static string Circle3(double x, double y, double z, double ax, double bx, double ay, double by, double az, double bz, string suffix = "c")
        {
            return $"\"{suffix}=({x}, {y}, {z}) + ({ax} * cos(t) + {bx} * sin(t), {ay} * cos(t) + {by} * sin(t), {az} * cos(t) + {bz} * sin(t))\"";
        }

        public static string Circle3(in Circle3 c, string suffix = "c")
        {
            return Circle3(c.X, c.Y, c.Z, c.Ax, c.Bx, c.Ay, c.By, c.Az, c.Bz, suffix);
        }
    }
}
