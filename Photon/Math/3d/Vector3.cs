using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct Vector3 : IEquatable<Vector3>
    {
        public static readonly Vector3 Zero = new(Big.Zero, Big.Zero, Big.Zero); 
        public static readonly Vector3 One = new(Big.One, Big.One, Big.One);
        public static readonly Vector3 UnitX = new(Big.One, Big.Zero, Big.Zero);
        public static readonly Vector3 NegativeUnitX = new(Big.MinusOne, Big.Zero, Big.Zero);
        public static readonly Vector3 UnitY = new(Big.Zero, Big.One, Big.Zero);
        public static readonly Vector3 NegativeUnitY = new(Big.Zero, Big.MinusOne, Big.Zero);
        public static readonly Vector3 UnitZ = new(Big.Zero, Big.Zero, Big.One);
        public static readonly Vector3 NegativeUnitZ = new(Big.Zero, Big.Zero, Big.MinusOne);

        public Big X;
        public Big Y;
        public Big Z;

        public Vector3(in Big x, in Big y, in Big z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3(in Big value) : this(value, value, value) { }


        public static Vector3 operator +(in Vector3 left, in Vector3 right)
        {
            return new Vector3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        public static Vector3 operator -(in Vector3 left, in Vector3 right)
        {
            return new Vector3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        public static Vector3 operator *(in Vector3 left, in Vector3 right)
        {
            return new Vector3(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        public static Vector3 operator *(in Vector3 left, in Big right)
        {
            return left * new Vector3(right);
        }

        public static Vector3 operator *(in Big left, in Vector3 right)
        {
            return new Vector3(left) * right;
        }

        public static Vector3 operator /(in Vector3 left, in Vector3 right)
        {
            return new Vector3(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        public static Vector3 operator /(in Vector3 value1, in Big value2)
        {
            var invDiv = Big.One / value2;

            return new Vector3(
                value1.X * invDiv,
                value1.Y * invDiv,
                value1.Z * invDiv);
        }

        public static Vector3 operator -(in Vector3 value)
        {
            return Zero - value;
        }

        public static bool operator ==(in Vector3 left, in Vector3 right) => left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        public static bool operator !=(in Vector3 left, in Vector3 right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Vector3 vector3 && Equals(vector3);
        public readonly bool Equals(Vector3 other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        public Vector3 Offset(in Big dx, in Big dy, in Big dz)
        {
            return new Vector3(X + dx, Y + dy, Z + dz);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y},Z={Z}}}";
    }
}
