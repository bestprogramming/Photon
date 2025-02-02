using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photon
{
    public struct Rgb : IEquatable<Rgb>
    {
        private byte r;
        private byte g;
        private byte b;

        public Rgb(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public byte R
        {
            readonly get => r;
            set => r = value;
        }

        public byte G
        {
            readonly get => g;
            set => g = value;
        }

        public byte B
        {
            readonly get => b;
            set => b = value;
        }

        public static bool operator ==(Rgb left, Rgb right) => left.R == right.R && left.G == right.G && left.B == right.B;

        public static bool operator !=(Rgb left, Rgb right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Rgb rgb && Equals(rgb);

        public readonly bool Equals(Rgb other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(R, G, B);

        public override readonly string ToString() => $"{{R={R},G={G},B={B}}}";


        public Color ToColor()
        {
            return Color.FromArgb(R, G, B);
        }

        public Brush ToBrush()
        {
            return new SolidBrush(ToColor());
        }

        public Pen ToPen(int width = 1)
        {
            return new Pen(ToColor(), width);
        }
    }
}
