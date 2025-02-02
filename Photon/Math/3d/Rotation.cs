

namespace Photon
{
    public static partial class Rotation
    {
        public static void PointAt(in Big ang, in Big cx, in Big cy, in Big cz, in Big ax, in Big bx, in Big ay, in Big by, in Big az, in Big bz, out Big x, out Big y, out Big z)
        {
            x = cx + ax * Big.Cos(ang) + bx * Big.Sin(ang);
            y = cy + ay * Big.Cos(ang) + by * Big.Sin(ang);
            z = cz + az * Big.Cos(ang) + bz * Big.Sin(ang);
        }

        public static void PointAt(this Circle3 c, in Big ang, out Big x, out Big y, out Big z)
        {
            PointAt(ang, c.X, c.Y, c.Z, c.Ax, c.Bx, c.Ay, c.By, c.Az, c.Bz, out x, out y, out z);
        }

        public static void PointAt(this Circle3 c, in Big ang, out Point3 p)
        {
            p = default;
            PointAt(ang, c.X, c.Y, c.Z, c.Ax, c.Bx, c.Ay, c.By, c.Az, c.Bz, out p.X, out p.Y, out p.Z);
        }

        public static Point3 PointAt(this Circle3 c, in Big ang)
        {
            PointAt(c, ang, out Point3 p);
            return p;
        }
    }
}
