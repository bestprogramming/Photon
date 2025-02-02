using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct Circle3 : IEquatable<Circle3>
    {
        public Big X;
        public Big Y;
        public Big Z;
        public Big R;
        public Big Ax;
        public Big Bx;
        public Big Ay;
        public Big By;
        public Big Az;
        public Big Bz;

        public Circle3(in Big x, in Big y, in Big z, in Big r, in Big ax, in Big bx, in Big ay, in Big by, in Big az, in Big bz)
        {
            X = x;
            Y = y;
            Z = z;
            R = r;
            Ax = ax;
            Bx = bx;
            Ay = ay;
            By = by;
            Az = az;
            Bz = bz;
        }

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Circle3 circle3 && Equals(circle3);

        public readonly bool Equals(Circle3 other) => this == other;

        public static bool operator ==(in Circle3 left, in Circle3 right) =>
            left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.Ax == right.Ax && left.Bx == right.Bx && left.Ay == right.Ay && left.By == right.By && left.Bz == right.Bz;

        public static bool operator !=(in Circle3 left, in Circle3 right) => !(left == right);

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, Ax, Bx, Ay, By, Bz);

        public Circle3 Offset(in Big dx, in Big dy, in Big dz)
        {
            return new Circle3(X + dx, Y + dy, Z + dz, R, Ax, Bx, Ay, By, Az, Bz);
        }

        public override readonly string ToString() => $"{{X={X},Y={Y},Z={Z},R={R},Ax={Ax},Bx={Bx},Ay={Ay},By={By},Bz={Bz}}}";
    }
}
