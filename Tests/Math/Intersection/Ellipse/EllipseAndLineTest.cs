using Photon;
using System.Drawing;
using System.Numerics;
using Xunit.Abstractions;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void EllipseAndLine1()
        {
            Big ex, ey, ea, eb, rotate, a, b, c;
            Big x1, y1, x2, y2;

            ex = 0;
            ey = 0;
            ea = 32.342562434546;
            eb = 7.9783478356783;
            rotate = 0;
            a = 63.4047345426344;
            b = 78.2285343893567;
            c = -1402.1675738943;
            Intersection.EllipseAndLine(ex, ey, ea, eb, rotate, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 27.3626291892746, -4.25359709008515, 13.1167694702188, 7.29276461628005));

            ex = 8.780345675673432354;
            ey = 5.343589903463534561;
            ea = 12.34789573894323456;
            eb = 2.343578934935634534;
            a = 3.3438957346780343456;
            b = -4.934352464235423642;
            c = 2.7637856836478356207;
            rotate = Const.PiOver4;
            Intersection.EllipseAndLine(ex, ey, ea, eb, rotate, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 17.2585469917237, 12.2558264320066, 3.27914688342497, 2.78231258509068));

            ex = -2;
            ey = 0;
            ea = 6;
            eb = 20;
            a = 1;
            b = 0;
            c = 0;
            rotate = 0;
            Intersection.EllipseAndLine(ex, ey, ea, eb, rotate, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, -18.8561808316413, 0, 18.8561808316413));


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.LineEq(a, b, c, "leq"),
                G.Intersect("E", "leq"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

        [Fact]
        public void EllipseAndLineEllipseIsASegmentCase()
        {
            Big ex, ey, ea, eb, rotate, a, b, c;
            Big x1, y1, x2, y2;

            ex = 0;
            ey = 0;
            ea = 1;
            eb = 0;
            rotate = 0;
            a = 1;
            b = 0;
            c = 0;
            Intersection.EllipseAndLine(ex, ey, ea, eb, rotate, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, 0)); //Ellipse is a segment

            ex = 0;
            ey = 0;
            ea = 1;
            eb = Epsilon;
            rotate = 0;
            a = 1;
            b = 0;
            c = 0;
            Intersection.EllipseAndLine(ex, ey, ea, eb, rotate, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, -1E-10, 0, 1E-10)); //Ellipse is not a segment


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.LineEq(a, b, c, "leq"),
                G.Intersect("E", "leq"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

        [Fact]
        public void EllipseAndLineEllipseIsACircleCase()
        {
            Big ex, ey, ea, eb, rotate, a, b, c;
            Big x1, y1, x2, y2;

            ex = 0;
            ey = 0;
            ea = 1;
            eb = 1;
            rotate = 0;
            a = 1;
            b = 0;
            c = 0;
            Intersection.EllipseAndLine(ex, ey, ea, eb, rotate, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, -1, 0, 1)); //Ellipse is a circle

            ex = 0;
            ey = 0;
            ea = 1;
            eb = 1 + Epsilon;
            rotate = 0;
            a = 1;
            b = 0;
            c = 0;
            Intersection.EllipseAndLine(ex, ey, ea, eb, rotate, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, -1.00000000001, 0, 1.00000000001)); //Ellipse is not a circle


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.LineEq(a, b, c, "leq"),
                G.Intersect("E", "leq"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

        [Fact]
        public void EllipseAndLineTangentCase()
        {
            Big ex, ey, ea, eb, rotate, a, b, c;
            Big x1, y1, x2, y2;

            ex = 0;
            ey = 0;
            ea = 2;
            eb = 1;
            rotate = 0;
            a = 0;
            b = 1;
            c = -1;
            Intersection.EllipseAndLine(ex, ey, ea, eb, rotate, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, 1)); //Tangent

            ex = 0;
            ey = 0;
            ea = 2;
            eb = 1;
            rotate = 0;
            a = 0;
            b = 1;
            c = -1 - Epsilon;
            Intersection.EllipseAndLine(ex, ey, ea, eb, rotate, a, b, c, out x1, out y1, out x2, out y2);
            Assert.True(!x1.IsReal() && !y1.IsReal() && !x2.IsReal() && !y2.IsReal()); //No tangent


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.LineEq(a, b, c, "leq"),
                G.Intersect("E", "leq"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }
    }
}