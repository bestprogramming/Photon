using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;
using G = Photon.Geogebra;

namespace Photon.OpenGl
{
    public class PolygonPrism : Shape
    {
        public PolygonPrism(double x, double y, double z, double r, double length, PointD[] points, int countSpheresInCube, Vec4 color, double pointSize = 1)
        {
            Get(x, y, z, r, length, points, countSpheresInCube, color, pointSize);
        }

        public PolygonPrism(double x, double y, double z, double r, int edgesCount, double length, int countSpheresInCube, double from, double to, bool end, Vec4 color, double pointSize = 1)
        {
            var sweep = to - from;

            if (sweep < 0)
            {
                sweep += Const.Pi2;
            }

            if (edgesCount == 0)
            {
                Vertices = new Vertex[]
                {
                    new(new((float)x, (float)y, (float)z), color, (float)pointSize)
                };
            }
            else
            {
                var step = sweep / edgesCount;

                var points = new List<PointD>();
                for (var n = 0; n <= edgesCount; n++)
                {
                    var a = from + n * step;
                    Rotation.Circular(a, x, y, r, out double px, out double py);

                    if (n < edgesCount || end)
                    {
                        points.Add(new(px, py));
                    }
                }

                Get(x, y, z, r, length, points.ToArray(), countSpheresInCube, color, pointSize);
            }
        }

        private void Get(double x, double y, double z, double r, double length, PointD[] points, int countSpheresInCube, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();
            var centers = Packing.SpheresInACube.GetCenters(countSpheresInCube);

            var max = Math.Max(2 * r, length);
            var l_2 = length / 2;

            foreach (var center in centers)
            {
                var cx = x + center.X * max;
                var cy = y + center.Y * max;
                var cz = center.Z * max;

                if (Compare.In(cz, -l_2, l_2) && Intersection.IsPointInPolygon(cx, cy, points))
                {
                    vertices.Add(new(new((float)cx, (float)cy, (float)(z + cz)), color, (float)pointSize));
                }
            }

            Vertices = vertices.ToArray();
        }

        public unsafe override void Render(GL gl)
        {
            base.Render(gl);
            gl.DrawArrays(PrimitiveType.Points, 0, (uint)Vertices.Length);
        }
    }

}
