using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public struct Line : IEquatable<Line> //ax+by=c
    {
        public Big A;
        public Big B;
        public Big C;

        public Line(in Big a, in Big b, in Big c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Line(in Big x1, in Big y1, in Big x2, in Big y2)
        {
            Conversion.SegmentToLine(x1, y1, x2, y2, out A, out B, out C);
        }

        public Line(in Point p1, in Point p2)
            : this(p1.X, p1.Y, p2.X, p2.Y)
        {
        }

        public static bool operator ==(in Line left, in Line right) => left.A == right.A && left.B == right.B && left.C == right.C;
        public static bool operator !=(in Line left, in Line right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Line linearEq && Equals(linearEq);
        public readonly bool Equals(Line other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(A, B, C);

        public override readonly string ToString() => $"{{A={A},B={B},C={C}}}";
    }
}
