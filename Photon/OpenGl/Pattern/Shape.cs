using Silk.NET.OpenGL;
using Vec3 = System.Numerics.Vector3;

namespace Photon.OpenGl
{
    public class Shape : IDisposable
    {
        public Vertex[] Vertices = Array.Empty<Vertex>();
        protected uint[] Indices = Array.Empty<uint>();

        protected BufferObject<Vertex>? Vbo;
        protected BufferObject<uint>? Ebo;
        protected VertexArrayObject<Vertex, uint>? Vao;

        public virtual void Dispose()
        {
            Ebo?.Dispose();
            Vbo?.Dispose();
            Vao?.Dispose();
            
            GC.SuppressFinalize(this);
        }

        public virtual void Translate(Vec3 distance)
        {
            for (var n = 0; n < Vertices.Length; n++)
            {
                Vertices[n].Position += distance;
            }
        }

        public virtual void Scale(Vec3 scale, Vec3 anchor)
        {
            for (var n = 0; n < Vertices.Length; n++)
            {
                Vertices[n].Position = scale * (Vertices[n].Position - anchor) + anchor;
            }
        }

        public virtual void Rotate(double ang, double x1, double y1, double z1, double x2, double y2, double z2)
        {
            for (var n = 0; n < Vertices.Length; n++)
            {
                var p = Vertices[n].Position;
                var px = p.X - x1;
                var py = p.Y - y1;
                var pz = p.Z - z1;

                var axisX = x2 - x1;
                var axisY = y2 - y1;
                var axisZ = z2 - z1;

                var cos = Math.Cos(ang);
                var sin = Math.Sin(ang);

                p.X = (float)(x1 + (cos + (1.0 - cos) * axisX * axisX) * px +
                    ((1.0 - cos) * axisX * axisY - axisZ * sin) * py +
                    ((1.0 - cos) * axisX * axisZ + axisY * sin) * pz);
                p.Y = (float)(y1 + ((1.0 - cos) * axisX * axisY + axisZ * sin) * px +
                    (cos + (1.0 - cos) * axisY * axisY) * py +
                    ((1.0 - cos) * axisY * axisZ - axisX * sin) * pz);
                p.Z = (float)(z1 + ((1.0 - cos) * axisX * axisZ - axisY * sin) * px +
                    ((1.0 - cos) * axisY * axisZ + axisX * sin) * py +
                    (cos + (1.0 - cos) * axisZ * axisZ) * pz);
                Vertices[n].Position = p;
            }
        }

        public virtual void Rotate(double ang, Vec3 p1, Vec3 p2)
        {
            Rotate(ang, p1.X, p1.Y, p1.Z, p2.X, p2.Y, p2.Z);
        }

        public virtual void Bind(GL gl)
        {
            if (Vertices.Length > 0)
            {
                Vbo = new(gl, Vertices, BufferTargetARB.ArrayBuffer);
            }

            if (Indices.Length > 0)
            {
                Ebo = new(gl, Indices, BufferTargetARB.ElementArrayBuffer);
            }

            Vao = new(gl);
            Vao.VertexAttributePointer(0, 3, VertexAttribPointerType.Float, 8, 0);
            Vao.VertexAttributePointer(1, 4, VertexAttribPointerType.Float, 8, 3);
            Vao.VertexAttributePointer(2, 1, VertexAttribPointerType.Float, 8, 7);

            Vbo?.Bind();
            Ebo?.Bind();
        }

        public unsafe virtual void Render(GL gl)
        {
            Vao?.Bind();
            Vbo?.Bind();
            Ebo?.Bind();
        }

        public void Save(string filename)
        {
            using var fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            using var bw = new BinaryWriter(fs);

            foreach (var vertex in Vertices)
            {
                bw.Write(vertex.Position.X);
                bw.Write(vertex.Position.Y);
                bw.Write(vertex.Position.Z);
                bw.Write(vertex.Color.X);
                bw.Write(vertex.Color.Y);
                bw.Write(vertex.Color.Z);
                bw.Write(vertex.Color.W);
                bw.Write(vertex.PointSize);
            }

            bw.Close();
        }
    }
}
