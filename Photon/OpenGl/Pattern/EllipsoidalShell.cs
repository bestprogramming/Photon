using Silk.NET.OpenGL;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public class EllipsoidalShell : Shape
    {
        public EllipsoidalShell(double x, double y, double z, double a, double b, double c, int countSpheresInCube, Vec4 color, double pointSize = 1)
        {
            var vertices = new List<Vertex>();
            var row = Packing.SpheresInACube.Table[countSpheresInCube];
            var centers = Packing.SpheresInACube.GetCenters(countSpheresInCube);

            var max = Math.Max(2 * a, 2 * c);
            var ratio = 1 / max;

            var aMin = a * ratio - row.Radius;
            var a2Min = aMin * aMin;

            var aMax = a * ratio + row.Radius;
            var a2Max = aMax * aMax;


            var bMin = b * ratio - row.Radius;
            var b2Min = bMin * bMin;

            var bMax = b * ratio + row.Radius;
            var b2Max = bMax * bMax;


            var cMin = c * ratio - row.Radius;
            var c2Min = cMin * cMin;

            var cMax = c * ratio + row.Radius;
            var c2Max = cMax * cMax;

            foreach (var center in centers)
            {
                if (Compare.Gte(center.X * center.X / a2Min + center.Y * center.Y / b2Min + center.Z * center.Z / c2Min, 1) &&
                    Compare.Lte(center.X * center.X / a2Max + center.Y * center.Y / b2Max + center.Z * center.Z / c2Max, 1))
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
