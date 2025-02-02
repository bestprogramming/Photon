using Silk.NET.OpenGL;

namespace Photon.OpenGl
{
    public class Ucs : Shape
    {
        public Ucs()
        {
            Vertices = new Vertex[]
            {
                new(new(0.0f, 0.0f, 0.0f), new(1.0f, 0.0f, 0.0f, 0.4f)),
                new(new(1.0f, 0.0f, 0.0f), new(1.0f, 0.0f, 0.0f, 0.4f)),

                new(new(0.0f, 0.0f, 0.0f), new(0.0f, 1.0f, 0.0f, 0.4f)),
                new(new(0.0f, 1.0f, 0.0f), new(0.0f, 1.0f, 0.0f, 0.4f)),

                new(new(0.0f, 0.0f, 0.0f), new(0.0f, 0.0f, 1.0f, 0.4f)),
                new(new(0.0f, 0.0f, 1.0f), new(0.0f, 0.0f, 1.0f, 0.4f)),
            };
        }


        public unsafe override void Render(GL gl)
        {
            base.Render(gl);
            gl.DrawArrays(PrimitiveType.Lines, 0, (uint)Vertices.Length);
        }
    }
}
