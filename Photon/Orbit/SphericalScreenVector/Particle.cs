using Photon.OpenGl;
using System.Diagnostics.CodeAnalysis;

namespace Photon.SphericalScreenVector
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


        private List<Orbit> GetOrbits(in Sphere screen, in Big x, in Big y, in Big z)
        {
            var ret = new List<Orbit>();

            var s = new Sphere(x, y, z, 0);
            var r = Big.Abs(screen.R - s.Distance(screen));
            var n = (int)Big.Sqrt(r / R) + 1;
            s.R = n * n * R;

            while (screen.Intersect(s, out Circle3Projection cp))
            {
                ret.Add(new Orbit(n, cp, x, y, z, W));

                n++;
                s.R = n * n * R;
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
                    ret.AddRange(GetOrbits(setting.Screen, vibration.X, vibration.Y, vibration.Z));
                }
            }
            else
            {
                ret.AddRange(GetOrbits(setting.Screen, X, Y, Z));
            }

            return ret;
        }
    }
}
