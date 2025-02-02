using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct Point3 : IEquatable<Point3>
    {
        public static readonly Point3 Zero = new(0, 0, 0);

        public Big X;
        public Big Y;
        public Big Z;

        public Point3(in Big x, in Big y, in Big z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static bool operator ==(in Point3 left, in Point3 right) => left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        public static bool operator !=(in Point3 left, in Point3 right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Point3 point3 && Equals(point3);
        public readonly bool Equals(Point3 other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        public Point3 Offset(in Big dx, in Big dy, in Big dz)
        {
            return new Point3(X + dx, Y + dy, Z + dz);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y},Z={Z}}}";
    }
}
