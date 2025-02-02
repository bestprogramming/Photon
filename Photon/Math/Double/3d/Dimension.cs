using Vec3 = System.Numerics.Vector3;

namespace Photon
{
    public static partial class Dimension
    {
        public static double LengthOfSegment(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            var dz = z2 - z1;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        public static double LengthOfSegment(in Point3D p, in SphereD s)
        {
            return LengthOfSegment(p.X, p.Y, p.Z, s.X, s.Y, s.Z);
        }


        public static double LengthOfVector(double x, double y, double z)
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public static double Length(this Vector3D v)
        {
            return Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }


        public static double Distance(this Point3D p1, double x2, double y2, double z2)
        {
            return LengthOfSegment(p1.X, p1.Y, p1.Z, x2, y2, z2);
        }

        public static double Distance(this Point3D p1, in Point3D p2)
        {
            return LengthOfSegment(p1.X, p1.Y, p1.Z, p2.X, p2.Y, p2.Z);
        }

        public static double Distance(this SphereD s1, in SphereD s2)
        {
            return LengthOfSegment(s1.X, s1.Y, s1.Z, s2.X, s2.Y, s2.Z);
        }

        public static double Distance(this SphereD s, in Point3D p)
        {
            return LengthOfSegment(s.X, s.Y, s.Z, p.X, p.Y, p.Z);
        }


        public static void UnitVector(double vx, double vy, double vz, out double x, out double y, out double z)
        {
            var l = LengthOfVector(vx, vy, vz);
            x = vx / l;
            y = vy / l;
            z = vz / l;
        }

        public static Vector3D Unit(this Vector3D v)
        {
            var l = v.Length();
            return new(v.X / l, v.Y / l, v.Z / l);
        }


        public static void Dot(double x1, double y1, double z1, double x2, double y2, double z2, out double value)
        {
            value = x1 * x2 + y1 * y2 + z1 * z2;
        }

        public static void Dot(this Vector3D v1, double x2, double y2, double z2, out double value)
        {
            Dot(v1.X, v1.Y, v1.Z, x2, y2, z2, out value);
        }

        public static void Dot(this Vector3D v1, in Vector3D v2, out double value)
        {
            Dot(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, out value);
        }

        public static double Dot(this Vector3D v1, in Vector3D v2)
        {
            Dot(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, out double value);
            return value;
        }


        public static void Cross(double x1, double y1, double z1, double x2, double y2, double z2, out double x, out double y, out double z)
        {
            x = y1 * z2 - z1 * y2;
            y = z1 * x2 - x1 * z2;
            z = x1 * y2 - y1 * x2;
        }

        public static void Cross(this Vector3D v1, double x2, double y2, double z2, out double x, out double y, out double z)
        {
            Cross(v1.X, v1.Y, v1.Z, x2, y2, z2, out x, out y, out z);
        }

        public static void Cross(this Vector3D v1, in Vector3D v2, out double x, out double y, out double z)
        {
            Cross(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, out x, out y, out z);
        }

        public static Vector3D Cross(this Vector3D v1, in Vector3D v2)
        {
            Cross(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, out double x, out double y, out double z);
            return new(x, y, z);
        }


        public static void Reflect(double vx, double vy, double vz, double nx, double ny, double nz, out double x, out double y, out double z)
        {
            var dot = vx * nx + vy * ny + vz * nz;
            var tempX = nx * dot * 2;
            var tempY = ny * dot * 2;
            var tempZ = nz * dot * 2;
            x = vx - tempX;
            y = vy - tempY;
            z = vz - tempZ;
        }

        public static void Reflect(this Vector3D v, double nx, double ny, double nz, out double x, out double y, out double z)
        {
            Reflect(v.X, v.Y, v.Z, nx, ny, nz, out x, out y, out z);
        }

        public static void Reflect(this Vector3D v, in Vector3D normal, out double x, out double y, out double z)
        {
            Reflect(v.X, v.Y, v.Z, normal.X, normal.Y, normal.Z, out x, out y, out z);
        }

        public static Vector3D Reflect(this Vector3D v, in Vector3D normal)
        {
            var dot = v.Dot(normal);
            var temp = normal * dot * 2.0;
            return v - temp;
        }


        public static void Lerp(double x1, double y1, double z1, double x2, double y2, double z2, double amount, out double x, out double y, out double z)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            var dz = z2 - z1;
            var l = Math.Sqrt(dx * dx + dy * dy + dz * dz);

            x = x1 + amount * dx / l;
            y = y1 + amount * dy / l;
            z = z1 + amount * dz / l;
        }

