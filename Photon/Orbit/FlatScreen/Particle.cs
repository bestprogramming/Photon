using Photon.OpenGl;
using System.Diagnostics.CodeAnalysis;

namespace Photon.FlatScreen
{
    public struct Particle : IEquatable<Particle>
    {
        public Big X;
        public Big Y;
        public Big Z;
        public Big R;
        public int W;

        public OrbitVibrateSetting? OrbitVibrateSetting;

        public Particle(in Big x, in Big y, in Big z, in Big r, int w, OrbitVibrateSetting? orbitVibrateSetting)
        {
            X = x;
            Y = y;
            Z = z;
            R = r;
            W = w;
            OrbitVibrateSetting = orbitVibrateSetting;
        }

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Particle particle && Equals(particle);

        public readonly bool Equals(Particle other) => this == other;

        public static bool operator ==(in Particle left, in Particle right) =>
            left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.R == right.R && left.W == right.W;

        public static bool operator !=(in Particle left, in Particle right) => !(left == right);

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, R, W);

        public void Offset(in Big x, in Big y, in Big z)
        {
            X += x;
            Y += y;
            Z += z;
        }

        public override readonly string ToString() => $"{{X={X},Y={Y},Z={Z},R={R},W={W}}}";


        private List<Orbit> GetOrbits(in Rectangle r, ScreenPlane screenPlane, in Big distance, in Big x, in Big y, in Big z)
        {
            var ret = new List<Orbit>();

            var n = (int)Big.Sqrt(distance / R) + 1;
            var or = R * n * n;
            var c = screenPlane == ScreenPlane.Xy ?
                new Circle(x, y, Big.Sqrt(or * or - distance * distance)) :
                screenPlane == ScreenPlane.Xz ? new Circle(x, z, Big.Sqrt(or * or - distance * distance)) :
                new Circle(y, z, Big.Sqrt(or * or - distance * distance));

            while (c.InOrIntersect(r))
            {
                ret.Add(new Orbit(n, c, W));

                n++;
                or = R * n * n;
                c = screenPlane == ScreenPlane.Xy ?
                    new Circle(x, y, Big.Sqrt(or * or - distance * distance)) :
                    screenPlane == ScreenPlane.Xz ? new Circle(x, z, Big.Sqrt(or * or - distance * distance)) :
                    new Circle(y, z, Big.Sqrt(or * or - distance * distance));
            }

            return ret;
        }

        public List<Orbit> GetOrbits(FormSetting setting)
        {
            var ret = new List<Orbit>();

            if (OrbitVibrateSetting != null && OrbitVibrateSetting.Count > 0 && OrbitVibrateSetting.Radius > 0)
            {
                var vibrations = Helper.GetVibrations(X, Y, Z, OrbitVibrateSetting.Radius * setting.PatternRatio, OrbitVibrateSetting.Count, OrbitVibrateSetting.VibrateBy);
                foreach (var vibration in vibrations)
                {
                    ret.AddRange(GetOrbits(setting.Screen, setting.ScreenPlane, setting.ScreenDistance, vibration.X, vibration.Y, vibration.Z));
                }
            }
            else
            {
                ret.AddRange(GetOrbits(setting.Screen, setting.ScreenPlane, setting.ScreenDistance, X, Y, Z));
            }

            return ret;
        }
    }
}
