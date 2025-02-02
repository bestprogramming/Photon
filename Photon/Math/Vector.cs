using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct Vector : IEquatable<Vector>
    {
        public static readonly Vector Zero = new(Big.Zero, Big.Zero);
        public static readonly Vector One = new(Big.One, Big.One);
        public static readonly Vector UnitX = new(Big.One, Big.Zero);
        public static readonly Vector NegativeUnitX = new(Big.MinusOne, Big.Zero);
        public static readonly Vector UnitY = new(Big.Zero, Big.One);
        public static readonly Vector NegativeUnitY = new(Big.Zero, Big.MinusOne);

        public Big X;
        public Big Y;

        public Vector(in Big x, in Big y)
        {
            X = x;
            Y = y;
        }

        public Vector(in Big value) : this(value, value) { }


        public static Vector operator +(in Vector left, in Vector right)
        {
            return new Vector(left.X + right.X, left.Y + right.Y);
        }

        public static Vector operator -(in Vector left, in Vector right)
        {
            return new Vector(left.X - right.X, left.Y - right.Y);
        }

        public static Vector operator *(in Vector left, in Vector right)
        {
            return new Vector(left.X * right.X, left.Y * right.Y);
        }

        public static Vector operator *(in Vector left, in Big right)
        {
            return left * new Vector(right);
        }

        public static Vector operator *(in Big left, in Vector right)
        {
            return new Vector(left) * right;
        }

        public static Vector operator /(in Vector left, in Vector right)
        {
            return new Vector(left.X / right.X, left.Y / right.Y);
        }

        public static Vector operator /(in Vector value1, in Big value2)
        {
            var invDiv = Big.One / value2;

            return new Vector(
                value1.X * invDiv,
                value1.Y * invDiv);
        }

        public static Vector operator -(in Vector value)
        {
            return Zero - value;
        }

        public static bool operator ==(in Vector left, in Vector right) => left.X == right.X && left.Y == right.Y;
        public static bool operator !=(in Vector left, in Vector right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Vector vector && Equals(vector);
        public readonly bool Equals(Vector other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        public Vector Offset(in Big dx, in Big dy)
        {
            return new Vector(X + dx, Y + dy);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y}}}";
    }
}
