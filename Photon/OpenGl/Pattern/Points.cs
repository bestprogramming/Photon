using Silk.NET.OpenGL;

namespace Photon.OpenGl
{
    public class Points : Shape
    {
        public Points(Vertex[] vertices)
        {
            Vertices = vertices;
        }

        public unsafe override void Render(GL gl)
        {
            base.Render(gl);
            gl.DrawArrays(PrimitiveType.Points, 0, (uint)Vertices.Length);
        }
    }

}
