using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Sphere : Shape
    {
        public Sphere(double x, double y, double z, double r, int count, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();

            var row = Packing.SpheresInASphere.Table[count];
            var centers = Packing.SpheresInASphere.GetCenters(count);
            r /= (1 - row.Radius);

            foreach (var center in centers)
            {
                var cx = x + center.X * r;
                var cy = y + center.Y * r;
                var cz = z + center.Z * r;
                vertices.Add(new(new((float)cx, (float)cy, (float)cz), color, (float)pointSize));
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
