using Photon;
using System.Drawing;
using System.Numerics;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void TwoEllipses1()
        {
            Big ea1, eb1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ea1 = 2;
            eb1 = 1;
            ex2 = 1;
            ey2 = 0;
            ea2 = 2;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ea1, eb1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, "0.5", "0.9682458365518542212948163499455999027082304263228977066468934415", "0.5", "-0.9682458365518542212948163499455999027082304263228977066468934415") && NaNs(x3, y3, x4, y4));

            ea1 = 2;
            eb1 = 1;
            ex2 = 1.34789346;
            ey2 = 0.37893433;
            ea2 = 2.34535634;
            eb2 = 1.98735468;
            rotate2 = -0.4315;
            Intersection.TwoEllipses(ea1, eb1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, "-0.1443510252927418379685930684447835387639998607364954577037032437", "-0.9973919467161510781991656586180791078360600582963344740311003524", "-0.9212073302884564970522383265659346184977168561396287995367940325", "0.8876059168660964121456760026404212168127057974691081083466302429") && NaNs(x3, y3, x4, y4));


            var geogebra = G.Execute(
                G.EllipseXy(0, 0, ea1, eb1, 0, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                !x1.IsNaN && !y1.IsNaN ? G.Point(x1, y1, "P1") : "",
                !x2.IsNaN && !y2.IsNaN ? G.Point(x2, y2, "P2") : "",
                !x3.IsNaN && !y3.IsNaN ? G.Point(x3, y3, "P3") : "",
                !x4.IsNaN && !y4.IsNaN ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipses2()
        {
            Big ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ea1 = 20;
            eb1 = 10;
            rotate1 = Big.PiOver4;
            ex2 = 5;
            ey2 = 5;
            ea2 = 16;
            eb2 = 4;
            rotate2 = Big.Pi / 3;
            Intersection.TwoEllipses(ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(NaNs(x1, y1, x2, y2) && PointsIn(new[] { x3, y3, x4, y4 }, "13.4445943881730547849297781067691326831515131874255577793754225741", "14.7237412589942222240561135793107062322114407265991786479043706921", "7.6951917784334473018698782465850522884187256576212872416360887164", "15.6670822631925344326696743093510281851699370685251617576421640532"));

            ea1 = 21.347890574829;
            eb1 = 10.987483657896;
            rotate1 = 0.785378967542;
            ex2 = 4.93424658293474;
            ey2 = 7.347846528934764;
            ea2 = 46.346728945692394;
            eb2 = 7.3467286572893247;
            rotate2 = 1.1342895428934;
            Intersection.TwoEllipses(ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, "3.7516798853941191266212226931417132796921737184405817401550788351", "-11.2941317424067273601765219174812484653706644999967802366153669991", "-12.5480110338100058691170054148324558655176462821007506054722791288", "-16.5984920147225683443263855056674290476798467271062055137590154742", "15.9367376597902853613450716305796297306119057759206699353776696896", "14.0243120690555726638658377070488782002191378408977027863817145333", "-0.1796639500429233544151623160692087087387617019217201435618359831", "13.7107374081512741184266461566974398262784401842546336834993787558"));


            var geogebra = G.Execute(
                G.EllipseXy(0, 0, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                !x1.IsNaN && !y1.IsNaN ? G.Point(x1, y1, "P1") : "",
                !x2.IsNaN && !y2.IsNaN ? G.Point(x2, y2, "P2") : "",
                !x3.IsNaN && !y3.IsNaN ? G.Point(x3, y3, "P3") : "",
                !x4.IsNaN && !y4.IsNaN ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipses3()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex1 = -3.343289524903;
            ey1 = -6.347894026893;
            ea1 = 23.7428950724931;
            eb1 = 11.3478940572890;
            rotate1 = 0.785579402439;
            ex2 = -1.73842965782938;
            ey2 = -3.423758926789382;
            ea2 = 52.837446286987438;
            eb2 = 9.3436782963458832;
            rotate2 = 1.1476824899268;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 2.4362543578116, -16.4817898822399, -19.7326612458292, -23.4986958901221, 13.8765690487449, 9.95426466707203, -8.43635665076867, 4.38053824409192));

            ex1 = 0;
            ey1 = 0;
            ea1 = 300;
            eb1 = 100;
            rotate1 = Big.Rad(90);
            ex2 = 0;
            ey2 = 0;
            ea2 = 300;
            eb2 = 100;
            rotate2 = Big.Rad(0);
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, -94.8683298050517, 94.8683298050513, 94.8683298050517, -94.8683298050513, 94.8683298050511, 94.8683298050514, -94.8683298050511, -94.8683298050514));

            ex1 = 0;
            ey1 = 0;
            ea1 = 300;
            eb1 = 100;
            rotate1 = Big.Rad(0);
            ex2 = 100;
            ey2 = 100;
            ea2 = 300;
            eb2 = 100;
            rotate2 = Big.Rad(1E-14);
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(NaNs(x1, y1, x2, y2) && PointsIn(new[] { x3, y3, x4, y4 }, 291.867732448956, 23.1258075056715, -191.867732448957, 76.8741924943285));

            ex1 = 0;
            ey1 = 0;
            ea1 = 20;
            eb1 = 10;
            rotate1 = 0;
            ex2 = 20;
            ey2 = 0;
            ea2 = 20;
            eb2 = 10;
            rotate2 = Big.Rad(1E-14);
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 10, 8.66025403784439, 10, -8.66025403784439) && NaNs(x3, y3, x4, y4));

            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesEqualsCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex1 = 0;
            ey1 = 0;
            ea1 = 1;
            eb1 = 1;
            rotate1 = Rand.Double(-Big.Pi2, Big.Pi2);
            ex2 = 0;
            ey2 = 0;
            ea2 = 1;
            eb2 = 1;
            rotate2 = Rand.Double(-Big.Pi2, Big.Pi2);
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(NaNs(x1, y1, x2, y2, x3, y3, x4, y4)); //Equals

            ex1 = 0;
            ey1 = 0;
            ea1 = 2;
            eb1 = 1;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = 4;
            eb2 = 2;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(NaNs(x1, y1, x2, y2, x3, y3, x4, y4)); //Not equal

            ex1 = 0;
            ey1 = 0;
            ea1 = 300;
            eb1 = 100;
            rotate1 = Big.Rad(220);
            ex2 = 0;
            ey2 = 0;
            ea2 = 300;
            eb2 = 100;
            rotate2 = Big.Rad(40);
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            //Assert.True(NaNs(x1, y1, x2, y2, x3, y3, x4, y4)); //Equals //ToDo

            ex1 = 10;
            ey1 = 10;
            ea1 = 300;
            eb1 = 100;
            rotate1 = Big.Rad(40);
            ex2 = 10;
            ey2 = 10;
            ea2 = 300;
            eb2 = 100;
            rotate2 = Big.Rad(220.0001);
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 239.813164653503, 202.836483455268, -219.813164653503, -182.836483455268, 74.2788278186401, -66.6043882180936, -54.2788278186401, 86.6043882180936)); //Not equal


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesEllipse1IsASegmentCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex1 = 0;
            ey1 = 0;
            ea1 = 0;
            eb1 = 1;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = 1;
            eb2 = 0.5;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 0, -0.5, 0, 0.5)); //Ellipse1 is a segment

            ex1 = 0;
            ey1 = 0;
            ea1 = Epsilon;
            eb1 = 1;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = 1;
            eb2 = 0.5;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 8.66025403784439E-09, 0.5, -8.66025403784439E-09, 0.5, -8.66025403784439E-09, -0.5, 8.66025403784439E-09, -0.5)); //Ellipse1 is not a segment


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesEllipse2IsASegmentCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex1 = 0;
            ey1 = 0;
            ea1 = 1;
            eb1 = 0.5;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = 0;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 0, -0.5, 0, 0.5)); //Ellipse2 is a segment

            ex1 = 0;
            ey1 = 0;
            ea1 = 1;
            eb1 = 0.5;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = Epsilon;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 8.660254037844386E-12, -0.5, -8.660254037844387E-12, 0.5)); //Ellipse2 is not a segment


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesEllipse1Ellipse2IsASegmentCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex1 = 0;
            ey1 = 0;
            ea1 = 1;
            eb1 = 0;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = 0;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 0, 0)); //Ellipse1, Ellipse2 is a segment

            ex1 = 0;
            ey1 = 0;
            ea1 = 1;
            eb1 = Epsilon;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = Epsilon;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 1E-08, 1E-08, -1E-08, 1E-08, -1E-08, -1E-08, 1E-08, -1E-08)); //Ellipse1, Ellipse2 is not a segment


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesEllipse1IsACircleCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex1 = 3;
            ey1 = 0;
            ea1 = 1;
            eb1 = 1;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = 2;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 2, 0) && NaNs(x3, y3, x4, y4)); //Ellipse1 is a circle

            ex1 = 3;
            ey1 = 0;
            ea1 = 1 + Epsilon;
            eb1 = 1;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = 2;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 1.99999999333333, 8.16496578886485E-05, 1.99999999333333, -8.16496578886485E-05) && NaNs(x3, y3, x4, y4)); //Ellipse1 is not a circle


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesEllipse2IsACircleCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex1 = 3;
            ey1 = 0;
            ea1 = 2;
            eb1 = 1;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = 1;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 1, 0) && NaNs(x3, y3, x4, y4)); //Ellipse2 is a circle

            ex1 = 3;
            ey1 = 0;
            ea1 = 2;
            eb1 = 1;
            rotate1 = 0;
            ex2 = 0;
            ey2 = 0;
            ea2 = 1 + Epsilon;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 1.00000000666667, 8.16496578886485E-05, 1.00000000666667, -8.16496578886485E-05) && NaNs(x3, y3, x4, y4)); //Ellipse2 is not a circle


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesEllipse1Ellipse2IsACircleCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex1 = 0;
            ey1 = 0;
            ea1 = 1;
            eb1 = 1;
            rotate1 = 0;
            ex2 = 2;
            ey2 = 0;
            ea2 = 1;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 1, 0) && NaNs(x3, y3, x4, y4)); //Ellipse1, Ellipse2 is a circle

            ex1 = 0;
            ey1 = 0;
            ea1 = 1 + Epsilon;
            eb1 = 1;
            rotate1 = 0;
            ex2 = 2;
            ey2 = 0;
            ea2 = 1 + Epsilon;
            eb2 = 1;
            rotate2 = 0;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 1, 0.000141421355176649, 1, -0.000141421355176649) && NaNs(x3, y3, x4, y4)); //Ellipse1, Ellipse2 is not a circle


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesVerticalMirrorCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            //the line joining the mutual intersection points is perpendicular to each other
            //eq1: 0.04750000000000001  x^2 + 0.051961524227066305 xy + 0.017499999999999988 y^2 + 0 x + 0 y - 1 = 0
            //eq2: 0.047499999999999994 x^2 - 0.051961524227066326 xy + 0.017500000000000005 y^2 + 0 x + 0 y - 1 = 0
            ex1 = 0;
            ey1 = 0;
            ea1 = 20;
            eb1 = 4;
            rotate1 = 2 * Const.Pi / 3;
            ex2 = 0;
            ey2 = 0;
            ea2 = 20;
            eb2 = 4;
            rotate2 = Const.Pi / 3;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, -2.55562090372584E-14, 7.55928946018453, 2.55562090372584E-14, -7.55928946018453, -4.58831467741124, -1.55120305476144E-14, 4.58831467741124, 1.55120305476144E-14));

            //eq1: 0.0004750000000000001  x^2 + 0.000519615242270663  xy + 0.00017499999999999986 y^2 + 0.03280384757729338 x + 0.01728460969082652  y - 0.4303460969082651 = 0
            //eq2: 0.00047499999999999994 x^2 - 0.0005196152422706633 xy + 0.00017500000000000005 y^2 - 0.09170384757729334 x + 0.049500754711607656 y + 3.4293924528839232 = 0
            ex1 = -40;
            ey1 = 10;
            ea1 = 200;
            eb1 = 40;
            rotate1 = 2.0943951023931953;
            ex2 = 102;
            ey2 = 10;
            ea2 = 200;
            eb2 = 40;
            rotate2 = 1.0471975511965976;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 61.6327440779736, -119.807585522801, 31.0000000000008, -151.464303884144, 31.0000000000003, -39.3510229799531, 0.367255922027454, -119.8075855228));

            //eq1: 8831.245487304393 x^2 + 2818.894958484704  xy + 348.4345776942294 y^2 + 1614.16815584328 x + 259.23009057028827 y + 72.7643619742923 = 0
            //eq2: 8831.245487304393 x^2 - 2818.8949584847023 xy + 348.4345776942291 y^2 + 1614.16815584328 x - 259.2300905702881  y + 72.7643619742923 = 0
            ex1 = -0.09034769226855151;
            ey1 = -0.0065283938721680795;
            ea1 = 0.09114245046482065;
            eb1 = 0.010506370357139739;
            rotate1 = 1.7312094798935187;
            ex2 = -0.09034769226855151;
            ey2 = 0.0065283938721680795;
            ea2 = 0.09114245046482065;
            eb2 = 0.010506370357139739;
            rotate2 = 1.4103831736962746;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            //ToDo: Digits 128 ok but 64
            //Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, -0.0807764883237805, 3.86743815455937E-17, -0.0919615999844271, -0.0533533672863676, -0.0919615999844269, 0.0533533672863677, -0.102002731001939, 9.75775880913118E-17));


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesHorizontalMirrorCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            //the line joining the mutual intersection points is perpendicular to each other
            //eq1: 0.0004750000000000001  x^2 + 0.000519615242270663  xy + 0.00017499999999999986 y^2 - 0.03028460969082652 x - 0.01919615242270662  y - 0.46465390309173504 = 0
            //eq2: 0.00047499999999999994 x^2 - 0.0005196152422706633 xy + 0.00017500000000000005 y^2 - 0.06146152422706632 x + 0.040196152422706646 y + 1.3171152422706638  = 0
            ex1 = 10;
            ey1 = 40;
            ea1 = 200;
            eb1 = 40;
            rotate1 = 2.0943951023931953;
            ex2 = 10;
            ey2 = -100;
            ea2 = 200;
            eb2 = 40;
            rotate2 = 1.0471975511965976;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, 90.3103847532893, -29.9999999999992, 57.1502719838197, -97.6758927168779, 57.1502719838194, 37.6758927168789, 6.26449305501917, -29.9999999999996));


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesLinearMirrorCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            //the line joining the mutual intersection points is perpendicular to each other
            //eq1: 0.00037709445330007913 x^2 + 0.0005908846518073249  xy + 0.0002729055466999209  y^2 + 0 x + 0 y - 1 = 0
            //eq2: 0.0005548133329356933  x^2 - 0.00038567256581192367 xy + 0.00009518666706430662 y^2 + 0 x + 0 y - 1 = 0
            ex1 = 0;
            ey1 = 0;
            ea1 = 200;
            eb1 = 40;
            rotate1 = 2.2689280275926285;
            ex2 = 0;
            ey2 = 0;
            ea2 = 200;
            eb2 = 40;
            rotate2 = 1.2217304763960306;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, -13.1265683921788, 74.444468676532, 13.1265683921788, -74.444468676532, -45.186078675743, -7.96752482294893, 45.186078675743, 7.96752482294893));

            //eq1:  0.00037709445330007913 x^2 + 0.0005908846518073249  xy + 0.0002729055466999209  y^2 - 0.019359582102148082 x - 0.016825068386070084   y - 0.7349514056285587 = 0
            //eq2:  0.0005548133329356933  x^2 - 0.00038567256581192367 xy + 0.00009518666706430662 y^2 - 0.003382815342475392 x + 0.00004925897554697149 y - 0.9835785130430927 = 0
            //diff: 0.00017771887963561413 x^2 - 0.0009765572176192485  xy - 0.0001777188796356143  y^2 + 0.01597676675967269  x + 0.016874327361617057   y - 0.2486271074145341 = 0
            ex1 = 10;
            ey1 = 20;
            ea1 = 200;
            eb1 = 40;
            rotate1 = 2.2689280275926285;
            ex2 = 10;
            ey2 = 20;
            ea2 = 200;
            eb2 = 40;
            rotate2 = 1.2217304763960306;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, -3.12656839217881, 94.444468676532, 23.1265683921788, -54.444468676532, -35.186078675743, 12.0324751770511, 55.186078675743, 27.9675248229489));


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void TwoEllipsesPerpendicularIntersectionCase()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            ex1 = 0.04772078177965891;
            ey1 = 0.2721384600192165;
            ea1 = 0.6164043191748393;
            eb1 = 0.11497021453096996;
            rotate1 = -0.06172489010596997;
            ex2 = -0.05166377923537534;
            ey2 = 0.33593749829512154;
            ea2 = 0.5227397409679911;
            eb2 = 0.09750012823305143;
            rotate2 = 0.06172489010596998;
            Intersection.TwoEllipses(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2, x3, y3, x4, y4 }, -0.536790859769371, 0.342965230752605, -0.548412377964803, 0.336199500756532, 0.445894451573512, 0.336199500756511, -0.536790859769331, 0.271038560278804));


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Intersect("E1", "E2", "i"),
                x1.IsReal() && y1.IsReal() ? G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.Point(x4, y4, "P4") : "",
                "");
        }
    }
}