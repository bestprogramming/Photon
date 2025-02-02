using Photon;
using Xunit.Abstractions;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void TwoLines1()
        {
            Big a1, b1, c1, a2, b2, c2;
            Big x, y;

            a1 = -1;
            b1 = 1;
            c1 = 30;
            a2 = 1;
            b2 = 1;
            c2 = 20;
            Intersection.TwoLines(a1, b1, c1, a2, b2, c2, out x, out y);
            Assert.True(PointsIn(new[] { x, y }, 5, -25));

            a1 = -20;
            b1 = 80;
            c1 = -2600;
            a2 = -60;
            b2 = Big.One * 240 + 1E-8;
            c2 = 9000;
            Intersection.TwoLines(a1, b1, c1, a2, b2, c2, out x, out y);
            Assert.True(PointsIn(new[] { x, y }, -6720000000130, -1680000000000));

            a1 = -20;
            b1 = 80;
            c1 = -2600;
            a2 = -60;
            b2 = 241;
            c2 = 9000;
            Intersection.TwoLines(a1, b1, c1, a2, b2, c2, out x, out y);
            Assert.True(PointsIn(new[] { x, y }, -67330, -16800));


            var geogebra = G.Execute(
                G.LineEq(a1, b1, c1, "eq1"),
                G.LineEq(a2, b2, c2, "eq2"),
                G.Intersect("eq1", "eq2"),
                x.IsReal() && y.IsReal() ? G.Point(x, y, "P") : "",
                "");
        }

        [Fact]
        public void TwoLinesParallelCase()
        {
            Big a1, b1, c1, a2, b2, c2;
            Big x, y;

            a1 = -1;
            b1 = 1;
            c1 = -1;
            a2 = -1;
            b2 = 1;
            c2 = 1;
            Intersection.TwoLines(a1, b1, c1, a2, b2, c2, out x, out y);
            Assert.True(!x.IsReal() && !y.IsReal());


            var geogebra = G.Execute(
                G.LineEq(a1, b1, c1, "eq1"),
                G.LineEq(a2, b2, c2, "eq2"),
                G.Intersect("eq1", "eq2"),
                x.IsReal() && y.IsReal() ? G.Point(x, y, "P") : "",
                "");
        }
    }
}