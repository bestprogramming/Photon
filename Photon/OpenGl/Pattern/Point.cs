using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Point : Shape
    {
        public Point(double x, double y, double z, Vec4 color, double pointSize = 1)
        {
            Vertices = new Vertex[]
            {
                new(new((float)x, (float)y, (float)z), color, (float)pointSize),
            };
        }

        public unsafe override void Render(GL gl)
        {
            base.Render(gl);
            gl.DrawArrays(PrimitiveType.Points, 0, (uint)Vertices.Length);
        }
    }

}
