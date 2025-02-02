using Photon;
using System.Collections.Concurrent;
using System.Numerics;
using Xunit.Abstractions;

namespace Tests
{
    public class Find137Try2Test : BaseTest
    {
        public Find137Try2Test(ITestOutputHelper output) : base(output) { }

        public static Big GetTotalArea(Big r1, long from, long to, Big x2, Big r2)
        {
            var ret = Big.Zero;
            var sync = new object();

            Parallel.For(from, to, n =>
            {
                var r = r1 * n * n;
                if (Dimension.SurfaceAreaOfTwoSphereIntersection(r, x2, r2, out Big area))
                {
                    lock (sync)
                    {
                        ret += area;
                    }
                }
            });


            return ret;
        }

        public static Big GetTotalEnergy(Big r1, long from, long to, Big x2, Big r2)
        {
            var ret = Big.Zero;
            var sync = new object();

            Parallel.For(from, to, n =>
            {
                var r = r1 * n * n;
                if (Dimension.SurfaceAreaOfTwoSphereIntersection(r, x2, r2, out Big area))
                {
                    lock (sync)
                    {
                        ret += area / (r * r);
                    }
                }
            });


            return ret;
        }

        [Fact]
        public void Area1()
        {
            var step = Big.Pow(10, -6);
            var from = (long)BigInteger.Pow(10, 12);
            var r1 = step / (2 * from + 1);
            var r2 = Big.One;
            var d = r1 * from * from;
            var x2 = d + r2;
            var to = (long)Big.Sqrt((x2 + r2) / r1) + 1;
            var count1 = to - from + 1;
            var area1 = GetTotalArea(r1, from, to, x2, r2);

            var r12 = r1 * 2;
            from = (long)Big.Sqrt(d / r12);
            to = (long)Big.Sqrt((x2 + r2) / r12) + 1;
            var count2 = to - from + 1;
            var area2 = GetTotalArea(r12, from, to, x2, r2);

            var div = area1 / area2; //Sqrt(2)
        }

        [Fact]
        public void Energy1()
        {
            var step = Big.Pow(10, -6);
            var from = (long)BigInteger.Pow(10, 5);
            var r1 = step / (2 * from + 1);
            var r2 = Big.One;
            var d = r1 * from * from;
            var x2 = d + r2;
            var to = (long)Big.Sqrt((x2 + r2) / r1) + 1;
            var count1 = to - from + 1;
            var area1 = GetTotalEnergy(r1, from, to, x2, r2);

            var r12 = Big.Sqrt(r1);
            from = (long)Big.Sqrt(d / r12);
            to = (long)Big.Sqrt((x2 + r2) / r12) + 1;
            var count2 = to - from + 1;
            var area2 = GetTotalEnergy(r12, from, to, x2, r2);

            var div = area1 / area2;
        }
    }
}