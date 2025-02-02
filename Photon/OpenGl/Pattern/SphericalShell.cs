using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class SphericalShell : Shape
    {
        public SphericalShell(double x, double y, double z, double r, int count, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();

            if (r == 0)
            {
                vertices.Add(new(new((float)x, (float)y, (float)z), color, (float)pointSize));
            }
            else if (count == 1)
            {
                Dimension.Lerp(x, y, z, Rand.Vector3D(), r, out double px, out double py, out double pz);
                vertices.Add(new(new((float)px, (float)py, (float)pz), color, (float)pointSize));
            }
            else
            {
                var phi = Const.Pi * (3 - Math.Sqrt(5));

                for (var n = 0; n < count; n++)
                {
                    var py = r * (1 - 2d * n / (count - 1));
                    var radius = Math.Sqrt(r * r - py * py);
                    var theta = phi * n;
                    var px = Math.Cos(theta) * radius;
                    var pz = Math.Sin(theta) * radius;
                    vertices.Add(new(new((float)(x + px), (float)(y + py), (float)(z + pz)), color, (float)pointSize));
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
