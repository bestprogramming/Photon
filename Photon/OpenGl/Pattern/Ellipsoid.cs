using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class Ellipsoid : Shape
    {
        public Ellipsoid(double x, double y, double z, double a, double b, double c, int countSpheresInCube, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();
            var row = Packing.SpheresInACube.Table[countSpheresInCube];
            var centers = Packing.SpheresInACube.GetCenters(countSpheresInCube);

            var max = Math.Max(2 * a, 2 * c);
            var ratio = 1 / max;

            var aMin = a * ratio - 2 * row.Radius;
            var a2 = aMin * aMin;

            var bMin = b * ratio - 2 * row.Radius;
            var b2 = bMin * bMin;

            var cMin = c * ratio - 2 * row.Radius;
            var c2 = cMin * cMin;

            foreach (var center in centers)
            {
                if (Compare.Lte(center.X * center.X / a2 + center.Y * center.Y / b2 + center.Z * center.Z / c2, 1))
                {
                    var cx = x + center.X / ratio;
                    var cy = y + center.Y / ratio;
                    var cz = z + center.Z / ratio;
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
