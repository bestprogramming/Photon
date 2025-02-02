using Photon;
using System;
using System.Numerics;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void EllipseAndTangentEllipse1()
        {
            Big ea1, eb1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            Big GetRatio(Big x, Big y)
            {
                var c = Big.Cos(rotate2);
                var s = Big.Sin(rotate2);
                var x2 = c * (x - ex2) + s * (y - ey2);
                x2 *= x2;
                var y2 = c * (y - ey2) - s * (x - ex2);
                y2 *= y2;
                return Big.Sqrt(x2 / (ea2 * ea2) + y2 / (eb2 * eb2));
            }

            ea1 = 20;
            eb1 = 10;
            ex2 = 25;
            ey2 = 25;
            ea2 = 16;
            eb2 = 5;
            rotate2 = Big.Pi / 6;
            Intersection.EllipseAndTangentEllipse(ea1, eb1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, "13.0640569825413620858561569067309488390241201434610987361449703453", "-7.5718296196644619395209358224067070418166986213204038822576934524", "4.9219678801772581741779676196555638298511213202320440660560755361", "9.6924485062664040381972947445206461398746822300897878014508363022") && NaNs(x3, y3, x4, y4));

            ea1 = 20;
            eb1 = 10;
            ex2 = 40;
            ey2 = 0;
            ea2 = 16;
            eb2 = 5;
            rotate2 = Big.Pi / 6;
            Intersection.EllipseAndTangentEllipse(ea1, eb1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] {  x1, y1, x2, y2 }, "18.0097752701057986811013151614068192368759784063329896215715232352", "-4.3487927842185584572682749352786271366772500346074334522066937978", "-16.8122525261094132126297122033475683961443226870085961912171650108", "5.4163679019784017576499102494368657939855386323750008281864781806") && NaNs(x3, y3, x4, y4));

            ea1 = 20;
            eb1 = 10;
            ex2 = 50;
            ey2 = 0;
            ea2 = 16;
            eb2 = 8;
            rotate2 = 0;
            Intersection.EllipseAndTangentEllipse(ea1, eb1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -20, 0, 20, 0) && NaNs(x3, y3, x4, y4));


            var geogebra = G.Execute(
                G.EllipseXy(0, 0, ea1, eb1, 0, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                !x1.IsNaN && !y1.IsNaN ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x1, y1), eb2 * GetRatio(x1, y1), rotate2, "TE1") + "," + G.Point(x1, y1, "P1") : "",
                !x2.IsNaN && !y2.IsNaN ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x2, y2), eb2 * GetRatio(x2, y2), rotate2, "TE2") + "," + G.Point(x2, y2, "P2") : "",
                !x3.IsNaN && !y3.IsNaN ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x3, y3), eb2 * GetRatio(x3, y3), rotate2, "TE3") + "," + G.Point(x3, y3, "P3") : "",
                !x4.IsNaN && !y4.IsNaN ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x4, y4), eb2 * GetRatio(x4, y4), rotate2, "TE4") + "," + G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void EllipseAndTangentEllipse2()
        {
            Big ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            Big GetRatio(Big x, Big y)
            {
                var c = Big.Cos(rotate2);
                var s = Big.Sin(rotate2);
                var x2 = c * (x - ex2) + s * (y - ey2);
                x2 *= x2;
                var y2 = c * (y - ey2) - s * (x - ex2);
                y2 *= y2;
                return Big.Sqrt(x2 / (ea2 * ea2) + y2 / (eb2 * eb2));
            }

            ea1 = 20;
            eb1 = 10;
            rotate1 = Big.Rad(15);
            ex2 = 25;
            ey2 = 25;
            ea2 = 16;
            eb2 = 5;
            rotate2 = Big.Pi / 6;
            Intersection.EllipseAndTangentEllipse(ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, "6.3246434124713854938615541707432204986604993891917844887640326456", "-8.4572507468863468828214407913942777045254206732915664465959950771", "7.6623344511915679459639323922566848309198293644668529330700433093", "10.9476227491976022253799208039656949053675921837787824360498548085") && NaNs(x3, y3, x4, y4));


            var geogebra = G.Execute(
                G.EllipseXy(0, 0, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                !x1.IsNaN && !y1.IsNaN ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x1, y1), eb2 * GetRatio(x1, y1), rotate2, "TE1") + "," + G.Point(x1, y1, "P1") : "",
                !x2.IsNaN && !y2.IsNaN ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x2, y2), eb2 * GetRatio(x2, y2), rotate2, "TE2") + "," + G.Point(x2, y2, "P2") : "",
                !x3.IsNaN && !y3.IsNaN ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x3, y3), eb2 * GetRatio(x3, y3), rotate2, "TE3") + "," + G.Point(x3, y3, "P3") : "",
                !x4.IsNaN && !y4.IsNaN ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x4, y4), eb2 * GetRatio(x4, y4), rotate2, "TE4") + "," + G.Point(x4, y4, "P4") : "",
                "");
        }

        [Fact]
        public void EllipseAndTangentEllipse3()
        {
            Big ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2;
            Big x1, y1, x2, y2, x3, y3, x4, y4;

            Big GetRatio(Big x, Big y)
            {
                var c = Big.Cos(rotate2);
                var s = Big.Sin(rotate2);
                var x2 = c * (x - ex2) + s * (y - ey2);
                x2 *= x2;
                var y2 = c * (y - ey2) - s * (x - ex2);
                y2 *= y2;
                return Big.Sqrt(x2 / (ea2 * ea2) + y2 / (eb2 * eb2));
            }

            ex1 = -4;
            ey1 = -7;
            ea1 = 20;
            eb1 = 10;
            rotate1 = Big.Rad(30);
            ex2 = 25;
            ey2 = 25;
            ea2 = 16;
            eb2 = 5;
            rotate2 = Const.Pi / 6;
            Intersection.EllipseAndTangentEllipse(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -6.19946950623691, -18.8902633632818, 4.0475084545803, 6.14393340574482) && NaNs(x3, y3, x4, y4));

            ex1 = 0;
            ey1 = 0;
            ea1 = 300;
            eb1 = 100;
            rotate1 = Big.Rad(0);
            ex2 = 373;
            ey2 = -115;
            ea2 = 100;
            eb2 = 50;
            rotate2 = Conversion.Rad(20);
            Intersection.EllipseAndTangentEllipse(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, 263.082670849374406117776, -48.0595791107936798681442, -280.18656306655865427, 35.7390074427700384612048160739) && NaNs(x3, y3, x4, y4));

            ex1 = 98;
            ey1 = 138;
            ea1 = 300;
            eb1 = 100;
            rotate1 = Big.Rad(-22);
            ex2 = 595;
            ey2 = 78;
            ea2 = 100;
            eb2 = 50;
            rotate2 = Big.Rad(-9);
            Intersection.EllipseAndTangentEllipse(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -179.920011660961, 250.948899208645, 369.319870541703, 69.6500082796921) && NaNs(x3, y3, x4, y4));

            ex1 = 1.001;
            ey1 = 0;
            ea1 = 300;
            eb1 = 100;
            rotate1 = Big.Rad(0);
            ex2 = 489.83934;
            ey2 = 174;
            ea2 = 300;
            eb2 = 150;
            rotate2 = Big.Rad(45);
            Intersection.EllipseAndTangentEllipse(ex1, ey1, ea1, eb1, rotate1, ex2, ey2, ea2, eb2, rotate2, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);
            Assert.True(PointsIn(new[] { x1, y1, x2, y2 }, -295.644305268188, 14.9129431566594, 297.646202144635, 14.9131710785715) && NaNs(x3, y3, x4, y4));


            var geogebra = G.Execute(
                G.EllipseXy(ex1, ey1, ea1, eb1, rotate1, "E1"),
                G.EllipseXy(ex2, ey2, ea2, eb2, rotate2, "E2"),
                G.Point(ex2, ey2, "CP2"),
                x1.IsReal() && y1.IsReal() ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x1, y1), eb2 * GetRatio(x1, y1), rotate2, "TE1") + "," + G.Point(x1, y1, "P1") : "",
                x2.IsReal() && y2.IsReal() ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x2, y2), eb2 * GetRatio(x2, y2), rotate2, "TE2") + "," + G.Point(x2, y2, "P2") : "",
                x3.IsReal() && y3.IsReal() ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x3, y3), eb2 * GetRatio(x3, y3), rotate2, "TE3") + "," + G.Point(x3, y3, "P3") : "",
                x4.IsReal() && y4.IsReal() ? G.EllipseXy(ex2, ey2, ea2 * GetRatio(x4, y4), eb2 * GetRatio(x4, y4), rotate2, "TE4") + "," + G.Point(x4, y4, "P4") : "",
                "");
        }
    }
}