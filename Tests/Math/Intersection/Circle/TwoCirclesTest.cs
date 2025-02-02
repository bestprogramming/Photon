using Photon;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void TwoCircles1()
        {
            Big cx1, cy1, r1, cx2, cy2, r2;
            Big x1, y1, x2, y2;

            cx1 = -1;
            cy1 = 0;
            r1 = 1;
            cx2 = 1;
            cy2 = 0;
            r2 = 1;
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, 0));

            cx1 = 0;
            cy1 = -1;
            r1 = 1;
            cx2 = 0;
            cy2 = 1;
            r2 = 1;
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, 0));

            cx1 = 0;
            cy1 = 0;
            r1 = 2;
            cx2 = 1;
            cy2 = 0;
            r2 = 1;
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 2, 0));

            cx1 = -0.5;
            cy1 = -0.5;
            r1 = 1;
            cx2 = 0.5;
            cy2 = 0.5;
            r2 = 1;
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0.5, -0.5, -0.5, 0.5));


            var geogebra = G.Execute(
                G.CircleEq(cx1, cy1, r1, "c1"),
                G.CircleEq(cx2, cy2, r2, "c2"),
                G.Intersect("c1", "c2", "i1"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

        [Fact]
        public void TwoCircles2()
        {
            Big cx1, cy1, r1, cx2, cy2, r2;
            Big x1, y1, x2, y2;

            cx1 = 35.6564579395019;
            cy1 = 24.0983280577615;
            r1 = 12.34873345;
            cx2 = 16.8392127458563;
            cy2 = 16.2108600141977;
            r2 = 8.542683312;
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 23.598357859158735, 21.434976734413958, 25.30320481435842, 17.367698997572873));


            var geogebra = G.Execute(
                G.CircleEq(cx1, cy1, r1, "c1"),
                G.CircleEq(cx2, cy2, r2, "c2"),
                G.Intersect("c1", "c2", "i1"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

        [Fact]
        public void TwoCirclesSameCenterCase()
        {
            Big cx1, cy1, r1, cx2, cy2, r2;
            Big x1, y1, x2, y2;

            cx1 = 0;
            cy1 = 0;
            r1 = 1;
            cx2 = 0;
            cy2 = 0;
            r2 = 1;
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(!x1.IsReal() && !y1.IsReal() && !x2.IsReal() && !y2.IsReal()); //Same

            cx1 = Epsilon;
            cy1 = 0;
            r1 = 1;
            cx2 = 0;
            cy2 = 0;
            r2 = 1;
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 5E-11, 1, 5E-11, -1)); //Not same


            var geogebra = G.Execute(
                G.CircleEq(cx1, cy1, r1, "c1"),
                G.CircleEq(cx2, cy2, r2, "c2"),
                G.Intersect("c1", "c2", "i1"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

        [Fact]
        public void TwoCirclesTangentCase()
        {
            Big cx1, cy1, r1, cx2, cy2, r2;
            Big x1, y1, x2, y2;

            cx1 = -1;
            cy1 = 0;
            r1 = 1;
            cx2 = 1;
            cy2 = 0;
            r2 = 1;
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, 0)); //Tangent

            cx1 = -Big.Pow(10, -50);
            cy1 = 0;
            r1 = Big.Pow(10, -50);
            cx2 = Big.Pow(10, -50);
            cy2 = 0;
            r2 = Big.Pow(10, -50);
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(!x1.IsReal() && !y1.IsReal() && !x2.IsReal() && !y2.IsReal()); //Tangent but ignorable

            cx1 = -Big.Pow(10, 50);
            cy1 = 0;
            r1 = Big.Pow(10, 50);
            cx2 = Big.Pow(10, 50);
            cy2 = 0;
            r2 = Big.Pow(10, 50);
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0, 0)); //Tangent

            cx1 = -1;
            cy1 = 0;
            r1 = 1;
            cx2 = 1 + Epsilon;
            cy2 = 0;
            r2 = 1;
            Intersection.TwoCircles(cx1, cy1, r1, cx2, cy2, r2, out x1, out y1, out x2, out y2);
            Assert.True(!x1.IsReal() && !y1.IsReal() && !x2.IsReal() && !y2.IsReal()); //No tangent


            var geogebra = G.Execute(
                G.CircleEq(cx1, cy1, r1, "c1"),
                G.CircleEq(cx2, cy2, r2, "c2"),
                G.Intersect("c1", "c2", "i1"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }
    }
}