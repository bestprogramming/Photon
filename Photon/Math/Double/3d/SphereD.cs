using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public struct SphereD : IEquatable<SphereD>
    {
        public double X;
        public double Y;
        public double Z;
        public double R;

        public SphereD(double x, double y, double z, double r)
        {
            X = x;
            Y = y;
            Z = z;
            R = r;
        }

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is SphereD circle && Equals(circle);

        public readonly bool Equals(SphereD other) => this == other;

        public static bool operator ==(in SphereD left, in SphereD right) =>
            left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.R == right.R;

        public static bool operator !=(in SphereD left, in SphereD right) => !(left == right);

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, R);

        public SphereD Offset(double dx, double dy, double dz)
        {
            return new SphereD(X + dx, Y + dy, Z + dz, R);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y},Z={Z},R={R}}}";
    }
}
