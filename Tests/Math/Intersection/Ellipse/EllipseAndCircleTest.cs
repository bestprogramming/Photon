using Photon;
using System.Drawing;
using System.Numerics;
using Xunit.Abstractions;
using static System.Windows.Forms.AxHost;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void Try()
        {
            Big ex, ey, ea, eb, rotate, cx, cy, r;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex = 1.5;
            ey = 0;
            ea = Big.Parse("3.3911649915626340695322781633129845525978741619616441163751097899");
            eb = Big.Parse("2.3979157616563597707987190320813469599983535209520646732426545560");
            rotate = Big.PiOver2;
            cx = 0;
            cy = 0;
            r = Big.Parse("2.6457513110645905905016157536392604257102591830824501803683344581");
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);

            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.Circle(cx, cy, r, "C"),
                G.Intersect("E", "C", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void EllipseAndCircle1()
        {
            Big ex, ey, ea, eb, rotate, cx, cy, r;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex = 0;
            ey = 0;
            ea = 18.123;
            eb = 4.689;
            rotate = 0;
            cx = -3.3435;
            cy = -2.3435;
            r = 9.345634;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 5.76264576830146, -4.44563798510007, -12.6334796938106, -3.36190667247551, -10.3416212923118, 3.85062408981664, 2.87893732562533, 4.62945838153505));

            ex = -3.421534687893;
            ey = -7.367489353255;
            ea = 19.13435622334;
            eb = 6.683425244233;
            rotate = 0.83432564234;
            cx = -5.4325442343435;
            cy = -8.3342544234435;
            r = 16.34432456245634;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 9.05768647863964, -0.773159311792532, -14.0299179746692, -22.2346900343181, -17.1436370565551, -19.7354495499403, 2.45080113499265, 5.98321082675628));

            ex = 0;
            ey = 0;
            ea = 300;
            eb = 100;
            rotate = 0;
            cx = 0;
            cy = 0;
            r = 200;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 183.711730708738, -79.0569415042095, -183.711730708738, -79.0569415042095, 183.711730708738, 79.0569415042095, -183.711730708738, 79.0569415042095));

            ex = 0;
            ey = -0;
            ea = 400;
            eb = 200;
            rotate = 0;
            cx = -0;
            cy = 57;
            r = 150;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -49.9655972399647, 198.43351474263, 49.9655972399647, 198.43351474263) && NaNs(x3, y3, x4, y4));

            ex = 1.5;
            ey = 0;
            ea = Big.Parse("3.3911649915626340695322781633129845525978741619616441163751097899");
            eb = Big.Parse("2.3979157616563597707987190320813469599983535209520646732426545560");
            rotate = Big.PiOver2;
            cx = 0;
            cy = 0;
            r = Big.Parse("2.6457513110645905905016157536392604257102591830824501803683344581");
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, "0.0000000000000000000000000000000000000000000000000000000000000007", "-2.6457513110645905905016157536392604257102591830824501803683344580", "0.0000000000000000000000000000000000000000000000000000000000000007", "2.6457513110645905905016157536392604257102591830824501803683344580") && NaNs(x3, y3, x4, y4));


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.Circle(cx, cy, r, "C"),
                G.Intersect("E", "C", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void EllipseAndCircleEllipseIsASegmentCase()
        {
            Big ex, ey, ea, eb, rotate, cx, cy, r;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex = 0;
            ey = 0;
            ea = 1;
            eb = 0;
            rotate = 0;
            cx = 1;
            cy = 0;
            r = 1;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(NaNs(x1, y1, x2, y2) && PointsIn(new[] { x3, y3, x4, y4 }, 0, 0)); //Ellipse is a segment

            ex = 0;
            ey = 0;
            ea = 1;
            eb = Epsilon;
            rotate = 0;
            cx = 1;
            cy = 0;
            r = 1;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 5E-21, -1E-10, 5E-21, 1E-10) && NaNs(x3, y3, x4, y4)); //Ellipse is not a segment


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.Circle(cx, cy, r, "C"),
                G.Intersect("E", "C", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void EllipseAndCircleEllipseIsACircleCase()
        {
            Big ex, ey, ea, eb, rotate, cx, cy, r;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex = 0;
            ey = 0;
            ea = 1;
            eb = 1;
            rotate = 0;
            cx = 1;
            cy = 0;
            r = 1;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0.5, -0.866025403784439, 0.5, 0.866025403784439) && NaNs(x3, y3, x4, y4)); //Ellipse is a circle

            ex = 0;
            ey = 0;
            ea = 1;
            eb = 1 + Epsilon;
            rotate = 0;
            cx = 1;
            cy = 0;
            r = 1;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 0.500000000075, -0.86602540382774, 0.500000000075, 0.86602540382774) && NaNs(x3, y3, x4, y4)); //Ellipse is not a circle


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.Circle(cx, cy, r, "C"),
                G.Intersect("E", "C", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void EllipseAndCircleTangentCase()
        {
            Big ex, ey, ea, eb, rotate, cx, cy, r;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex = 0;
            ey = 0;
            ea = 1;
            eb = 0.5;
            rotate = 0;
            cx = 2;
            cy = 0;
            r = 1;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 1, 0) && NaNs(x3, y3, x4, y4)); //Tangent

            ex = 0;
            ey = 0;
            ea = 1;
            eb = 0.5;
            rotate = 0;
            cx = 2 + Epsilon;
            cy = 0;
            r = 1;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(NaNs(x1, y1, x2, y2, x3, y3, x4, y4)); //No tangent

            ex = 0;
            ey = 0;
            ea = 20;
            eb = 30;
            rotate = 0;
            cx = 10;
            cy = 0;
            r = 10;
            Intersection.EllipseAndCircle(ex, ey, ea, eb, rotate, cx, cy, r, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 20, 0) && NaNs(x3, y3, x4, y4)); //Tangent


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.Circle(cx, cy, r, "C"),
                G.Intersect("E", "C", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }
    }
}