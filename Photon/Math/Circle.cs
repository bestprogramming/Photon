using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public struct Circle : IEquatable<Circle>
    {
        public Big X;
        public Big Y;
        public Big R;

        public Circle(in Big x, in Big y, in Big r)
        {
            X = x;
            Y = y;
            R = r;
        }

        public Circle(in Point p1, in Point p2, in Point p3)
        {
            var x12 = p1.X - p2.X;
            var x13 = p1.X - p3.X;

            var y12 = p1.Y - p2.Y;
            var y13 = p1.Y - p3.Y;

            var y31 = p3.Y - p1.Y;
            var y21 = p2.Y - p1.Y;

            var x31 = p3.X - p1.X;
            var x21 = p2.X - p1.X;

            var sx13 = p1.X * p1.X - p3.X * p3.X;
            var sy13 = p1.Y * p1.Y - p3.Y * p3.Y;
            var sx21 = p2.X * p2.X - p1.X * p1.X;
            var sy21 = p2.Y * p2.Y - p1.Y * p1.Y;

            var f = (sx13 * x12 + sy13 * x12 + sx21 * x13 + sy21 * x13) / (2 * (y31 * x12 - y21 * x13));
            var g = (sx13 * y12 + sy13 * y12 + sx21 * y13 + sy21 * y13) / (2 * (x31 * y12 - x21 * y13));

            var c = -p1.X * p1.X - p1.Y * p1.Y - 2 * g * p1.X - 2 * f * p1.Y;

            X = -g;
            Y = -f;
            var sqr_of_r = X * X + Y * Y - c;

            R = Big.Sqrt(sqr_of_r);
        }

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Circle circle && Equals(circle);

        public readonly bool Equals(Circle other) => this == other;

        public static bool operator ==(in Circle left, in Circle right) => left.X == right.X && left.Y == right.Y && left.R == right.R;

        public static bool operator !=(in Circle left, in Circle right) => !(left == right);

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, R);

        public Circle Offset(in Big dx, in Big dy)
        {
            return new Circle(X + dx, Y + dy, R);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y},R={R}}}";
    }
}
