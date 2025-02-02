using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public struct Sphere : IEquatable<Sphere>
    {
        public Big X;
        public Big Y;
        public Big Z;
        public Big R;

        public Sphere(in Big x, in Big y, in Big z, in Big r)
        {
            X = x;
            Y = y;
            Z = z;
            R = r;
        }

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Sphere circle && Equals(circle);

        public readonly bool Equals(Sphere other) => this == other;

        public static bool operator ==(in Sphere left, in Sphere right) =>
            left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.R == right.R;

        public static bool operator !=(in Sphere left, in Sphere right) => !(left == right);

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, R);

        public Sphere Offset(in Big dx, in Big dy, in Big dz)
        {
            return new Sphere(X + dx, Y + dy, Z + dz, R);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y},Z={Z},R={R}}}";
    }
}
