using System.Diagnostics.CodeAnalysis;

namespace Photon
{
    public partial struct Segment : IEquatable<Segment>
    {
        public Big X1;
        public Big Y1;
        public Big X2;
        public Big Y2;

        public Segment(in Big x1, in Big y1, in Big x2, in Big y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public static bool operator ==(in Segment left, in Segment right) => left.X1 == right.X1 && left.Y1 == right.Y1 && left.X2 == right.X2 && left.Y2 == right.Y2;
        public static bool operator !=(in Segment left, in Segment right) => !(left == right);

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Segment segment && Equals(segment);
        public readonly bool Equals(Segment other) => this == other;

        public override readonly int GetHashCode() => HashCode.Combine(X1, Y1, X2, Y2);

        public Segment Offset(in Big dx, in Big dy)
        {
            return new Segment(X1 + dx, Y1 + dy, X2 + dx, Y2 + dy);
        }

        public override readonly string ToString() => $"{{X1={X1},Y1={Y1},{{X2={{X2}},Y2={{Y2}}}}";
    }
}
