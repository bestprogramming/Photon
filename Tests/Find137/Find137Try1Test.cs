using Photon;
using System.Numerics;
using Xunit.Abstractions;

namespace Tests
{
    public class Find137Try1Test : BaseTest
    {
        public Find137Try1Test(ITestOutputHelper output) : base(output) { }

        public static IEnumerable<(Big Result, Big Radius)> GetAreas(Big r1, BigInteger n, Big x2, Big r2)
        {
            var r = r1 * n * n;
            while (Dimension.SurfaceAreaOfTwoSphereIntersection(r, x2, r2, out Big area))
            {
                yield return (area, r);
                n++;
                r = r1 * n * n;
            }
        }

        [Fact]
        public void Area1()
        {
            int count1, count2;
            BigInteger n;
            Big d, r1, r2, step, area1, area2, div;

            step = Big.Pow(10, -5);
            n = BigInteger.Pow(10, 15);
            r1 = step / (2 * n + 1);

            d = r1 * n * n;


            count1 = 0;
            area1 = 0;

            foreach (var area in GetAreas(r1, n + 1, d + Big.One, Big.One))
            {
                count1++;
                area1 += area.Result;
            }


            r2 = r1 * 2;
            n = (BigInteger)Big.Sqrt(d / r2);

            count2 = 0;
            area2 = 0;

            foreach (var area in GetAreas(r2, n + 1, d + Big.One, Big.One))
            {
                count2++;
                area2 += area.Result;
            }

            div = area1 / area2; //Sqrt(2)
        }

        [Fact]
        public void Energy1()
        {
            int count1, count2;
            BigInteger n;
            Big d, r1, r2, step, area1, area2, div;

            step = Big.Pow(10, -5);
            n = BigInteger.Pow(10, 5);
            r1 = step / (2 * n + 1);

            d = r1 * n * n;


            count1 = 0;
            area1 = 0;

            foreach (var area in GetAreas(r1, n + 1, d + Big.One, Big.One))
            {
                count1++;
                area1 += area.Result / area.Radius;
            }


            r2 = r1 * r1;
            n = (BigInteger)Big.Sqrt(d / r2);

            count2 = 0;
            area2 = 0;

            foreach (var area in GetAreas(r2, n + 1, d + Big.One, Big.One))
            {
                count2++;
                area2 += area.Result / area.Radius;
            }

            div = area1 / area2;
        }
    }
}