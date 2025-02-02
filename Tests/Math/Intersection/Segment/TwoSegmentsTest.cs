using Photon;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void TwoSegments()
        {
            Point p1, p2, p3, p4;
            Big x, y;

            p1 = new Point(-31.9587082898525, 0.0274802065471);
            p2 = new Point(164.7619419590947, 0);
            p3 = new Point(-31.9350454919155, -0.0106524695413);
            p4 = new Point(164.5279061285006, 0.0255153851385);
            Intersection.TwoSegments(p1, p2, p3, p4, out x, out y);
            Assert.True(PointsIn(new[] { x, y }, 85.825774510042208, 0.011026713173179175));

            p1 = new Point(-9.087484476389, -1.633020169763);
            p2 = new Point(2.1212180511857, 4.7355608118135);
            p3 = new Point(-4.5275804935802, -5.632489026193);
            p4 = new Point(2.1212180511857, 4.7355608118135);
            Intersection.TwoSegments(p1, p2, p3, p4, out x, out y);
            Assert.True(PointsIn(new[] { x, y }, p2.X, p2.Y));

            p1 = new Point(-2.2, -3.74);
            p2 = new Point(13.22, 0.54);
            p3 = new Point(-1.82, -7.26);
            p4 = new Point(13.0128237414714, 0.464939890374);
            Intersection.TwoSegments(p1, p2, p3, p4, out x, out y);
            Assert.True(PointsIn(new[] { x, y }, 13.08499947106699, 0.50252903606788035));

            p1 = new Point(-2.8993756097561, -2.0824585365854);
            p2 = new Point(18, 2);
            p3 = new Point(-2.3799609756098, -4.0042926829268);
            p4 = new Point(744.2019014294693, 143.8553933122345);
            Intersection.TwoSegments(p1, p2, p3, p4, out x, out y);
            Assert.True(PointsIn(new[] { x, y }, 744.2019839384584, 143.8554096530452));


            var geogebra = G.Execute(
                G.Point(p1, "P1"),
                G.Point(p2, "P2"),
                G.Point(p3, "P3"),
                G.Point(p4, "P4"),
                G.Line(p1, p2, "l1"),
                G.Line(p3, p4, "l2"),
                G.Intersect("l1", "l2"),
                x.IsReal() && y.IsReal() ? G.Point(x, y, "P") : "",
                "");
        }

        [Fact]
        public void TwoSegmentsParallelCase()
        {
            Big sx1, sy1, sx2, sy2, sx3, sy3, sx4, sy4;
            Big x, y;

            sx1 = 0;
            sy1 = 0;
            sx2 = 1;
            sy2 = 0;
            sx3 = 0;
            sy3 = 0;
            sx4 = 1;
            sy4 = 0;
            Intersection.TwoSegments(sx1, sy1, sx2, sy2, sx3, sy3, sx4, sy4, out x, out y);
            Assert.True(!x.IsReal() && !y.IsReal());


            var geogebra = G.Execute(
                G.Point(sx1, sy1, "P1"),
                G.Point(sx2, sy2, "P2"),
                G.Point(sx3, sy3, "P3"),
                G.Point(sx4, sy4, "P4"),
                G.Line(sx1, sy1, sx2, sy2, "l1"),
                G.Line(sx3, sy3, sx4, sy4, "l2"),
                G.Intersect("l1", "l2"),
                x.IsReal() && y.IsReal() ? G.Point(x, y, "P") : "",
                "");
        }
    }
}