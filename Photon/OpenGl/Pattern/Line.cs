using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Line : Shape
    {
        public Line(double x1, double y1, double z1, double x2, double y2, double z2, int count, bool end, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();

            var diffX = x2 - x1;
            var diffY = y2 - y1;
            var diffZ = z2 - z1;

            //var l = Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);

            var stepX = diffX / count;
            var stepY = diffY / count;
            var stepZ = diffZ / count;
            if (!end)
            {
                count--;
            }

            for (var n = 0; n <= count; n++)
            {
                vertices.Add(new(new(
                    (float)(x1 + n * stepX),
                    (float)(y1 + n * stepY),
                    (float)(z1 + n * stepZ)
                ), color, (float)pointSize));
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
