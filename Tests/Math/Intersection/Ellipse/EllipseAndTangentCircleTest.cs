using Photon;
using System;
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
        public void EllipseAndTangentCircle1()
        {
            Big ea, eb, cx, cy;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ea = 2;
            eb = 1;
            cx = 3;
            cy = 3;
            Intersection.EllipseAndTangentCircle(ea, eb, 0, cx, cy, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, "-1.8939306562568091205216364772605424554705032281197904182935017210", "-0.3213357548152136196315956883615008410797164636201050258856366692", "1.5494591478021603451338594798469073118967978700579997473163097154", "0.6322927228136116667676929196430416339619151781733364160177890320") && NaNs(x3, y3, x4, y4));

            ea = 2;
            eb = 1;
            cx = 2;
            cy = 0;
            Intersection.EllipseAndTangentCircle(ea, eb, 0, cx, cy, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 2, 0, -2, -0) && NaNs(x3, y3, x4, y4));

            ea = 2;
            eb = 1;
            cx = 0;
            cy = 0;
            Intersection.EllipseAndTangentCircle(ea, eb, 0, cx, cy, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, -2, 0, 2, 0, 0, -1, 0, 1));

            ea = 2;
            eb = 1;
            cx = Epsilon;
            cy = 0;
            Intersection.EllipseAndTangentCircle(ea, eb, 0, cx, cy, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, "0.0000000133333333333333333333333333333333333333333333333333333333", "-0.9999999999999999777777777777777775308641975308641920438957475994", "2.0000000000000000000000000000000000000000000000000000000000000000", "0.0000000000000000000000000000000000000000000000000000000000000000", "-2.0000000000000000000000000000000000000000000000000000000000000000", "0.0000000000000000000000000000000000000000000000000000000000000000", "0.0000000133333333333333333333333333333333333333333333333333333333", "0.9999999999999999777777777777777775308641975308641920438957475994"));

            ea = 1;
            eb = 2;
            cx = Epsilon;
            cy = 0;
            Intersection.EllipseAndTangentCircle(ea, eb, 0, cx, cy, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, "-0.0000000033333333333333333333333333333333333333333333333333333333","-1.9999999999999999888888888888888888580246913580246911865569272976","1.0000000000000000000000000000000000000000000000000000000000000000","0.0000000000000000000000000000000000000000000000000000000000000000","-1.0000000000000000000000000000000000000000000000000000000000000000","0.0000000000000000000000000000000000000000000000000000000000000000","-0.0000000033333333333333333333333333333333333333333333333333333333","1.9999999999999999888888888888888888580246913580246911865569272976"));

            ea = 2;
            eb = 1;
            cx = 0;
            cy = Epsilon;
            Intersection.EllipseAndTangentCircle(ea, eb, 0, cx, cy, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, "-1.9999999999999999888888888888888888580246913580246911865569272976","-0.0000000033333333333333333333333333333333333333333333333333333333","0.0000000000000000000000000000000000000000000000000000000000000000","1.0000000000000000000000000000000000000000000000000000000000000000","0.0000000000000000000000000000000000000000000000000000000000000000","-1.0000000000000000000000000000000000000000000000000000000000000000","1.9999999999999999888888888888888888580246913580246911865569272976","-0.0000000033333333333333333333333333333333333333333333333333333333"));

            ea = 2;
            eb = 1;
            cx = 0;
            cy = -Epsilon;
            Intersection.EllipseAndTangentCircle(ea, eb, 0, cx, cy, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, "-1.9999999999999999888888888888888888580246913580246911865569272976","0.0000000033333333333333333333333333333333333333333333333333333333","0.0000000000000000000000000000000000000000000000000000000000000000","1.0000000000000000000000000000000000000000000000000000000000000000","0.0000000000000000000000000000000000000000000000000000000000000000","-1.0000000000000000000000000000000000000000000000000000000000000000","1.9999999999999999888888888888888888580246913580246911865569272976","0.0000000033333333333333333333333333333333333333333333333333333333"));

            ea = 1;
            eb = 0.5;
            cx = Epsilon / 2;
            cy = Epsilon;
            Intersection.EllipseAndTangentCircle(ea, eb, 0, cx, cy, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            //Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, -1, 0, 1, 0, 0, -0.5, 0, 0.5));


            var geogebra = G.Execute(
                G.EllipseXy(0, 0, ea, eb, 0, "E"),
                G.Point(cx, cy, "CP"),
                G.SetColor("CP", Color.Red),
                !x1.IsNaN && !y1.IsNaN ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x1, y1), "C1") + "," + G.Intersect("E", "C1", "i1") + "," + G.Point(x1, y1, "P1") : "",
                !x2.IsNaN && !y2.IsNaN ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x2, y2), "C2") + "," + G.Intersect("E", "C2", "i2") + "," + G.Point(x2, y2, "P2") : "",
                !x3.IsNaN && !y3.IsNaN ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x3, y3), "C3") + "," + G.Intersect("E", "C3", "i3") + "," + G.Point(x3, y3, "P3") : "",
                !x4.IsNaN && !y4.IsNaN ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x4, y4), "C4") + "," + G.Intersect("E", "C4", "i4") + "," + G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void EllipseAndTangentCircle3()
        {
            Big ea, eb, rotate, cx, cy;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ea = 30.435243526;
            eb = 8.34342562435;
            rotate = 0.8783467863;
            cx = 32.3457892345;
            cy = 11.3415789349;
            Intersection.EllipseAndTangentCircle(ea, eb, rotate, cx, cy, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, "19.4832757892644432277951985425626888913201303885547414007287704525", "15.7886909186977177241619480927958619287055590587433904966582950264", "-19.9012712078288343576550945231580824240340003107346287587068639009", "-22.8954451627201806639126652759002842620278638903951433520705478781") && NaNs(x3, y3, x4, y4));


            var geogebra = G.Execute(
                G.EllipseXy(0, 0, ea, eb, rotate, "E"),
                G.Point(cx, cy, "CP"),
                G.SetColor("CP", Color.Red),
                !x1.IsNaN && !y1.IsNaN ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x1, y1), "C1") + "," + G.Intersect("E", "C1", "i1") + "," + G.Point(x1, y1, "P1") : "",
                !x2.IsNaN && !y2.IsNaN ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x2, y2), "C2") + "," + G.Intersect("E", "C2", "i2") + "," + G.Point(x2, y2, "P2") : "",
                !x3.IsNaN && !y3.IsNaN ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x3, y3), "C3") + "," + G.Intersect("E", "C3", "i3") + "," + G.Point(x3, y3, "P3") : "",
                !x4.IsNaN && !y4.IsNaN ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x4, y4), "C4") + "," + G.Intersect("E", "C4", "i4") + "," + G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void EllipseAndTangentCircle4()
        {
            Big ex, ey, ea, eb, rotate, cx, cy;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex = 3.4352434543;
            ey = 4.3423542345;
            ea = 19.3478954289;
            eb = 9.93476852644;
            rotate = 0.9134789564;
            cx = 34.98673586784;
            cy = 12.342789452678;
            Intersection.EllipseAndTangentCircle(ex, ey, ea, eb, rotate, cx, cy, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 17.6199863304673, 13.1246896404648, -9.99290686153103, -8.93689124596307) && NaNs(x3, y3, x4, y4));


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.Point(cx, cy, "CP"),
                G.SetColor("CP", Color.Red),
                x1.IsReal() && y1.IsReal() ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x1, y1), "C1") + "," + G.Intersect("E", "C1", "i1") + "," + G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x2, y2), "C2") + "," + G.Intersect("E", "C2", "i2") + "," + G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x3, y3), "C3") + "," + G.Intersect("E", "C3", "i3") + "," + G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Circle(cx, cy, Dimension.LengthOfSegment(cx, cy, x4, y4), "C4") + "," + G.Intersect("E", "C4", "i4") + "," + G.Point(x4, y4, "P4") : "",
                "");
        }
    }
}