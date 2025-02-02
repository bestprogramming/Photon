using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct Ellipse : IEquatable<Ellipse>
    {
        public Big X;
        public Big Y;
        public Big A;
        public Big B;
        public Big Rotate;

        public Ellipse(in Big x, in Big y, in Big a, in Big b, in Big rotate)
        {
            X = x;
            Y = y;
            A = a;
            B = b;
            Rotate = rotate;
        }

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Ellipse ellipse && Equals(ellipse);

        public readonly bool Equals(Ellipse other) => this == other;

        public static bool operator ==(in Ellipse left, in Ellipse right) => left.X == right.X && left.Y == right.Y && left.A == right.A && left.B == right.B && left.Rotate == right.Rotate;

        public static bool operator !=(in Ellipse left, in Ellipse right) => !(left == right);

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, A, B, Rotate);

        public Ellipse Offset(in Big dx, in Big dy)
        {
            return new Ellipse(X + dx, Y + dy, A, B, Rotate);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y},A={A},B={B},Rotate={Rotate}}}";
    }
}
