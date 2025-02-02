//using Silk.NET.OpenGL;
//using Vec3 = System.Numerics.Vector3;

//namespace Photon.OpenGl.Solid
//{
//    public class Shape : OpenGl.Shape, IDisposable
//    {
//        public new Vec3[] Vertices = Array.Empty<Vec3>();

//        protected new BufferObject<Vec3>? Vbo;
//        protected new VertexArrayObject<Vec3, uint>? Vao;

//        public override void Dispose()
//        {
//            Vbo?.Dispose();
//            Ebo?.Dispose();
//            Vao?.Dispose();

//            GC.SuppressFinalize(this);
//        }

//        public override void Translate(Vec3 distance)
//        {
//            for (var n = 0; n < Vertices.Length; n++)
//            {
//                Vertices[n] += distance;
//            }
//        }

//        public override void Scale(Vec3 scale, Vec3 anchor)
//        {
//            for (var n = 0; n < Vertices.Length; n++)
//            {
//                Vertices[n] = scale * (Vertices[n] - anchor) + anchor;
//            }
//        }

//        public override void Rotate(double ang, double x1, double y1, double z1, double x2, double y2, double z2)
//        {
//            for (var n = 0; n < Vertices.Length; n++)
//            {
//                var p = Vertices[n];
//                var px = p.X - x1;
//                var py = p.Y - y1;
//                var pz = p.Z - z1;

//                var axisX = x2 - x1;
//                var axisY = y2 - y1;
//                var axisZ = z2 - z1;

//                var cos = Math.Cos(ang);
//                var sin = Math.Sin(ang);

//                p.X = (float)(x1 + (cos + (1.0 - cos) * axisX * axisX) * px +
//                    ((1.0 - cos) * axisX * axisY - axisZ * sin) * py +
//                    ((1.0 - cos) * axisX * axisZ + axisY * sin) * pz);
//                p.Y = (float)(y1 + ((1.0 - cos) * axisX * axisY + axisZ * sin) * px +
//                    (cos + (1.0 - cos) * axisY * axisY) * py +
//                    ((1.0 - cos) * axisY * axisZ - axisX * sin) * pz);
//                p.Z = (float)(z1 + ((1.0 - cos) * axisX * axisZ - axisY * sin) * px +
//                    ((1.0 - cos) * axisY * axisZ + axisX * sin) * py +
//                    (cos + (1.0 - cos) * axisZ * axisZ) * pz);
//                Vertices[n] = p;
//            }
//        }

//        public override void Bind(GL gl)
//        {
//            if (Vertices.Length > 0)
//            {
//                Vbo = new(gl, Vertices, BufferTargetARB.ArrayBuffer);
//            }

//            if (Indices.Length > 0)
//            {
//                Ebo = new(gl, Indices, BufferTargetARB.ElementArrayBuffer);
//            }

//            Vao = new(gl);
//            Vao.VertexAttributePointer(0, 3, VertexAttribPointerType.Float, 7, 0);
//            Vao.VertexAttributePointer(1, 4, VertexAttribPointerType.Float, 7, 3);

//            Vbo?.Bind();
//            Ebo?.Bind();
//        }

//        public unsafe override void Render(GL gl)
//        {
//            Vao?.Bind();
//        }
//    }
//}
