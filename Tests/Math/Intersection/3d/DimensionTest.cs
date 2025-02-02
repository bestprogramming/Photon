using Photon;
using Xunit.Abstractions;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class DimensionTest : BaseTest
    {
        public DimensionTest(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void SurfaceAreaOfTwoSphereIntersection1()
        {
            Big r1, x2, r2, area;

            r1 = 1;
            x2 = 1;
            r2 = 1;
            Dimension.SurfaceAreaOfTwoSphereIntersection(r1, x2, r2, out area);
            Assert.True(E(area, Big.Pi));
        }
    }
}