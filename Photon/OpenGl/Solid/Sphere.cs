using Silk.NET.OpenGL;
using System.Numerics;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl.Solid
{
    public class Sphere : Shape
    {
        private static readonly float f = (1f + MathF.Sqrt(5)) / 2f;

        private static readonly Vec3[] vertices12 = new Vec3[]
        {
            new(-1, f, 0), new(1, f, 0), new(-1, -f, 0), new(1, -f, 0),
            new(0, -1, f), new(0, 1, f), new(0, -1, -f), new(0, 1, -f),
            new(f, 0, -1), new(f, 0, 1), new(-f, 0, -1), new(-f, 0, 1),
        };

        private static readonly uint[] indices20 = new uint[]
        {
            0, 11, 5, 0, 5, 1, 0, 1, 7, 0, 7, 10, 0, 10, 11,
            11, 10, 2, 5, 11, 4, 1, 5, 9, 7, 1, 8, 10, 7, 6,
            3, 9, 4, 3, 4, 2, 3, 2, 6, 3, 6, 8, 3, 8, 9,
            9, 8, 1, 4, 9, 5, 2, 4, 11, 6, 2, 10, 8, 6, 7
        };

        private readonly Dictionary<uint, uint> Mids = new();

        public Sphere(float x, float y, float z, float r, int order, Vec4 color)
        {
            var t = (int)MathF.Pow(4, order);
            Vertices = new Vertex[10 * t + 2];
            for (var n = 0; n < vertices12.Length; n++)
            {
                Vertices[n] = new(vertices12[n], color);
            }

            uint v = 12;

            Indices = indices20;
            var indecesPrev = Indices;

            for (var i = 0; i < order; i++)
            {
                Indices = new uint[indecesPrev.Length * 4];
                for (var k = 0; k < indecesPrev.Length; k += 3)
                {
                    var v1 = indecesPrev[k + 0];
                    var v2 = indecesPrev[k + 1];
                    var v3 = indecesPrev[k + 2];
                    var a = AddMid(ref v, v1, v2, color);
                    var b = AddMid(ref v, v2, v3, color);
                    var c = AddMid(ref v, v3, v1, color);
                    t = k * 4;
                    Indices[t++] = v1; Indices[t++] = a; Indices[t++] = c;
                    Indices[t++] = v2; Indices[t++] = b; Indices[t++] = a;
                    Indices[t++] = v3; Indices[t++] = c; Indices[t++] = b;
                    Indices[t++] = a; Indices[t++] = b; Indices[t++] = c;
                }
                indecesPrev = Indices;
            }

            for (var i = 0; i < Vertices.Length; i++)
            {
                var m = r / Vertices[i].Position.Length();
                Vertices[i].Position.X = x + Vertices[i].Position.X * m;
                Vertices[i].Position.Y = y + Vertices[i].Position.Y * m;
                Vertices[i].Position.Z = z + Vertices[i].Position.Z * m;
            }
        }

        public unsafe override void Render(GL gl)
        {
            base.Render(gl);
            
            gl.DrawElements(PrimitiveType.Triangles, (uint)Indices.Length, DrawElementsType.UnsignedInt, null);
            //gl.DrawArrays(PrimitiveType.Points, 0, (uint)Vertices.Length);
        }

        private uint AddMid(ref uint v, uint a, uint b, Vec4 color)
        {
            var key = Convert.ToUInt32((a + b) * (a + b + 1) / 2 + Math.Min(a, b));
            if (Mids.TryGetValue(key, out uint i))
            {
                Mids.Remove(key);
                return i;
            }

            Mids[key] = v;

            Vertices[v] = new((Vertices[a].Position + Vertices[b].Position) / 2f, color);
            return v++;
        }
    }

}
