using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public struct RectangleD : IEquatable<RectangleD>
    {
        public double X;
        public double Y;
        public double Width;
        public double Height;

        public RectangleD(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public readonly double Left => X;
        public readonly double Top => Y + Height;
        public readonly double Right => X + Width;
        public readonly double Bottom => Y;

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is RectangleD rectangle && Equals(rectangle);

        public readonly bool Equals(RectangleD other) => this == other;

        public static bool operator ==(in RectangleD left, in RectangleD right) =>
            left.X == right.X && left.Y == right.Y && left.Width == right.Width && left.Height == right.Height;

        public static bool operator !=(in RectangleD left, in RectangleD right) => !(left == right);

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Width, Height);

        public override readonly string ToString() => $"{{X={X},Y={Y},Width={Width},Height={Height}}}";
    }
}
