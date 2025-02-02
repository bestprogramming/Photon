using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct Point3D : IEquatable<Point3D>
    {
        public static readonly Point3D Zero = new(0, 0, 0);

        public double X;
        public double Y;
        public double Z;

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static bool operator ==(in Point3D left, in Point3D right) => left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        public static bool operator !=(in Point3D left, in Point3D right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Point3D point3 && Equals(point3);
        public readonly bool Equals(Point3D other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        public Point3D Offset(double dx, double dy, double dz)
        {
            return new Point3D(X + dx, Y + dy, Z + dz);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y},Z={Z}}}";
    }
}
