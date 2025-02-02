using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Rectangle : Shape
    {
        public double Height;

        public Rectangle(double x, double y, double z, double width, int count, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();

            var row = Packing.CirclesInARectangle.Table[count];
            Height = row.Height * width;

            var cs = Packing.CirclesInARectangle.GetBorderCenters(count);

            foreach (var c in cs)
            {
                var cx = x + c.X * width;
                var cy = y + c.Y * width;
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
