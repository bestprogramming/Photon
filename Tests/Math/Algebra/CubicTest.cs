using Photon;
using System.Numerics;
using Xunit.Abstractions;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class AlgebraTest
    {
        [Fact]
        public void Cubic1()
        {
            Big a, b, c, d;
            Big x1, x2, x3;

            a = 1;
            b = 1;
            c = 1;
            d = 1;
            Algebra.Cubic(a, b, c, d, out x1, out x2, out x3);
            Assert.True(E(x1, -1) && NaNs(x2, x3));

            a = 1;
            b = 0;
            c = 0;
            d = 0;
            Algebra.Cubic(a, b, c, d, out x1, out x2, out x3);
            Assert.True(ValuesIn(new[] { x1, x2, x3 }, 0));

            a = 1;
            b = -3;
            c = -25;
            d = -21;
            Algebra.Cubic(a, b, c, d, out x1, out x2, out x3);
            Assert.True(ValuesIn(new[] { x1, x2, x3 }, -1, -3, 7));

            a = 1;
            b = 9;
            c = -36;
            d = -324;
            Algebra.Cubic(a, b, c, d, out x1, out x2, out x3);
            Assert.True(ValuesIn(new[] { x1, x2, x3 }, -9, -6, 6));

            a = 1;
            b = -3;
            c = -72;
            d = 324;
            Algebra.Cubic(a, b, c, d, out x1, out x2, out x3);
            Assert.True(ValuesIn(new[] { x1, x2, x3 }, -9, 6, 6));


            var geogebra = G.Execute(
                G.Cubic(a, b, c, d, "f"),
                G.Intersect("f", "xAxis", "i"),
                !x1.IsNaN ? G.Point(x1, 0, "P1") : "",
                !x2.IsNaN ? G.Point(x2, 0, "P2") : "",
                !x3.IsNaN ? G.Point(x3, 0, "P3") : "",
                "");
        }

        [Fact]
        public void Cubic2()
        {
            Big a, b, c, d;
            Big x1, x2, x3;

            a = -0.02;
            b = -1;
            c = -10;
            d = -20;
            Algebra.Cubic(a, b, c, d, out x1, out x2, out x3);
            Assert.True(ValuesIn(new[] { x1, x2, x3 }, "-37.3205080756887729352744634150587236694280525381038062805580698019", "-9.9999999999999999999999999999999999999999999999999999999999999532", "-2.6794919243112270647255365849412763305719474618961937194419302405"));


            var geogebra = G.Execute(
                G.Cubic(a, b, c, d, "f"),
                G.Intersect("f", "xAxis", "i"),
                !x1.IsNaN ? G.Point(x1, 0, "P1") : "",
                !x2.IsNaN ? G.Point(x2, 0, "P2") : "",
                !x3.IsNaN ? G.Point(x3, 0, "P3") : "",
                "");
        }
    }
}