namespace Photon
{
    public static partial class Intersection
    {
        private static bool TwoSpheresR1GtR2(in Big x1, in Big y1, in Big z1, in Big r1, in Big x2, in Big y2, in Big z2, in Big r2, out Big x, out Big y, out Big z, out Big r, out Big ax, out Big bx, out Big ay, out Big by, out Big az, out Big bz)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            var dz = z2 - z1;

            var d = Big.Sqrt(dx * dx + dy * dy + dz * dz);
            var d2 = d * d;
            var r12 = r1 * r1;
            var r22 = r2 * r2;

            r = 4 * d2 * r12 - (d2 - r22 + r12) * (d2 - r22 + r12);
            if (r > 0)
            {
                r = 1 / (2 * d) * Big.Sqrt(r);
                var length = Big.Sqrt(r12 - r * r);
                Dimension.Lerp(x1, y1, z1, x2, y2, z2, length, out x, out y, out z);
                var v = new Vector3(dx, dy, dz);

                //var up = dy > dx && dy > dz || dx == dz && dx > dy ? Vector3.UnitX :
                //    dz > dx && dz > dy || dy == dz && dy > dx ? Vector3.UnitY :
                //    Vector3.UnitZ;

                var up =
                    dy > dz && dy > dx ? Vector3.UnitX :
                    dy < dz && dy < dx ? Vector3.NegativeUnitX :

                    dz > dx && dz > dy ? Vector3.UnitY :
                    dz < dx && dz < dy ? Vector3.NegativeUnitY :

                    dx > dy && dx > dz ? Vector3.UnitZ : Vector3.NegativeUnitZ;

                var right = up.Cross(v);


                var ra = r * right.Unit();
                var rb = r * v.Cross(ra).Unit();


                ax = ra.X;
                bx = rb.X;

                ay = ra.Y;
                by = rb.Y;

                az = ra.Z;
                bz = rb.Z;

                return true;
            }

