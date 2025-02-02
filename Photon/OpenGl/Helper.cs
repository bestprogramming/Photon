using Photon.OpenGl;
using Photon.Packing;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace Photon
{
    public enum VibrateBy : byte { Sphere = 0, RandomSphere = 1, SphericalShell = 2, RandomSphericalShell = 3 }

    public static partial class Helper
    {
        public static Vec4 ToVec4(this Hsl hsl)
        {
            float r;
            float g;
            float b;

            if (hsl.S == 0)
            {
                r = g = b = hsl.L;
            }
            else
            {
                float v1, v2;
                float hue = (float)hsl.H / 360;

                v2 = (hsl.L < 0.5) ? (hsl.L * (1 + hsl.S)) : ((hsl.L + hsl.S) - (hsl.L * hsl.S));
                v1 = 2 * hsl.L - v2;

                r = HueToRgb(v1, v2, hue + (1.0f / 3));
                g = HueToRgb(v1, v2, hue);
                b = HueToRgb(v1, v2, hue - (1.0f / 3));
            }

            return new(r, g, b, 1);
        }

        public static Vec4 ToVec4(this Color c)
        {
            return new(c.R / 255f, c.G / 255f, c.B / 255f, c.A / 255f);
        }

        public static IEnumerable<Vec3> GetVibrations(double x, double y, double z, double radius, int count, VibrateBy vibrateBy)
        {
            if (vibrateBy == VibrateBy.RandomSphere)
            {
                while (count-- > 0)
                {
                    var r = Rand.NextDouble() * radius;
                    var rv = Rand.Vector3D();
                    Dimension.Lerp(x, y, z, x + rv.X, y + rv.Y, z + rv.Z, r, out Vec3 v);
                    yield return v;
                }
            }
            else if (vibrateBy == VibrateBy.Sphere)
            {
                count = SpheresInASphere.Table.First(p => p.Key >= count).Key;
                if (count == 1)
                {
                    var r = Rand.NextDouble() * radius;
                    Dimension.Lerp(x, y, z, Rand.Vector3D(), radius, out Vec3 v);
                    yield return v;
                }
                else
                {
                    foreach (var vertex in new OpenGl.Sphere(x, y, z, radius, count, Vec4.Zero, 1).Vertices)
                    {
                        yield return vertex.Position;
                    }
                }
            }
            else if (vibrateBy == VibrateBy.SphericalShell)
            {
                foreach (var vertex in new SphericalShell(x, y, z, radius, count, Vec4.Zero, 1).Vertices)
                {
                    yield return vertex.Position;
                }
            }
            if (vibrateBy == VibrateBy.RandomSphericalShell)
            {
                while (count-- > 0)
                {
                    Dimension.Lerp(x, y, z, Rand.Vector3D(), radius, out Vec3 v);
                    yield return v;
                }

            }
        }

        public static void CloneVibrate(this Shape shape, double radius, int count, VibrateBy vibrateBy)
        {
            if (count > 0 && radius > 0 && shape.Vertices.Length > 0)
            {
                var vertices = new List<Vertex>();

                foreach (var v in shape.Vertices)
                {
                    vertices.AddRange(GetVibrations(v.Position.X, v.Position.Y, v.Position.Z, radius, count, vibrateBy).Select(p => new Vertex(p, v.Color, v.PointSize)));
                }

                shape.Vertices = vertices.ToArray();
            }
        }
    }
}
