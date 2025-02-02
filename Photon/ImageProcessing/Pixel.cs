using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photon
{
    public struct Pixel : IEquatable<Pixel>
    {
        public int X;
        public int Y;

        public Pixel(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(in Pixel left, in Pixel right) => left.X == right.X && left.Y == right.Y;

        public static bool operator !=(in Pixel left, in Pixel right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Pixel pixel && Equals(pixel);

        public readonly bool Equals(Pixel other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        public Pixel Offset(int dx, int dy)
        {
            return new Pixel
            {
                X = unchecked(X + dx),
                Y = unchecked(Y + dy)
            };
        }

        public Pixel Offset(in Pixel p) => Offset(p.X, p.Y);

        public override readonly string ToString() => $"{{X={X},Y={Y}}}";
    }
}
