using Photon;
using System.Numerics;
using Xunit.Abstractions;

namespace Tests
{
    public class DemoTest : BaseTest
    {
        public DemoTest(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void Demo1()
        {
            var vs = new List<List<int>>
            {
                new List<int>{ 345, 343, 64, 345, 43256 },
                new List<int>{ 1, 45, 98 },
                new List<int>{ 88, 2, 8, 9},
                new List<int>{ 9 },
                new List<int>{ 23, 7, 78 },
            };

            var count = 5 * 3 + 5 * 4 + 5 * 1 + 5 * 3 +
                3 * 4 + 3 * 1 + 3 * 3 +
                4 * 1 + 4 * 3 +
                1 * 3;

            var n = 1;
            var count1 = vs.Take(vs.Count - 1).Aggregate(0, (c1, n1) => c1 + vs.Skip(n++).Aggregate(0, (c2, n2) => c2 + n1.Count * n2.Count));
        }

        [Fact]
        public void Demo2()
        {
        }
    }
}