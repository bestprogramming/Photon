using Photon;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void CircleAndSegment1()
        {
            Big r;
            Big sx1, sy1, sx2, sy2;
            Big x1, y1, x2, y2;

            r = 1;
            sx1 = 1;
            sy1 = -1;
            sx2 = 1;
            sy2 = 1;
            Intersection.CircleAndSegment(r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 1, 0));

            r = 1;
            sx1 = -1;
            sy1 = -1;
            sx2 = -1;
            sy2 = 1;
            Intersection.CircleAndSegment(r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -1, 0));

            r = 1;
            sx1 = -1;
            sy1 = 1;
            sx2 = 1;
            sy2 = 1;
            Intersection.CircleAndSegment(r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, 1));

            r = 1;
            sx1 = -1;
            sy1 = -1;
            sx2 = 1;
            sy2 = -1;
            Intersection.CircleAndSegment(r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, -1));

            r = 1;
            sx1 = -1;
            sy1 = -1;
            sx2 = 1;
            sy2 = 1;
            Intersection.CircleAndSegment(r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -0.70710678118654757, -0.70710678118654757, 0.70710678118654757, 0.70710678118654757));

            r = 1;
            sx1 = -1;
            sy1 = 1;
            sx2 = 1;
            sy2 = -1;
            Intersection.CircleAndSegment(r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0.70710678118654757, -0.70710678118654757, -0.70710678118654757, 0.70710678118654757));

            r = 10;
            sx1 = 0;
            sy1 = 0;
            sx2 = 1;
            sy2 = 0;
            Intersection.CircleAndSegment(r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -10, 0, 10, 0));


            var geogebra = G.Execute(
                G.CircleEq(0, 0, r, "c1"),
                G.SegmentXy(sx1, sy1, sx2, sy2, "s1"),
                G.Intersect("c1", "s1", "i1"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

        [Fact]
        public void CircleAndSegment2()
        {
            Big cx, cy, r;
            Big sx1, sy1, sx2, sy2;
            Big x1, y1, x2, y2;

            cx = 301.0995;
            cy = 169.6979;
            r = 139.1962;
            sx1 = 54.5168;
            sy1 = 185.6172;
            sx2 = 654.6954;
            sy2 = 234.9913;
            Intersection.CircleAndSegment(cx, cy, r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 164.15557743690889, 194.63670846139414, 432.12667411496363, 216.68153265954439));

            cx = 137.3627;
            cy = -262.3042;
            r = 277.8340;
            sx1 = 576.0533;
            sy1 = -158.1029;
            sx2 = -160.5482;
            sy2 = -52.0459;
            Intersection.CircleAndSegment(cx, cy, r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 381.74050025531591, -130.12544868810073, -59.799091964436734, -66.551909220627067));

            cx = 0;
            cy = -0;
            r = 100;
            sx1 = 5;
            sy1 = 5;
            sx2 = 54;
            sy2 = 15;
            Intersection.CircleAndSegment(cx, cy, r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -98.685581364967462, -16.160322727544379, 97.126205115467258, 23.801266350095361));

            var geogebra = G.Execute(
                G.CircleEq(cx, cy, r, "c1"),
                G.SegmentXy(sx1, sy1, sx2, sy2, "s1"),
                G.Intersect("c1", "s1", "i1"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

        [Fact]
        public void CircleAndSegmentTangentCase()
        {
            Big cx, cy, r;
            Big sx1, sy1, sx2, sy2;
            Big x1, y1, x2, y2;

            cx = 0;
            cy = 0;
            r = 1;
            sx1 = 0;
            sy1 = 1;
            sx2 = 1;
            sy2 = 1;
            Intersection.CircleAndSegment(cx, cy, r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, 1)); //Tangent

            cx = 0;
            cy = 0;
            r = 1 - Epsilon;
            sx1 = 0;
            sy1 = 1;
            sx2 = 1;
            sy2 = 1;
            Intersection.CircleAndSegment(cx, cy, r, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(!x1.IsReal() && !y1.IsReal() && !x2.IsReal() && !y2.IsReal()); //No tangent


            var geogebra = G.Execute(
                G.CircleEq(cx, cy, r, "c1"),
                G.SegmentXy(sx1, sy1, sx2, sy2, "s1"),
                G.Intersect("c1", "s1", "i1"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }
    }
}