            (x, y, z, ax, bx, ay, by, az, bz) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN, Big.NaN, Big.NaN, Big.NaN, Big.NaN, Big.NaN);
            return false;
        }

        public static bool TwoSpheres(in Big x1, in Big y1, in Big z1, in Big r1, in Big x2, in Big y2, in Big z2, in Big r2, out Big x, out Big y, out Big z, out Big r, out Big ax, out Big bx, out Big ay, out Big by, out Big az, out Big bz)
        {

            if (r2 > r1) return TwoSpheresR1GtR2(x2, y2, z2, r2, x1, y1, z1, r1, out x, out y, out z, out r, out ax, out bx, out ay, out by, out az, out bz);
            else return TwoSpheresR1GtR2(x1, y1, z1, r1, x2, y2, z2, r2, out x, out y, out z, out r, out ax, out bx, out ay, out by, out az, out bz);
        }

        public static bool TwoSpheres(in Big x1, in Big y1, in Big z1, in Big r1, in Big x2, in Big y2, in Big z2, in Big r2, out Circle3 c)
        {
            c = Circle3.NaN;
            return TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out c.X, out c.Y, out c.Z, out c.R, out c.Ax, out c.Bx, out c.Ay, out c.By, out c.Az, out c.Bz);
        }

        public static bool Intersect(this Sphere s1, in Sphere s2, out Big x, out Big y, out Big z, out Big r, out Big ax, out Big bx, out Big ay, out Big by, out Big az, out Big bz)
        {
            return TwoSpheres(s1.X, s1.Y, s1.Z, s1.R, s2.X, s2.Y, s2.Z, s2.R, out x, out y, out z, out r, out ax, out bx, out ay, out by, out az, out bz);
        }

        public static bool Intersect(this Sphere s1, in Sphere s2, out Circle3 c)
        {
            c = Circle3.NaN;
            return TwoSpheres(s1.X, s1.Y, s1.Z, s1.R, s2.X, s2.Y, s2.Z, s2.R, out c.X, out c.Y, out c.Z, out c.R, out c.Ax, out c.Bx, out c.Ay, out c.By, out c.Az, out c.Bz);
        }

        private static bool TwoSpheresR1GtR2(in Big x1, in Big y1, in Big z1, in Big r1, in Big x2, in Big y2, in Big z2, in Big r2, out Ellipse xy, out Ellipse yz, out Ellipse zx)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            var dz = z2 - z1;

            var d = Big.Sqrt(dx * dx + dy * dy + dz * dz);
            var d2 = d * d;
            var r12 = r1 * r1;
            var r22 = r2 * r2;

            var r = 4 * d2 * r12 - (d2 - r22 + r12) * (d2 - r22 + r12);
            if (r > 0)
            {
                r = 1 / (2 * d) * Big.Sqrt(r);
                var length = Big.Sqrt(r12 - r * r);
                Dimension.Lerp(x1, y1, z1, x2, y2, z2, length, out Big x, out Big y, out Big z);
                var v = new Vector3(dx, dy, dz);
                var uv = v.Unit();

                if (uv != Vector3.UnitZ && uv != Vector3.NegativeUnitZ)
                {
                    var ra = r * v.Cross(Vector3.UnitZ).Unit();
                    var rb = r * v.Cross(ra).Unit();
                    xy = new Ellipse(x, y, Dimension.LengthOfVector(ra.X, ra.Y), Dimension.LengthOfVector(rb.X, rb.Y), Big.Atan2(ra.Y, ra.X));
                }
                else
                {
                    xy = new Ellipse(x, y, r, r, 0);
                }

                if (uv != Vector3.UnitX && uv != Vector3.NegativeUnitX)
                {
                    var ra = r * v.Cross(Vector3.UnitX).Unit();
                    var rb = r * v.Cross(ra).Unit();
                    yz = new Ellipse(y, z, Dimension.LengthOfVector(ra.Y, ra.Z), Dimension.LengthOfVector(rb.Y, rb.Z), Big.Atan2(ra.Z, ra.Y));
                }
                else
                {
                    yz = new Ellipse(y, z, r, r, 0);
                }

                if (uv != Vector3.UnitY && uv != Vector3.NegativeUnitY)
                {
                    var ra = r * v.Cross(Vector3.UnitY).Unit();
                    var rb = r * v.Cross(ra).Unit();
                    zx = new Ellipse(z, x, Dimension.LengthOfVector(ra.Z, ra.X), Dimension.LengthOfVector(rb.Z, rb.X), Big.Atan2(ra.X, ra.Z));
                }
                else
                {
                    zx = new Ellipse(z, x, r, r, 0);
                }

                return true;
            }

            (xy, yz, zx) = (Ellipse.NaN, Ellipse.NaN, Ellipse.NaN);
            return false;
        }

        public static bool TwoSpheres(in Big x1, in Big y1, in Big z1, in Big r1, in Big x2, in Big y2, in Big z2, in Big r2, out Ellipse xy, out Ellipse yz, out Ellipse zx)
        {
            if (r2 > r1) return TwoSpheresR1GtR2(x2, y2, z2, r2, x1, y1, z1, r1, out xy, out yz, out zx);
            else return TwoSpheresR1GtR2(x1, y1, z1, r1, x2, y2, z2, r2, out xy, out yz, out zx);
        }

        public static bool TwoSpheres(in Big x1, in Big y1, in Big z1, in Big r1, in Big x2, in Big y2, in Big z2, in Big r2, out Circle3Projection cp)
        {
            cp = Circle3Projection.NaN;
            return TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out cp.Xy, out cp.Yz, out cp.Zx);
        }

        public static bool TwoSpheres(this Sphere s1, in Big x2, in Big y2, in Big z2, in Big r2, out Circle3Projection cp)
        {
            cp = Circle3Projection.NaN;
            return TwoSpheres(s1.X, s1.Y, s1.Z, s1.R, x2, y2, z2, r2, out cp.Xy, out cp.Yz, out cp.Zx);
        }

        public static bool Intersect(this Sphere s1, in Sphere s2, out Circle3Projection cp)
        {
            cp = Circle3Projection.NaN;
            return TwoSpheres(s1.X, s1.Y, s1.Z, s1.R, s2.X, s2.Y, s2.Z, s2.R, out cp.Xy, out cp.Yz, out cp.Zx);
        }
    }
}
