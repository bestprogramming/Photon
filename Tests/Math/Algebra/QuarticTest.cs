using Photon;
using System.Numerics;
using Xunit.Abstractions;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class AlgebraTest
    {
        [Fact]
        public void Quartic1()
        {
            Big a, b, c, d, e;
            Big x1, x2, x3, x4;

            a = 1;
            b = -10;
            c = 35;
            d = -50;
            e = 24;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(ValuesIn(new[] { x1, x2, x3, x4 }, 1, 2, 3, 4));

            a = 1;
            b = 18;
            c = 9;
            d = -648;
            e = 1296;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(ValuesIn(new[] { x1, x2, x3, x4 }, -12, 3));

            a = 1;
            b = 7;
            c = 12;
            d = 5;
            e = 3;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(ValuesIn(new[] { x1, x2 }, "-2.1040338695158069333093372238989255819924734983302748396534178960", "-4.5937429414897399336613121602153822386899020977415454389733648896") && x3.IsNaN && x4.IsNaN);

            a = 1 * Big.Pow(10, 42);
            b = -7 * Big.Pow(10, 42);
            c = -31 * Big.Pow(10, 42);
            d = 7 * Big.Pow(10, 42);
            e = 30 * Big.Pow(10, 42);
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(ValuesIn(new[] { x1, x2 }, -3, -1, 1, 10));


            var geogebra = G.Execute(
                G.Quartic(a, b, c, d, e, "f"),
                G.Intersect("f", "xAxis", "i"),
                !x1.IsNaN ? G.Point(x1, 0, "P1") : "",
                !x2.IsNaN ? G.Point(x2, 0, "P2") : "",
                !x3.IsNaN ? G.Point(x3, 0, "P3") : "",
                !x4.IsNaN ? G.Point(x4, 0, "P4") : "",
                "");
        }

        [Fact]
        public void Quartic2()
        {
            Big a, b, c, d, e;
            Big x1, x2, x3, x4;

            a = Big.Parse("4.386490844928604") * Big.Pow(10, -22);
            b = 0.000033510321638291124;
            c = 640000000000;
            d = -0.0016755160819145565;
            e = -48000000000000;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            //Assert.True(x1.IsNaN && x2.IsNaN && ValuesIn(new[] { x3, x4 }, "8.66025403784438581313876220966032013712301522594564095832214200040041196564444102987918228027236271101938630795422746524110641596943574697831812276147976007751059292", "-8.66025403784438712213570120539860138712301522596807026726332891038343307559216216354410213285142451171290109621144985292036108728050989725441326707205027013427550264"));
            //-38,197,186,342,054,874.690175570133528206201854938011541 +627,652,704.49454481004398198570436526i
            //-38,197,186,342,054,874.690175570133528206201854938011541 -627,652,704.49454481004398198570436526i
            //-8.660254037844387122
            // 8.660254037844385813


            var geogebra = G.Execute(
                G.Quartic(a, b, c, d, e, "f"),
                G.Intersect("f", "xAxis", "i"),
                !x1.IsNaN ? G.Point(x1, 0, "P1") : "",
                !x2.IsNaN ? G.Point(x2, 0, "P2") : "",
                !x3.IsNaN ? G.Point(x3, 0, "P3") : "",
                !x4.IsNaN ? G.Point(x4, 0, "P4") : "",
                "");
        }

        [Fact]
        public void QuarticDepressedCase()
        {
            Big a, b, c, d, e;
            Big x1, x2, x3, x4;

            a = 1;
            b = 4;
            c = -9;
            d = -16;
            e = 20;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(ValuesIn(new[] { x1, x2, x3, x4 }, -5, -2, 1, 2));

            //x -> x - 1; https://www.maa.org/press/periodicals/convergence/descartes-method-for-constructing-roots-of-polynomials-with-simple-curves-depressed-quartics-and
            a = 1;
            b = 0;
            c = -15;
            d = 10;
            e = 24;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(ValuesIn(new[] { x1, x2, x3, x4 }, -4, -1, 2, 3));

            a = Big.Parse("7.0183853518857649") * Big.Pow(10, -13);
            b = Big.Parse("201061.92982974678");
            c = 1.44 * Big.Pow(10, 22);
            d = Big.Parse("-1563815009.7869191");
            e = Big.Parse("-1.2800000000000002") * Big.Pow(10, 26);
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            ////Assert.True(ValuesIn(new[] { x1, x2, x3, x4 }, -4, -1, 2, 3));

            a = 1;
            b = -10;
            c = -84;
            d = 410;
            e = 2275;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(ValuesIn(new[] { x1, x2, x3, x4 }, -5, -5, 13, 7));

            var geogebra = G.Execute(
                G.Quartic(a, b, c, d, e, "f"),
                G.Intersect("f", "xAxis", "i"),
                !x1.IsNaN ? G.Point(x1, 0, "P1") : "",
                !x2.IsNaN ? G.Point(x2, 0, "P2") : "",
                !x3.IsNaN ? G.Point(x3, 0, "P3") : "",
                !x4.IsNaN ? G.Point(x4, 0, "P4") : "",
                "");
        }

        [Fact]
        public void QuarticSymmetricCase()
        {
            Big a, b, c, d, e;
            Big x1, x2, x3, x4;

            a = 2;
            b = -5;
            c = 4;
            d = -5;
            e = 2;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(x1.IsNaN && x2.IsNaN && ValuesIn(new[] { x3, x4 }, 2, 0.5));

            a = 1;
            b = -10;
            c = 23;
            d = -10;
            e = 1;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(ValuesIn(new[] { x1, x2, x3, x4 }, (3 + Math.Sqrt(5)) / 2, (3 - Math.Sqrt(5)) / 2, (7 + 3 * Math.Sqrt(5)) / 2, (7 - 3 * Math.Sqrt(5)) / 2));


            var geogebra = G.Execute(
                G.Quartic(a, b, c, d, e, "f"),
                G.Intersect("f", "xAxis", "i"),
                !x1.IsNaN ? G.Point(x1, 0, "P1") : "",
                !x2.IsNaN ? G.Point(x2, 0, "P2") : "",
                !x3.IsNaN ? G.Point(x3, 0, "P3") : "",
                !x4.IsNaN ? G.Point(x4, 0, "P4") : "",
                "");
        }

        [Fact]
        public void QuarticTripleRootsEqualCase()
        {
            Big a, b, c, d, e;
            Big x1, x2, x3, x4;

            a = 1;
            b = 7;
            c = 9;
            d = -27;
            e = -54;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(ValuesIn(new[] { x1, x2, x3, x4 }, -3, 2));


            var geogebra = G.Execute(
                G.Quartic(a, b, c, d, e, "f"),
                G.Intersect("f", "xAxis", "i"),
                !x1.IsNaN ? G.Point(x1, 0, "P1") : "",
                !x2.IsNaN ? G.Point(x2, 0, "P2") : "",
                !x3.IsNaN ? G.Point(x3, 0, "P3") : "",
                !x4.IsNaN ? G.Point(x4, 0, "P4") : "",
                "");
        }

        [Fact]
        public void QuarticFourRootsEqualCase()
        {
            Big a, b, c, d, e;
            Big x1, x2, x3, x4;

            a = 1;
            b = -8;
            c = 24;
            d = -32;
            e = 16;
            Algebra.Quartic(a, b, c, d, e, out x1, out x2, out x3, out x4);
            Assert.True(ValuesIn(new[] { x1, x2, x3, x4 }, 2));


            var geogebra = G.Execute(
                G.Quartic(a, b, c, d, e, "f"),
                G.Intersect("f", "xAxis", "i"),
                !x1.IsNaN ? G.Point(x1, 0, "P1") : "",
                !x2.IsNaN ? G.Point(x2, 0, "P2") : "",
                !x3.IsNaN ? G.Point(x3, 0, "P3") : "",
                !x4.IsNaN ? G.Point(x4, 0, "P4") : "",
                "");
        }
    }
}