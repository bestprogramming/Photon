using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public struct LineD : IEquatable<LineD> //ax+by=c
    {
        public double A;
        public double B;
        public double C;

        public LineD(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public LineD(double x1, double y1, double x2, double y2)
        {
            Conversion.SegmentToLineD(x1, y1, x2, y2, out A, out B, out C);
        }

        public LineD(in Point p1, in Point p2)
            : this(p1.X, p1.Y, p2.X, p2.Y)
        {
        }

        public static bool operator ==(in LineD left, in LineD right) => left.A == right.A && left.B == right.B && left.C == right.C;
        public static bool operator !=(in LineD left, in LineD right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is LineD linearEq && Equals(linearEq);
        public readonly bool Equals(LineD other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(A, B, C);

        public override readonly string ToString() => $"{{A={A},B={B},C={C}}}";
    }
}
