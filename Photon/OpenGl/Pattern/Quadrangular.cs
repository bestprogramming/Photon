using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Quadrangular : Shape
    {
        public Quadrangular(double x, double y, double z, double width, double height, double length, int countSpheresInCube, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();

            var row = Packing.SpheresInACube.Table[countSpheresInCube];
            var cs = Packing.SpheresInACube.GetCenters(countSpheresInCube);

            var max = Math.Max(width, Math.Max(height, length));
            var ratio = 1 / max;
            
            var w_2 = width * ratio / 2;
            var w1 = -w_2 + row.Radius;
            var w2 = w_2 - row.Radius;

            var h_2 = height * ratio / 2;
            var h1 = -h_2 + row.Radius;
            var h2 = h_2 - row.Radius;

            var l_2 = length * ratio / 2;
            var l1 = -l_2 + row.Radius;
            var l2 = l_2 - row.Radius;

            foreach (var c in cs)
            {
                if (Compare.In(c.X, w1, w2) && Compare.In(c.Y, h1, h2) && Compare.In(c.Z, l1, l2))
                {
                    var cx = x + (w_2 + c.X) / ratio;
                    var cy = y + (h_2 + c.Y) / ratio;
                    var cz = z + (l_2 + c.Z) / ratio;
                    vertices.Add(new(new((float)cx, (float)cy, (float)cz), color, (float)pointSize));
                }
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
