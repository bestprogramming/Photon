using Photon;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void CircleAndLine1()
        {
            Big r, a, b, c;
            Big x1, y1, x2, y2;

            r = 1;
            a = 1;
            b = 0;
            c = -1;
            Intersection.CircleAndLine(r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 1, 0));

            r = 1;
            a = 1;
            b = 0;
            c = 1;
            Intersection.CircleAndLine(r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -1, 0));

            r = 1;
            a = 0;
            b = 1;
            c = -1;
            Intersection.CircleAndLine(r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, 1));

            r = 1;
            a = 0;
            b = 1;
            c = 1;
            Intersection.CircleAndLine(r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, -1));

            r = 1;
            a = 1;
            b = -1;
            c = 0;
            Intersection.CircleAndLine(r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -0.7071067811865476, -0.7071067811865476, 0.7071067811865476, 0.7071067811865476));

            r = 1;
            a = 1;
            b = 1;
            c = 0;
            Intersection.CircleAndLine(r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0.7071067811865476, -0.7071067811865476, -0.7071067811865476, 0.7071067811865476));


            var geogebra = G.Execute(
                G.CircleEq(0, 0, r, "c1"),
                G.LineEq(a, b, c, "l1"),
                G.Intersect("c1", "l1", "i1"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

        [Fact]
        public void CircleAndLine2()
        {
            Big cx, cy, r, a, b, c;
            Big px1, py1, px2, py2;
            Big x1, y1, x2, y2;

            cx = 0;
            cy = 0;
            r = 78.2398;
            a = 0;
            b = 1;
            c = 34.1298;
            Intersection.CircleAndLine(cx, cy, r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 70.40328867318628, -34.1298, -70.40328867318628, -34.1298));

            cx = 301.0995;
            cy = 169.6979;
            r = 139.1962;
            px1 = 54.5168;
            py1 = 185.6172;
            px2 = 654.6954;
            py2 = 234.9913;
            a = py2 - py1;
            b = px1 - px2;
            c = px2 * py1 - px1 * py2;
            Intersection.CircleAndLine(cx, cy, r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 164.15557743690883, 194.6367084613941, 432.12667411496363, 216.68153265954436));

            cx = 137.3627;
            cy = -262.3042;
            r = 277.8340;
            px1 = 576.0533;
            py1 = -158.1029;
            px2 = -160.5482;
            py2 = -52.0459;
            a = py2 - py1;
            b = px1 - px2;
            c = px2 * py1 - px1 * py2;
            Intersection.CircleAndLine(cx, cy, r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 381.74050025531596, -130.12544868810073, -59.79909196443677, -66.55190922062707));


            var geogebra = G.Execute(
                G.CircleEq(cx, cy, r, "c1"),
                G.LineEq(a, b, c, "l1"),
                G.Intersect("c1", "l1", "i1"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

        [Fact]
        public void CircleAndLineTangentCase()
        {
            Big cx, cy, r, a, b, c;
            Big x1, y1, x2, y2;

            cx = 0;
            cy = 0;
            r = 1;
            a = 0;
            b = 1;
            c = -1;
            Intersection.CircleAndLine(cx, cy, r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, 1)); //Tangent

            cx = 0;
            cy = 0;
            r = 1 - Epsilon;
            a = 0;
            b = 1;
            c = -1;
            Intersection.CircleAndLine(cx, cy, r, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(!x1.IsReal() && !y1.IsReal() && !x2.IsReal() && !y2.IsReal()); //No tangent

            var geogebra = G.Execute(
                G.CircleEq(cx, cy, r, "c1"),
                G.LineEq(a, b, c, "l1"),
                G.Intersect("c1", "l1", "i1"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }
    }
}