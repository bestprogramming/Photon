namespace Photon
{
    public static partial class Intersection
    {
        public static bool Intersect(this Circle3Projection cp1, in Circle3Projection cp2, out Point3 p1, out Point3 p2)
        {
            (p1, p2) = (Point3.NaN, Point3.NaN);

            Big a, b, c, d, e, f;
            Big QuadraticLength(in Big x, in Big y)
            {
                return a * x * x + b * x * y + c * y * y + d * x + e * y + f;
            }

            cp1.Xy.Intersect(cp2.Xy, out Point xy1, out Point xy2, out Point xy3, out Point xy4);
            cp1.Yz.Intersect(cp2.Yz, out Point yz1, out Point yz2, out Point yz3, out Point yz4);
            cp1.Zx.Intersect(cp2.Zx, out Point zx1, out Point zx2, out Point zx3, out Point zx4);
            
            var xys = new[] { xy1, xy2, xy3, xy4 }.Where(p => p.IsReal()).ToArray();
            var yzs = new[] { yz1, yz2, yz3, yz4 }.Where(p => p.IsReal()).ToArray();
            var zxs = new[] { zx1, zx2, zx3, zx4 }.Where(p => p.IsReal()).ToArray();

            Point3[]? ps = null;

            if (xys.Length > 0 && yzs.Length > 0 && zxs.Length > 0)
            {
                ps = (from xy in xys
                      from yz in yzs
                      from zx in zxs
                      orderby Big.Abs(xy.X - zx.Y) + Big.Abs(xy.Y - yz.X) + Big.Abs(yz.Y - zx.X)
                      select new Point3(xy.X, xy.Y, yz.Y)).Distinct().ToArray();
            }
            else if (xys.Length > 0 && yzs.Length > 0 && cp1.Zx == cp2.Zx)
            {
                cp1.Zx.ToGeneral(out a, out b, out c, out d, out e, out f);

                ps = (from xy in xys
                      from yz in yzs
                      orderby Big.Abs(xy.Y - yz.X) + QuadraticLength(yz.Y, xy.X)
                      select new Point3(xy.X, xy.Y, yz.Y)).Distinct().ToArray();
            }
            else if (xys.Length > 0 && cp1.Yz == cp2.Yz && zxs.Length > 0)
            {
                cp1.Yz.ToGeneral(out a, out b, out c, out d, out e, out f);

                ps = (from xy in xys
                      from zx in zxs
                      orderby Big.Abs(xy.X - zx.Y) + QuadraticLength(xy.Y, zx.X)
                      select new Point3(xy.X, xy.Y, zx.X)).Distinct().ToArray();
            }
            else if (cp1.Xy == cp2.Xy && yzs.Length > 0 && zxs.Length > 0)
            {
                cp1.Xy.ToGeneral(out a, out b, out c, out d, out e, out f);

                ps = (from yz in yzs
                      from zx in zxs
                      orderby Big.Abs(yz.Y - zx.X) + QuadraticLength(zx.Y, yz.X)
                      select new Point3(zx.Y, yz.X, yz.Y)).Distinct().ToArray();
            }

            if (ps != null)
            {
                p1 = ps[0];
                if (ps.Length > 1)
                {
                    p2 = ps[1];
                }
                return true;
            }

            return false;
        }
    }
}
