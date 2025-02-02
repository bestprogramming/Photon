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
        public void EllipseAndSegment1()
        {
            Big ex, ey, ea, eb, rotate, sx1, sy1, sx2, sy2;
            Big x1, y1, x2, y2;

            ex = -12.3476893569834576;
            ey = -5.78936258567289467;
            ea = 17.34678967896371842;
            eb = 5.427894028347378959;
            rotate = -1.13467890548934;
            sx1 = -13.6404358396730229;
            sy1 = 20.71944192605463416;
            sx2 = 3.343435610239438518;
            sy2 = -42.2425345449811304;
            Intersection.EllipseAndSegment(ex, ey, ea, eb, rotate, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -3.54880189717032, -16.691888035786, -6.61386688796017, -5.32919311658368));

            ex = -12.3476893569834576;
            ey = -5.78936258567289467;
            ea = 17.34678967896371842;
            eb = 5.427894028347378959;
            rotate = -1.13467890548934;
            sx1 = -13.8110990728880839;
            sy1 = -4.64185546767089341;
            sx2 = 36.53789318697448463;
            sy2 = 18.76157057779145925;
            Intersection.EllipseAndSegment(ex, ey, ea, eb, rotate, sx1, sy1, sx2, sy2, out x1, out y1, out x2, out y2);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -17.9472987852778, -6.56446086121207, -8.14806084070124, -2.00953870201309));


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.SegmentXy(sx1, sy1, sx2, sy2, "s"),
                G.Intersect("E", "s", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                "");
        }

    }
}