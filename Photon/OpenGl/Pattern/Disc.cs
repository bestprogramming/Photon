using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Disc : Shape
    {
        public Disc(double x, double y, double z, double r, int count, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();
            var centers = Packing.CirclesInACircle.GetCenters(count);

            foreach (var center in centers)
            {
                var cx = x + center.X * r;
                var cy = y + center.Y * r;
                vertices.Add(new(new((float)cx, (float)cy, (float)z), color, (float)pointSize));
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
