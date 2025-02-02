using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct SegmentD : IEquatable<SegmentD>
    {
        public double X1;
        public double Y1;
        public double X2;
        public double Y2;

        public SegmentD(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public static bool operator ==(in SegmentD left, in SegmentD right) => left.X1 == right.X1 && left.Y1 == right.Y1 && left.X2 == right.X2 && left.Y2 == right.Y2;
        public static bool operator !=(in SegmentD left, in SegmentD right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is SegmentD line && Equals(line);
        public readonly bool Equals(SegmentD other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X1, Y1, X2, Y2);

        public SegmentD Offset(double dx, double dy)
        {
            return new SegmentD(X1 + dx, Y1 + dy, X2 + dx, Y2 + dy);
        }

        public override readonly string ToString() => $"{{X1={X1},Y1={Y1},{{X2={{X2}},Y2={{Y2}}}}";
    }
}
