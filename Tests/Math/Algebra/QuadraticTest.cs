using Photon;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class AlgebraTest
    {
        [Fact]
        public void Quadratic1()
        {
            Big a, b, c;
            Big x1, x2;

            a = 0;
            b = 0;
            c = 25;
            Algebra.Quadratic(a, b, c, out x1, out x2);
            Assert.True(NaNs(x1, x2));

            a = 0;
            b = 1;
            c = 0;
            Algebra.Quadratic(a, b, c, out x1, out x2);
            Assert.True(E(x1, 0) && NaNs(x2));

            a = 1;
            b = -5;
            c = 6;
            Algebra.Quadratic(a, b, c, out x1, out x2);
            Assert.True(ValuesIn(new[] { x1, x2 }, 3, 2));

            a = 1;
            b = -6;
            c = 9;
            Algebra.Quadratic(a, b, c, out x1, out x2);
            Assert.True(ValuesIn(new[] { x1, x2 }, 3));

            a = 0;
            b = -6;
            c = 9;
            Algebra.Quadratic(a, b, c, out x1, out x2);
            Assert.True(E(x1, 1.5) && NaNs(x2));

            a = 1;
            b = 1;
            c = 1;
            Algebra.Quadratic(a, b, c, out x1, out x2);
            Assert.True(NaNs(x1, x2));


            var geogebra = G.Execute(
                G.Quadratic(a, b, c, "f"),
                G.Intersect("f", "xAxis", "i"),
                !x1.IsNaN ? G.Point(x1, 0, "P1") : "",
                !x2.IsNaN ? G.Point(x2, 0, "P2") : "",
                "");
        }
    }
}