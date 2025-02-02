using Photon;
using System.Drawing;
using Xunit.Abstractions;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void TangentLineOfEllipse1()
        {
            Big ea, eb, a, b, c;

            ea = 2;
            eb = 1;
            a = 0;
            b = 1;
            Intersection.TangentLineOfEllipse(ea, eb, a, b, out c);
            Assert.True(E(c, 1));

            ea = 2;
            eb = 1;
            a = 1;
            b = 0;
            Intersection.TangentLineOfEllipse(ea, eb, a, b, out c);
            Assert.True(E(c, 2));

            ea = 2;
            eb = 1;
            a = -1;
            b = 1;
            Intersection.TangentLineOfEllipse(ea, eb, a, b, out c);
            Assert.True(E(c, "2.2360679774997896964091736687312762354406183596115257242708972454"));

            ea = 12.3455423642;
            eb = 3.34256425344;
            a = -2.34589025425;
            b = 3.342352789344;
            Intersection.TangentLineOfEllipse(ea, eb, a, b, out c);
            Assert.True(E(c, "31.0414304689139108331826936738123157157004052605305254659678432392"));

            ea = 12.3455423642;
            eb = 3.34256425344;
            a = -3.34589025425;
            b = 34.342352789344;
            Intersection.TangentLineOfEllipse(ea, eb, a, b, out c);
            Assert.True(E(c, "121.9973255658042296752894261748542836256398280217238012062103887025"));

            var geogebra = G.Execute(
                G.EllipseXy(0, 0, ea, eb, 0, "E"),
                G.LineEq(a, b, 0, "leq"),
                G.LineEq(a, b, c, "leq1"),
                G.LineEq(a, b, -c, "leq2"),
                G.Intersect("leq1", "leq2", "i"),
                G.Intersect("E", "leq1", "i1"),
                G.Intersect("E", "leq2", "i2"),
                "");
        }

        [Fact]
        public void TangentLineOfEllipse2()
        {
            Big ea, eb, rotate, a, b, c;

            ea = 2;
            eb = 1;
            rotate = Big.PiOver4;
            a = 0;
            b = 1;
            Intersection.TangentLineOfEllipse(ea, eb, rotate, a, b, out c);
            Assert.True(E(c, "1.5811388300841896659994467722163592668597775696626084134287524261"));

            ea = 2;
            eb = 1;
            rotate = Big.PiOver4;
            a = -1;
            b = 3;
            Intersection.TangentLineOfEllipse(ea, eb, rotate, a, b, out c);
            Assert.True(E(c, 4));

            ea = 12.3455423642;
            eb = 3.34256425344;
            rotate = 0.9874386;
            a = -3.34589025425;
            b = 34.342352789344;
            Intersection.TangentLineOfEllipse(ea, eb, rotate, a, b, out c);
            Assert.True(E(c, "338.9624472771904505836984653528589340961463748164250887314609535651"));

            var geogebra = G.Execute(
                G.EllipseXy(0, 0, ea, eb, rotate, "E"),
                G.LineEq(a, b, 0, "leq"),
                G.LineEq(a, b, c, "leq1"),
                G.LineEq(a, b, -c, "leq2"),
                G.Intersect("leq1", "leq2", "i"),
                G.Intersect("E", "leq1", "i1"),
                G.Intersect("E", "leq2", "i2"),
                "");
        }

        [Fact]
        public void TangentLineOfEllipse3()
        {
            Big ex, ey, ea, eb, rotate, a, b;
            Big c1, c2;

            ex = 10;
            ey = 20;
            ea = 2;
            eb = 1;
            rotate = Big.PiOver4;
            a = 0;
            b = 1;
            Intersection.TangentLineOfEllipse(ex, ey, ea, eb, rotate, a, b, out c1, out c2);
            Assert.True(E(c1, -18.4188611699158103340005532277836407331402224303373915865712475739) && E(c2, -21.5811388300841896659994467722163592668597775696626084134287524261));

            ex = 13.43758906789345;
            ey = -23.3467895638438;
            ea = 22.34789356936093;
            eb = 4.347893678962478;
            rotate = 1.34536789435;
            a = -1.347897904728939;
            b = 3.8797896834395394;
            Intersection.TangentLineOfEllipse(ex, ey, ea, eb, rotate, a, b, out c1, out c2);
            Assert.True(E(c1, 187.0472909152516268214810717535344087780453313722722326447622666167) && E(c2, 30.3389719656626065365011659424655912219546686277277673552377333833));

            ex = 15.78907289507482;
            ey = -21.5479463786348;
            ea = 24.93467864782994;
            eb = 5.178947578968343;
            rotate = 1.34123478493;
            a = -4.343578942789024;
            b = 1.7437890240743902;
            Intersection.TangentLineOfEllipse(ex, ey, ea, eb, rotate, a, b, out c1, out c2);
            Assert.True(E(c1, 135.9420741233727414938708322917412680012897046745460706718515313332) && E(c2, 76.3702397558565288382798906442587319987102953254539293281484686668));


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.LineEq(a, b, 0, "leq"),
                G.LineEq(a, b, c1, "leq1"),
                G.LineEq(a, b, c2, "leq2"),
                G.Intersect("leq1", "leq2", "i"),
                G.Intersect("E", "leq1", "i1"),
                G.Intersect("E", "leq2", "i2"),
                "");
        }


        [Fact]
        public void EllipseAndTangentLine1()
        {
            Big ea, eb, a, b, c;
            Big x, y;

            ea = 2;
            eb = 1;
            a = 0;
            b = 1;
            Intersection.EllipseAndTangentLine(ea, eb, 0, a, b, out c, out x, out y);
            Assert.True(E(c, 1) && PointsIn(new[] { x, y }, 0, -1));

            ea = 2;
            eb = 1;
            a = 1;
            b = 0;
            Intersection.EllipseAndTangentLine(ea, eb, 0, a, b, out c, out x, out y);
            Assert.True(E(c, 2) && PointsIn(new[] { x, y }, -2, 0));

            ea = 2;
            eb = 1;
            a = -1;
            b = 1;
            Intersection.EllipseAndTangentLine(ea, eb, 0, a, b, out c, out x, out y);
            Assert.True(E(c, 2.23606797749979) && PointsIn(new[] { x, y }, "1.7888543819998317571273389349850209883524946876892205794167177963", "-0.4472135954999579392818347337462552470881236719223051448541794491"));

            ea = 12.3455423642;
            eb = 3.34256425344;
            a = -2.34589025425;
            b = 3.342352789344;
            Intersection.EllipseAndTangentLine(ea, eb, 0, a, b, out c, out x, out y);
            Assert.True(E(c, 31.041430468913909) && PointsIn(new[] { x, y }, "11.5182450210779907933235247937642244938514644807270766801373923170", "-1.2030123632438700500678713947808914385250697822880884770760767276"));

            ea = 12.3455423642;
            eb = 3.34256425344;
            a = -3.34589025425;
            b = 34.342352789344;
            Intersection.EllipseAndTangentLine(ea, eb, 0, a, b, out c, out x, out y);
            Assert.True(E(c, 121.99732556580422) && PointsIn(new[] { x, y }, "4.1800524384192183725311281256654264801712431700754090145910747282", "-3.1451347993652308839122658763613123515512638099155478393771434756"));

            var geogebra = G.Execute(
                G.EllipseXy(0, 0, ea, eb, 0, "E"),
                G.LineEq(a, b, 0, "leq"),
                G.LineEq(a, b, c, "leq1"),
                G.LineEq(a, b, -c, "leq2"),
                G.Intersect("leq1", "leq2", "i"),
                G.Intersect("E", "leq1", "i1"),
                G.Intersect("E", "leq2", "i2"),
                G.Point(x, y, "P1"),
                G.Point(-x, -y, "P2"),
                "");
        }

        [Fact]
        public void EllipseAndTangentLine2()
        {
            Big ea, eb, rotate, a, b, c;
            Big x, y;

            ea = 2;
            eb = 1;
            rotate = Big.PiOver4;
            a = 0;
            b = 1;
            Intersection.EllipseAndTangentLine(ea, eb, rotate, a, b, out c, out x, out y);
            Assert.True(E(c, 1.5811388300841896659994467722163592668597775696626084134287524261) && PointsIn(new[] { x, y }, "-0.9486832980505137995996680633298155601158665417975650480572514558", "-1.5811388300841896659994467722163592668597775696626084134287524260"));

            ea = 2;
            eb = 1;
            rotate = Big.PiOver4;
            a = -1;
            b = 3;
            Intersection.EllipseAndTangentLine(ea, eb, rotate, a, b, out c, out x, out y);
            Assert.True(E(c, 4) && PointsIn(new[] { x, y }, -0.5, -1.5));

            ea = 12.3455423642;
            eb = 3.34256425344;
            rotate = 0.9874386;
            a = -3.34589025425;
            b = 34.342352789344;
            Intersection.EllipseAndTangentLine(ea, eb, rotate, a, b, out c, out x, out y);
            Assert.True(E(c, 338.9624472771904505836984653528589340961463748164250887314609535651) && PointsIn(new[] { x, y }, "-6.0454023862627796327655521746504271365433015864398311601503336157", "-10.4590882985704702196772916213831136132980615204359797773083627013"));

            var geogebra = G.Execute(
                G.EllipseXy(0, 0, ea, eb, rotate, "E"),
                G.LineEq(a, b, 0, "leq"),
                G.LineEq(a, b, c, "leq1"),
                G.LineEq(a, b, -c, "leq2"),
                G.Intersect("leq1", "leq2", "i"),
                G.Intersect("E", "leq1", "i1"),
                G.Intersect("E", "leq2", "i2"),
                G.Point(x, y, "P1"),
                G.Point(-x, -y, "P2"),
                "");
        }

        [Fact]
        public void EllipseAndTangentLine3()
        {
            Big ex, ey, ea, eb, rotate, a, b;
            Big c1, c2, x1, y1, x2, y2;

            ex = 10;
            ey = 20;
            ea = 2;
            eb = 1;
            rotate = Const.PiOver4;
            a = 0;
            b = 1;
            Intersection.EllipseAndTangentLine(ex, ey, ea, eb, rotate, a, b, out c1, out c2, out x1, out y1, out x2, out y2);
            Assert.True(E(c1, -18.418861169915811) && E(c2, -21.581138830084189) && PointsIn(new[] { x1, y1, x2, y2 }, 9.05131670194949, 18.4188611699158, 10.9486832980505, 21.5811388300842));

            ex = 13.43758906789345;
            ey = -23.3467895638438;
            ea = 22.34789356936093;
            eb = 4.347893678962478;
            rotate = 1.34536789435;
            a = -1.347897904728939;
            b = 3.8797896834395394;
            Intersection.EllipseAndTangentLine(ex, ey, ea, eb, rotate, a, b, out c1, out c2, out x1, out y1, out x2, out y2);
            Assert.True(E(c1, 187.04729091525164) && E(c2, 30.338971965662605) && PointsIn(new[] { x1, y1, x2, y2 }, 8.99190910387576, -45.0867520528965, 17.883269031911, -1.60682707479108));

            ex = 15.78907289507482;
            ey = -21.5479463786348;
            ea = 24.93467864782994;
            eb = 5.178947578968343;
            rotate = 1.34123478493;
            a = -4.343578942789024;
            b = 1.7437890240743902;
            Intersection.EllipseAndTangentLine(ex, ey, ea, eb, rotate, a, b, out c1, out c2, out x1, out y1, out x2, out y2);
            Assert.True(E(c1, 135.94207412337275) && E(c2, 76.370239755856531) && PointsIn(new[] { x1, y1, x2, y2 }, 16.4750404306358, -36.9204270347093, 15.1031053595138, -6.17546572256031));


            var geogebra = G.Execute(
                G.EllipseXy(ex, ey, ea, eb, rotate, "E"),
                G.LineEq(a, b, 0, "leq"),
                G.LineEq(a, b, c1, "leq1"),
                G.LineEq(a, b, c2, "leq2"),
                G.Intersect("leq1", "leq2", "i"),
                G.Intersect("E", "leq1", "i1"),
                G.Intersect("E", "leq2", "i2"),
                G.Point(x1, y1, "P1"),
                G.Point(x2, y2, "P2"),
                "");
        }
    }
}