using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public struct Rectangle : IEquatable<Rectangle>
    {
        public Big X;
        public Big Y;
        public Big Width;
        public Big Height;

        public Rectangle(in Big x, in Big y, in Big width, in Big height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public readonly Big Left => X;
        public readonly Big Top => Y + Height;
        public readonly Big Right => X + Width;
        public readonly Big Bottom => Y;

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Rectangle rectangle && Equals(rectangle);

        public readonly bool Equals(Rectangle other) => this == other;

        public static bool operator ==(in Rectangle left, in Rectangle right) =>
            left.X == right.X && left.Y == right.Y && left.Width == right.Width && left.Height == right.Height;

        public static bool operator !=(in Rectangle left, in Rectangle right) => !(left == right);

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Width, Height);

        public override readonly string ToString() => $"{{X={X},Y={Y},Width={Width},Height={Height}}}";
    }
}
