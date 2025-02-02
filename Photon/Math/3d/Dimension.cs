using Vec3 = System.Numerics.Vector3;

namespace Photon
{
    public static partial class Dimension
    {
        public static Big LengthOfSegment(in Big x1, in Big y1, in Big z1, in Big x2, in Big y2, in Big z2)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            var dz = z2 - z1;
            return Big.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        public static Big LengthOfSegment(in Point3 p, in Sphere s)
        {
            return LengthOfSegment(p.X, p.Y, p.Z, s.X, s.Y, s.Z);
        }


        public static Big LengthOfVector(in Big x, in Big y, in Big z)
        {
            return Big.Sqrt(x * x + y * y + z * z);
        }

        public static Big Length(this Vector3 v)
        {
            return Big.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }


        public static Big Distance(this Point3 p1, in Big x2, in Big y2, in Big z2)
        {
            return LengthOfSegment(p1.X, p1.Y, p1.Z, x2, y2, z2);
        }

        public static Big Distance(this Point3 p1, in Point3 p2)
        {
            return LengthOfSegment(p1.X, p1.Y, p1.Z, p2.X, p2.Y, p2.Z);
        }

        public static Big Distance(this Sphere s1, in Sphere s2)
        {
            return LengthOfSegment(s1.X, s1.Y, s1.Z, s2.X, s2.Y, s2.Z);
        }

        public static Big Distance(this Sphere s, in Point3 p)
        {
            return LengthOfSegment(s.X, s.Y, s.Z, p.X, p.Y, p.Z);
        }


        public static void UnitVector(in Big vx, in Big vy, in Big vz, out Big x, out Big y, out Big z)
        {
            var l = LengthOfVector(vx, vy, vz);
            x = vx / l;
            y = vy / l;
            z = vz / l;
        }

        public static Vector3 Unit(this Vector3 v)
        {
            var l = v.Length();
            return new(v.X / l, v.Y / l, v.Z / l);
        }


        public static void Dot(in Big x1, in Big y1, in Big z1, in Big x2, in Big y2, in Big z2, out Big value)
        {
            value = x1 * x2 + y1 * y2 + z1 * z2;
        }

        public static void Dot(this Vector3 v1, in Big x2, in Big y2, in Big z2, out Big value)
        {
            Dot(v1.X, v1.Y, v1.Z, x2, y2, z2, out value);
        }

        public static void Dot(this Vector3 v1, in Vector3 v2, out Big value)
        {
            Dot(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, out value);
        }

        public static Big Dot(this Vector3 v1, in Vector3 v2)
        {
            Dot(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, out Big value);
            return value;
        }


        public static void Cross(in Big x1, in Big y1, in Big z1, in Big x2, in Big y2, in Big z2, out Big x, out Big y, out Big z)
        {
            x = y1 * z2 - z1 * y2;
            y = z1 * x2 - x1 * z2;
            z = x1 * y2 - y1 * x2;
        }

        public static void Cross(this Vector3 v1, in Big x2, in Big y2, in Big z2, out Big x, out Big y, out Big z)
        {
            Cross(v1.X, v1.Y, v1.Z, x2, y2, z2, out x, out y, out z);
        }

        public static void Cross(this Vector3 v1, in Vector3 v2, out Big x, out Big y, out Big z)
        {
            Cross(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, out x, out y, out z);
        }

        public static Vector3 Cross(this Vector3 v1, in Vector3 v2)
        {
            Cross(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, out Big x, out Big y, out Big z);
            return new(x, y, z);
        }


        public static void Reflect(in Big vx, in Big vy, in Big vz, in Big nx, in Big ny, in Big nz, out Big x, out Big y, out Big z)
        {
            var dot = vx * nx + vy * ny + vz * nz;
            var tempX = nx * dot * 2;
            var tempY = ny * dot * 2;
            var tempZ = nz * dot * 2;
            x = vx - tempX;
            y = vy - tempY;
            z = vz - tempZ;
        }

        public static void Reflect(this Vector3 v, in Big nx, in Big ny, in Big nz, out Big x, out Big y, out Big z)
        {
            Reflect(v.X, v.Y, v.Z, nx, ny, nz, out x, out y, out z);
        }

        public static void Reflect(this Vector3 v, in Vector3 normal, out Big x, out Big y, out Big z)
        {
            Reflect(v.X, v.Y, v.Z, normal.X, normal.Y, normal.Z, out x, out y, out z);
        }

        public static Vector3 Reflect(this Vector3 v, in Vector3 normal)
        {
            var dot = v.Dot(normal);
            var temp = normal * dot * 2.0;
            return v - temp;
        }


