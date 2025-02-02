using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct VectorD : IEquatable<VectorD>
    {
        public static readonly VectorD Zero = new(0.0, 0.0);
        public static readonly VectorD One = new(1.0, 1.0);
        public static readonly VectorD UnitX = new(1.0, 0.0);
        public static readonly VectorD NegativeUnitX = new(-1.0, 0.0);
        public static readonly VectorD UnitY = new(0.0, 1.0);
        public static readonly VectorD NegativeUnitY = new(0.0, -1.0);

        public double X;
        public double Y;

        public VectorD(double x, double y)
        {
            X = x;
            Y = y;
        }

        public VectorD(double value) : this(value, value) { }


        public static VectorD operator +(in VectorD left, in VectorD right)
        {
            return new VectorD(left.X + right.X, left.Y + right.Y);
        }

        public static VectorD operator -(in VectorD left, in VectorD right)
        {
            return new VectorD(left.X - right.X, left.Y - right.Y);
        }

        public static VectorD operator *(in VectorD left, in VectorD right)
        {
            return new VectorD(left.X * right.X, left.Y * right.Y);
        }

        public static VectorD operator *(in VectorD left, double right)
        {
            return left * new VectorD(right);
        }

        public static VectorD operator *(double left, in VectorD right)
        {
            return new VectorD(left) * right;
        }

        public static VectorD operator /(in VectorD left, in VectorD right)
        {
            return new VectorD(left.X / right.X, left.Y / right.Y);
        }

        public static VectorD operator /(in VectorD value1, double value2)
        {
            var invDiv = 1.0 / value2;

            return new VectorD(
                value1.X * invDiv,
                value1.Y * invDiv);
        }

        public static VectorD operator -(in VectorD value)
        {
            return Zero - value;
        }

        public static bool operator ==(in VectorD left, in VectorD right) => left.X == right.X && left.Y == right.Y;
        public static bool operator !=(in VectorD left, in VectorD right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is VectorD vector && Equals(vector);
        public readonly bool Equals(VectorD other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        public VectorD Offset(double dx, double dy)
        {
            return new VectorD(X + dx, Y + dy);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y}}}";
    }
}
