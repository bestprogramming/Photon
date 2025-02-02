using Photon;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void SegmentAndLine1()
        {
            Big x1, y1, x2, y2, a, b, c;
            Big x, y;

            x1 = -2.80154262348579326;
            y1 = -5.74894252789473921;
            x2 = 8.620378905742900234;
            y2 = 32.52517804723890752;
            a = -26.74124235623758497;
            b = 34.411895742904752893;
            c = -480.0226789735789332;
            Intersection.SegmentAndLine(x1, y1, x2, y2, a, b, c, out x, out y);
            Assert.True(PointsIn(new[] { x, y }, 4.0058700991181055, 17.06225738123604));


            var geogebra = G.Execute(
                G.Point(x1, y1, "P1"),
                G.Point(x2, y2, "P2"),
                G.SegmentXy("P1", "P2", "s1"),
                G.LineEq(a, b, c, "leq"),
                G.Intersect("s1", "leq"),
                x.IsReal() && y.IsReal() ? G.Point(x, y, "P") : "",
                "");
        }

        [Fact]
        public void SegmentAndLineParallelCase()
        {
            Big x1, y1, x2, y2, a, b, c;
            Big x, y;

            x1 = -1;
            y1 = 0;
            x2 = 0;
            y2 = 1;
            a = -1;
            b = 1;
            c = -1;
            Intersection.SegmentAndLine(x1, y1, x2, y2, a, b, c, out x, out y);
            Assert.True(!x.IsReal() && !y.IsReal());


            var geogebra = G.Execute(
                G.Point(x1, y1, "P1"),
                G.Point(x2, y2, "P2"),
                G.SegmentXy("P1", "P2", "s1"),
                G.LineEq(a, b, c, "leq"),
                G.Intersect("s1", "leq"),
                x.IsReal() && y.IsReal() ? G.Point(x, y, "P") : "",
                "");
        }

    }
}