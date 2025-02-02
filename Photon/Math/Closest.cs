using System.Numerics;

namespace Photon
{
    public static partial class Closest
    {
        public static void PointOfLineAndPoint(in Big a, in Big b, in Big c, in Big x0, in Big y0, out Big x, out Big y)
        {
            var diff = b * x0 - a * y0;
            var d = a * a + b * b;

            x = (b * diff - a * c) / d;
            y = (-a * diff - b * c) / d;
        }

        public static void PointOfLineAndPoint(in Big a, in Big b, in Big c, in Point p, out Big x, out Big y)
        {
            PointOfLineAndPoint(a, b, c, p.X, p.Y, out x, out y);
        }


        public static void ClosestPoint(this Line l, in Big x0, in Big y0, out Big x, out Big y)
        {
            PointOfLineAndPoint(l.A, l.B, l.C, x0, y0, out x, out y);
        }

        public static void ClosestPoint(this Line l, in Point p, out Big x, out Big y)
        {
            PointOfLineAndPoint(l.A, l.B, l.C, p.X, p.Y, out x, out y);
        }


        public static void PointOfSegmentAndPoint(in Big x1, in Big y1, in Big x2, in Big y2, in Big x0, in Big y0, out Big x, out Big y)
        {
            var dx = x1 - x2;
            var dy = y1 - y2;
            var d = dy * dy + dx * dx;

            var k = (dy * (x0 - x1) - dx * (y0 - y1)) / d;
            x = x0 - k * dy;
            y = y0 + k * dx;
        }


        public static void NearestOrder(in Big x, in Big y, ref Point[] points, in Big referenceLength, out Big[] lengths)
        {
            var px = x;
            var py = y;
            var rl = referenceLength; //ToDo: remove px, py, rl
            var values = points.Select(p => new
            {
                p,
                length = p.IsReal() ? Dimension.LengthOfSegment(px, py, p.X, p.Y) : Big.NaN
            }).OrderBy(p => p.length.IsNaN).ThenBy(p => Big.Abs(p.length - rl));

            points = values.Select(p => p.p).ToArray();
            lengths = values.Select(p => p.length).ToArray();
        }
    }
}
