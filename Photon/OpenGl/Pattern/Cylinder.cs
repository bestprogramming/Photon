using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Cylinder : Shape
    {
        public Cylinder(double x, double y, double z, double r, double length, int countSpheresInCube, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();

            var row = Packing.SpheresInACube.Table[countSpheresInCube];
            var cs = Packing.SpheresInACube.GetCenters(countSpheresInCube);

            var max = Math.Max(2 * r, length);
            var ratio = 1 / max;

            var rMin = r * ratio - 2 * row.Radius;

            var l_2 = length * ratio / 2;
            var l1 = -l_2 + row.Radius;
            var l2 = l_2 - row.Radius;

            foreach (var c in cs)
            {
                if (Compare.In(c.Z, l1, l2) && Compare.Lte(Math.Sqrt(c.X * c.X + c.Y * c.Y), rMin))
                {
                    var cx = x + c.X / ratio;
                    var cy = y + c.Y / ratio;
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
