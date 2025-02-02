using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Circle : Shape
    {
        public Circle(double x, double y, double z, double r, int count, double from, double to, bool end, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();

            var sweep = to - from;

            if (sweep < 0)
            {
                sweep += Const.Pi2;
            }

            if (count == 0)
            {
                vertices.Add(new(new(
                    (float)x,
                    (float)y,
                    (float)z
                ), color, (float)pointSize));
            }
            else
            {
                var step = sweep / count;

                if (!end)
                {
                    count--;
                }

                for (var n = 0; n <= count; n++)
                {
                    var a = from + n * step;
                    Rotation.Circular(a, x, y, r, out double rotX, out double rotY);
                    vertices.Add(new(new(
                        (float)rotX,
                        (float)rotY,
                        (float)z
                    ), color, (float)pointSize));
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
