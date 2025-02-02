using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct Vector3D : IEquatable<Vector3D>
    {
        public static readonly Vector3D Zero = new(0.0, 0.0, 0.0);
        public static readonly Vector3D One = new(1.0, 1.0, 1.0);
        public static readonly Vector3D UnitX = new(1.0, 0.0, 0.0);
        public static readonly Vector3D NegativeUnitX = new(-1.0, 0.0, 0.0);
        public static readonly Vector3D UnitY = new(0.0, 1.0, 0.0);
        public static readonly Vector3D NegativeUnitY = new(0.0, -1.0, 0.0);
        public static readonly Vector3D UnitZ = new(0.0, 0.0, 1.0);
        public static readonly Vector3D NegativeUnitZ = new(0.0, 0.0, -1.0);

        public double X;
        public double Y;
        public double Z;

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D(double value) : this(value, value, value) { }


        public static Vector3D operator +(in Vector3D left, in Vector3D right)
        {
            return new Vector3D(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        public static Vector3D operator -(in Vector3D left, in Vector3D right)
        {
            return new Vector3D(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        public static Vector3D operator *(in Vector3D left, in Vector3D right)
        {
            return new Vector3D(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        public static Vector3D operator *(in Vector3D left, double right)
        {
            return left * new Vector3D(right);
        }

        public static Vector3D operator *(double left, in Vector3D right)
        {
            return new Vector3D(left) * right;
        }

        public static Vector3D operator /(in Vector3D left, in Vector3D right)
        {
            return new Vector3D(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        public static Vector3D operator /(in Vector3D value1, double value2)
        {
            var invDiv = 1.0 / value2;

            return new Vector3D(
                value1.X * invDiv,
                value1.Y * invDiv,
                value1.Z * invDiv);
        }

        public static Vector3D operator -(in Vector3D value)
        {
            return Zero - value;
        }

        public static bool operator ==(in Vector3D left, in Vector3D right) => left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        public static bool operator !=(in Vector3D left, in Vector3D right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Vector3D vector3 && Equals(vector3);
        public readonly bool Equals(Vector3D other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        public Vector3D Offset(double dx, double dy, double dz)
        {
            return new Vector3D(X + dx, Y + dy, Z + dz);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y},Z={Z}}}";
    }
}