        public static void Lerp(double x1, double y1, double z1, double x2, double y2, double z2, double amount, out Vector3D v)
        {
            v = Vector3D.NaN;
            Lerp(x1, y1, z1, x2, y2, z2, amount, out v.X, out v.Y, out v.Z);
        }

        public static void Lerp(double x1, double y1, double z1, double x2, double y2, double z2, double amount, out Vec3 v)
        {
            Lerp(x1, y1, z1, x2, y2, z2, amount, out double px, out double py, out double pz);
            v = new((float)px, (float)py, (float)pz);
        }

        public static void Lerp(double x1, double y1, double z1, in Vector3D v2, double amount, out double x, out double y, out double z)
        {
            Lerp(x1, y1, z1, v2.X, v2.Y, v2.Z, amount, out x, out y, out z);
        }

        public static void Lerp(double x1, double y1, double z1, in Vector3D v2, double amount, out Vec3 v)
        {
            Lerp(x1, y1, z1, v2.X, v2.Y, v2.Z, amount, out double px, out double py, out double pz);
            v = new((float)px, (float)py, (float)pz);
        }

        public static void Lerp(this Vector3D v1, double x2, double y2, double z2, double amount, out double x, out double y, out double z)
        {
            Lerp(v1.X, v1.Y, v1.Z, x2, y2, z2, amount, out x, out y, out z);
        }

        public static void Lerp(this Vector3D v1, in Vector3D v2, double amount, out double x, out double y, out double z)
        {
            Lerp(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, amount, out x, out y, out z);
        }

        public static Vector3D Lerp(this Vector3D v1, in Vector3D v2, double amount)
        {
            Lerp(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, amount, out double x, out double y, out double z);
            return new(x, y, z);
        }


        public static void Clamp(double vx, double vy, double vz, double minX, double minY, double minZ, double maxX, double maxY, double maxZ, out double x, out double y, out double z)
        {
            x = vx;
            x = (x > maxX) ? maxX : x;
            x = (x < minX) ? minX : x;

            y = vy;
            y = (y > maxY) ? maxY : y;
            y = (y < minY) ? minY : y;

            z = vz;
            z = (z > maxZ) ? maxZ : z;
            z = (z < minZ) ? minZ : z;
        }

        public static void Clamp(this Vector3D v, double minX, double minY, double minZ, double maxX, double maxY, double maxZ, out double x, out double y, out double z)
        {
            Clamp(v.X, v.Y, v.Z, minX, minY, minZ, maxX, maxY, maxZ, out x, out y, out z);
        }

        public static void Clamp(this Vector3D v, in Vector3D min, in Vector3D max, out double x, out double y, out double z)
        {
            Clamp(v.X, v.Y, v.Z, min.X, min.Y, min.Z, max.X, max.Y, max.Z, out x, out y, out z);
        }

        public static Vector3D Clamp(this Vector3D v, in Vector3D min, in Vector3D max)
        {
            Clamp(v.X, v.Y, v.Z, min.X, min.Y, min.Z, max.X, max.Y, max.Z, out double x, out double y, out double z);
            return new(x, y, z);
        }


        public static bool RadiusOfTwoSphereDIntersection(double r1, double x2, double r2, out double r)
        {
            var r12 = r1 * r1;
            var x22 = x2 * x2;
            var r22 = r2 * r2;
            r = 4 * x22 * r12 - (x22 - r22 + r12) * (x22 - r22 + r12);
            if (r > 0)
            {
                r = 1 / (2 * x2) * Math.Sqrt(r);
            }
            return r >= 0;
        }

        public static bool RadiusOfTwoSphereDIntersection(double x1, double y1, double z1, double r1, double x2, double y2, double z2, double r2, out double r)
        {
            var d = LengthOfSegment(x1, y1, z1, x2, y2, z2);
            return RadiusOfTwoSphereDIntersection(r1, d, r2, out r);
        }
    }
}
