using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct Point : IEquatable<Point>
    {
        public static readonly Point Zero = new();

        public Big X;
        public Big Y;

        public Point(in Big x, in Big y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(in Point left, in Point right) => left.X == right.X && left.Y == right.Y;
        public static bool operator !=(in Point left, in Point right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Point point && Equals(point);
        public readonly bool Equals(Point other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        public Point Offset(in Big dx, in Big dy)
        {
            return new Point(X + dx, Y + dy);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y}}}";
    }
}
