using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photon
{
    public struct Pixel3 : IEquatable<Pixel3>
    {
        public int X;
        public int Y;
        public int Z;

        public Pixel3(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static bool operator ==(in Pixel3 left, in Pixel3 right) => left.X == right.X && left.Y == right.Y;

        public static bool operator !=(in Pixel3 left, in Pixel3 right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Pixel3 pixel && Equals(pixel);

        public readonly bool Equals(Pixel3 other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        public Pixel3 Offset(int dx, int dy, int dz)
        {
            return new Pixel3
            {
                X = unchecked(X + dx),
                Y = unchecked(Y + dy),
                Z = unchecked(Y + dz)
            };
        }

        public Pixel3 Offset(in Pixel3 p) => Offset(p.X, p.Y, p.Z);

        public override readonly string ToString() => $"{{X={X},Y={Y},Y={Z}}}";
    }
}
