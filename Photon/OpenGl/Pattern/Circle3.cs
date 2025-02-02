using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Circle3 : Shape
    {
        public Circle3(double x, double y, double z, double ax, double bx, double ay, double by, double az, double bz, int count, double from, double to, Vec4 color, double pointSize = 1)
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

                for (var n = 0; n < count; n++)
                {
                    var t = from + n * step;
                    var cost = Math.Cos(t);
                    var sint = Math.Sin(t);
                    
                    var px = x + ax * cost + bx * sint;
                    var py = y + ay * cost + by * sint;
                    var pz = z + az * cost + bz * sint;

                    vertices.Add(new(new(
                        (float)px,
                        (float)py,
                        (float)pz
                    ), color, (float)pointSize));
                }
            }

            Vertices = vertices.ToArray();
        }

        public Circle3(Photon.Circle3 c, int count, double from, double to, Vec4 color)
            : this(c.X, c.Y, c.Z, c.Ax, c.Bx, c.Ay, c.By, c.Az, c.Bz, count, from, to, color)
        {
        }

        public unsafe override void Render(GL gl)
        {
            base.Render(gl);
            gl.DrawArrays(PrimitiveType.Points, 0, (uint)Vertices.Length);
        }
    }

}
