using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Polygon : Shape
    {
        public Polygon(double x, double y, double z, double r, int edgesCount, int pointsPerEdge, double from, double to, bool end, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();

            var sweep = to - from;

            if (sweep < 0)
            {
                sweep += Const.Pi2;
            }

            if (edgesCount == 0)
            {
                vertices.Add(new(new(
                    (float)x,
                    (float)y,
                    (float)z
                ), color, (float)pointSize));
            }
            else
            {
                var step = sweep / edgesCount;

                var x1 = 0.0;
                var y1 = 0.0;
                for (var n = 0; n <= edgesCount; n++)
                {
                    var a = from + n * step;
                    Rotation.Circular(a, x, y, r, out double x2, out double y2);

                    if (n != 0)
                    {
                        vertices.AddRange(new Line(x1, y1, z, x2, y2, z, pointsPerEdge, n == edgesCount && end, color, pointSize).Vertices);
                    }

                    x1 = x2;
                    y1 = y2;
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