        public static void Lerp(in Big x1, in Big y1, in Big z1, in Big x2, in Big y2, in Big z2, in Big amount, out Big x, out Big y, out Big z)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            var dz = z2 - z1;
            var l = Big.Sqrt(dx * dx + dy * dy + dz * dz);

            x = x1 + amount * dx / l;
            y = y1 + amount * dy / l;
            z = z1 + amount * dz / l;
        }

        public static void Lerp(in Big x1, in Big y1, in Big z1, in Big x2, in Big y2, in Big z2, in Big amount, out Vector3 v)
        {
            v = Vector3.NaN;
            Lerp(x1, y1, z1, x2, y2, z2, amount, out v.X, out v.Y, out v.Z);
        }

        public static void Lerp(in Big x1, in Big y1, in Big z1, in Big x2, in Big y2, in Big z2, in Big amount, out Vec3 v)
        {
            Lerp(x1, y1, z1, x2, y2, z2, amount, out Big px, out Big py, out Big pz);
            v = new((float)px, (float)py, (float)pz);
        }

        public static void Lerp(in Big x1, in Big y1, in Big z1, in Vector3 v2, in Big amount, out Big x, out Big y, out Big z)
        {
            Lerp(x1, y1, z1, v2.X, v2.Y, v2.Z, amount, out x, out y, out z);
        }

        public static void Lerp(in Big x1, in Big y1, in Big z1, in Vector3 v2, in Big amount, out Vec3 v)
        {
            Lerp(x1, y1, z1, v2.X, v2.Y, v2.Z, amount, out Big px, out Big py, out Big pz);
            v = new((float)px, (float)py, (float)pz);
        }

        public static void Lerp(this Vector3 v1, in Big x2, in Big y2, in Big z2, in Big amount, out Big x, out Big y, out Big z)
        {
            Lerp(v1.X, v1.Y, v1.Z, x2, y2, z2, amount, out x, out y, out z);
        }

        public static void Lerp(this Vector3 v1, in Vector3 v2, in Big amount, out Big x, out Big y, out Big z)
        {
            Lerp(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, amount, out x, out y, out z);
        }

        public static Vector3 Lerp(this Vector3 v1, in Vector3 v2, in Big amount)
        {
            Lerp(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z, amount, out Big x, out Big y, out Big z);
            return new(x, y, z);
        }


        public static void Clamp(in Big vx, in Big vy, in Big vz, in Big minX, in Big minY, in Big minZ, in Big maxX, in Big maxY, in Big maxZ, out Big x, out Big y, out Big z)
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

        public static void Clamp(this Vector3 v, in Big minX, in Big minY, in Big minZ, in Big maxX, in Big maxY, in Big maxZ, out Big x, out Big y, out Big z)
        {
            Clamp(v.X, v.Y, v.Z, minX, minY, minZ, maxX, maxY, maxZ, out x, out y, out z);
        }

        public static void Clamp(this Vector3 v, in Vector3 min, in Vector3 max, out Big x, out Big y, out Big z)
        {
            Clamp(v.X, v.Y, v.Z, min.X, min.Y, min.Z, max.X, max.Y, max.Z, out x, out y, out z);
        }

        public static Vector3 Clamp(this Vector3 v, in Vector3 min, in Vector3 max)
        {
            Clamp(v.X, v.Y, v.Z, min.X, min.Y, min.Z, max.X, max.Y, max.Z, out Big x, out Big y, out Big z);
            return new(x, y, z);
        }


        public static bool RadiusOfTwoSphereIntersection(in Big r1, in Big x2, in Big r2, out Big r)
        {
            var r12 = r1 * r1;
            var x22 = x2 * x2;
            var r22 = r2 * r2;
            r = 4 * x22 * r12 - (x22 - r22 + r12) * (x22 - r22 + r12);
            if (r > 0)
            {
                r = 1 / (2 * x2) * Big.Sqrt(r);
            }
            return r >= 0;
        }

        public static bool RadiusOfTwoSphereIntersection(in Big x1, in Big y1, in Big z1, in Big r1, in Big x2, in Big y2, in Big z2, in Big r2, out Big r)
        {
            var d = LengthOfSegment(x1, y1, z1, x2, y2, z2);
            return RadiusOfTwoSphereIntersection(r1, d, r2, out r);
        }


        public static bool SurfaceAreaOfTwoSphereIntersection(in Big r1, in Big x2, in Big r2, out Big area) //https://en.wikipedia.org/wiki/Spherical_cap
        {
            area = Big.NaN;
            var ret = RadiusOfTwoSphereIntersection(r1, x2, r2, out Big r);

            if (ret)
            {
                var d = Big.Sqrt(r1 * r1 - r * r);
                var h = r1 - d;
                area = 2 * Big.Pi * r1 * h;
            }

            return ret;
        }
    }
}
