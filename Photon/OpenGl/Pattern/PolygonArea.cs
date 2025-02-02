using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;
using G = Photon.Geogebra;

namespace Photon.OpenGl
{
    public class PolygonArea : Shape
    {
        public PolygonArea(double x, double y, double z, double r, PointD[] points, int countCirclesInASquare, Vec4 color, double pointSize = 1)
        {
            Get(x, y, z, r, points, countCirclesInASquare, color, pointSize);
        }

        public PolygonArea(double x, double y, double z, double r, int edgesCount, int countCirclesInASquare, double from, double to, bool end, Vec4 color, double pointSize = 1)
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

                Get(x, y, z, r, points.ToArray(), countCirclesInASquare, color, pointSize);
            }
        }

        private void Get(double x, double y, double z, double r, PointD[] points, int countCirclesInASquare, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();
            var centers = Packing.CirclesInASquare.GetAreaCenters(countCirclesInASquare);

            foreach (var center in centers)
            {
                var cx = x + center.X * r * 2;
                var cy = y + center.Y * r * 2;

                if (Intersection.IsPointInPolygon(cx, cy, points))
                {
                    vertices.Add(new(new((float)cx, (float)cy, (float)z), color, (float)pointSize));
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
