using Silk.NET.OpenGL;

namespace Photon.OpenGl
{
    public class Cube : Shape
    {
        public Cube()
        {
            Vertices = new Vertex[]
            {
                new(new(0.0f, 0.0f, 0.0f), new(1.0f, 0.0f, 0.0f, 1.0f)),
                new(new(1.0f, 0.0f, 0.0f), new(0.0f, 1.0f, 0.0f, 1.0f)),
                new(new(1.0f, 0.0f, 1.0f), new(0.0f, 0.0f, 1.0f, 1.0f)),
                new(new(0.0f, 0.0f, 1.0f), new(1.0f, 1.0f, 0.0f, 1.0f)),
                new(new(0.0f, 1.0f, 0.0f), new(1.0f, 0.0f, 1.0f, 1.0f)),
                new(new(1.0f, 1.0f, 0.0f), new(0.0f, 1.0f, 1.0f, 1.0f)),
                new(new(1.0f, 1.0f, 1.0f), new(0.3f, 0.3f, 0.3f, 1.0f)),
                new(new(0.0f, 1.0f, 1.0f), new(0.8f, 0.8f, 0.8f, 1.0f)),
            };

            Indices = new uint[]
            {
                //bottom
                0, 1, 2, 2, 3, 0,
                //top
                4, 7, 6, 6, 5, 4,
                //back
                0, 4, 5, 5, 1, 0,
                //front
                3, 2, 6, 6, 7, 3,
                //left
                0, 3, 7, 7, 4, 0,
                //right
                1, 5, 6, 6, 2, 1,
            };
        }

        public unsafe override void Render(GL gl)
        {
            base.Render(gl);
            gl.DrawElements(PrimitiveType.Triangles, (uint)Indices.Length, DrawElementsType.UnsignedInt, null);
        }
    }
}
