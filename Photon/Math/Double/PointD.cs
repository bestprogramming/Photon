using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct PointD : IEquatable<PointD>
    {
        public static readonly PointD Zero = new();

        public double X;
        public double Y;

        public PointD(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(in PointD left, in PointD right) => left.X == right.X && left.Y == right.Y;
        public static bool operator !=(in PointD left, in PointD right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is PointD point && Equals(point);
        public readonly bool Equals(PointD other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        public PointD Offset(double dx, double dy)
        {
            return new PointD(X + dx, Y + dy);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y}}}";
    }
}
