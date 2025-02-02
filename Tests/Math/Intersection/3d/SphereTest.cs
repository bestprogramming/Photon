using Photon;
using Xunit.Abstractions;
using G = Photon.Geogebra;

namespace Tests
{
    public class SphereTest : BaseTest
    {
        public SphereTest(ITestOutputHelper output) : base(output) {}

        [Fact]
        public void TwoSpheres1()
        {
            Big x1, y1, z1, r1, x2, y2, z2, r2;
            bool ok;
            Circle3 c;

            x1 = 3;
            y1 = 0;
            z1 = 0;
            r1 = 5;
            x2 = -7;
            y2 = 0;
            z2 = 0;
            r2 = 5;
            ok = Intersection.TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out c);
            Assert.True(!ok);

            x1 = 3;
            y1 = 0;
            z1 = 0;
            r1 = 5;
            x2 = -3;
            y2 = 0;
            z2 = 0;
            r2 = 5;
            ok = Intersection.TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out c);
            Assert.True(ok && E(c.X, 0) && E(c.Y, 0) && E(c.Z, 0) && E(c.R, 4) && E(c.Ax, 0) && E(c.Bx, 0) && E(c.Ay, 4) && E(c.By, 0) && E(c.Az, 0) && E(c.Bz, -4));

            x1 = 0;
            y1 = 3;
            z1 = 0;
            r1 = 5;
            x2 = 0;
            y2 = -3;
            z2 = 0;
            r2 = 5;
            ok = Intersection.TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out c);
            Assert.True(ok && E(c.X, 0) && E(c.Y, 0) && E(c.Z, 0) && E(c.R, 4) && E(c.Ax, 0) && E(c.Bx, -4) && E(c.Ay, 0) && E(c.By, 0) && E(c.Az, 4) && E(c.Bz, 0));

            x1 = 0;
            y1 = 0;
            z1 = 3;
            r1 = 5;
            x2 = 0;
            y2 = 0;
            z2 = -3;
            r2 = 5;
            ok = Intersection.TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out c);
            Assert.True(ok && E(c.X, 0) && E(c.Y, 0) && E(c.Z, 0) && E(c.R, 4) && E(c.Ax, 4) && E(c.Bx, 0) && E(c.Ay, 0) && E(c.By, -4) && E(c.Az, 0) && E(c.Bz, 0));


            var geogebra = G.Execute(
                G.Sphere(x1, y1, z1, r1, "s1"),
                G.Sphere(x2, y2, z2, r2, "s2"),
                G.IntersectConic("s1", "s2", "i1"),
                ok ? G.Point(c.X, c.Y, c.Z, "CP") : "",
                ok ? G.Point(c.PointAt(Big.Rad(10)), "P1") : "",
                ok ? G.Point(c.PointAt(Big.Rad(20)), "P2") : "",
                ok ? G.Circle3(c, "i2") : "",
                "");
        }

        [Fact]
        public void TwoSpheres2()
        {
            Big x1, y1, z1, r1, x2, y2, z2, r2;
            bool ok;
            Circle3 c;

            x1 = -3.3473589324325;
            y1 = 1.34789382926454;
            z1 = -7.3789435923678;
            r1 = 7.34789343234456;
            x2 = 3.72346789034234;
            y2 = 16.2343693950489;
            z2 = 27.92136784623789;
            r2 = 45.34563453254343;
            ok = Intersection.TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out c);
            Assert.True(ok && E(c.X, -4.4760129936003334) && E(c.Y, -1.0283036826983754) && E(c.Z, -13.01362265668072) && E(c.R, 3.9143013590725007) && E(c.Ax, 3.8380630324724345) && E(c.Bx, 0.293765260963141) && E(c.Ay, 0) && E(c.By, -3.6172600593682418) && E(c.Az, -0.76878299175081033) && E(c.Bz, 1.4665901826984074));


            var geogebra = G.Execute(
                G.Sphere(x1, y1, z1, r1, "s1"),
                G.Sphere(x2, y2, z2, r2, "s2"),
                G.IntersectConic("s1", "s2", "i1"),
                ok ? G.Point(c.X, c.Y, c.Z, "CP") : "",
                ok ? G.Point(c.PointAt(Big.Rad(10)), "P1") : "",
                ok ? G.Point(c.PointAt(Big.Rad(20)), "P2") : "",
                ok ? G.Circle3(c, "i2") : "",
                "");
        }


        [Fact]
        public void TwoSpheres3()
        {
            Big x1, y1, z1, r1, x2, y2, z2, r2;
            bool ok;
            Ellipse xy, yz, zx;

            x1 = 3;
            y1 = 0;
            z1 = 0;
            r1 = 5;
            x2 = -7;
            y2 = 0;
            z2 = 0;
            r2 = 5;
            ok = Intersection.TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out xy, out yz, out zx);
            Assert.True(!ok);

            x1 = 3;
            y1 = 0;
            z1 = 0;
            r1 = 5;
            x2 = -3;
            y2 = 0;
            z2 = 0;
            r2 = 5;
            ok = Intersection.TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out xy, out yz, out zx);
            Assert.True(ok && E(xy.X, 0) && E(xy.Y, 0) && E(xy.A, 4) && E(xy.B, 0) && E(xy.Rotate, 1.5707963267948966) &&
                E(yz.X, 0) && E(yz.Y, 0) && E(yz.A, 4) && E(yz.B, 4) && E(yz.Rotate, 0) &&
                E(zx.X, 0) && E(zx.Y, 0) && E(zx.A, 4) && E(zx.B, 0) && E(zx.Rotate, 3.141592653589793));

            x1 = 0;
            y1 = 3;
            z1 = 0;
            r1 = 5;
            x2 = 0;
            y2 = -3;
            z2 = 0;
            r2 = 5;
            ok = Intersection.TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out xy, out yz, out zx);
            Assert.True(ok && E(xy.X, 0) && E(xy.Y, 0) && E(xy.A, 4) && E(xy.B, 0) && E(xy.Rotate, 3.141592653589793) &&
                E(yz.X, 0) && E(yz.Y, 0) && E(yz.A, 4) && E(yz.B, 0) && E(yz.Rotate, 1.5707963267948966) &&
                E(zx.X, 0) && E(zx.Y, 0) && E(zx.A, 4) && E(zx.B, 4) && E(zx.Rotate, 0));

            x1 = 0;
            y1 = 0;
            z1 = 3;
            r1 = 5;
            x2 = 0;
            y2 = 0;
            z2 = -3;
            r2 = 5;
            ok = Intersection.TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out xy, out yz, out zx);
            Assert.True(ok && E(xy.X, 0) && E(xy.Y, 0) && E(xy.A, 4) && E(xy.B, 4) && E(xy.Rotate, 0) &&
                E(yz.X, 0) && E(yz.Y, 0) && E(yz.A, 4) && E(yz.B, 0) && E(yz.Rotate, 3.141592653589793) &&
                E(zx.X, 0) && E(zx.Y, 0) && E(zx.A, 4) && E(zx.B, 0) && E(zx.Rotate, 1.5707963267948966));


            var geogebra = G.Execute(
                G.Sphere(x1, y1, z1, r1, "s1"),
                G.Sphere(x2, y2, z2, r2, "s2"),
                G.IntersectConic("s1", "s2", "i1"),
                ok ? G.EllipseXy(xy, "Xy") : "",
                ok ? G.EllipseYz(yz, "Yz") : "",
                ok ? G.EllipseZx(zx, "Zx") : "",
                "");
        }

        [Fact]
        public void TwoSpheres4()
        {
            Big x1, y1, z1, r1, x2, y2, z2, r2;
            bool ok;
            Ellipse xy, yz, zx;

            x1 = -3.3473589324325;
            y1 = 1.34789382926454;
            z1 = -7.3789435923678;
            r1 = 7.34789343234456;
            x2 = 3.72346789034234;
            y2 = 16.2343693950489;
            z2 = 27.92136784623789;
            r2 = 45.34563453254343;
            ok = Intersection.TwoSpheres(x1, y1, z1, r1, x2, y2, z2, r2, out xy, out yz, out zx);
            Assert.True(ok && E(xy.X, -4.4760129936003334) && E(xy.Y, -1.0283036826983754) && E(xy.A, 3.9143013590725007) && E(xy.B, 3.5468071666280578) && E(xy.Rotate, 2.6981579685461945) &&
                E(yz.X, -1.0283036826983754) && E(yz.Y, -13.01362265668072) && E(yz.A, 3.9143013590725007) && E(yz.B, 0.71044300253896808) && E(yz.Rotate, 2.7425124142210429) &&
                E(zx.X, -13.01362265668072) && E(zx.Y, -4.4760129936003334) && E(zx.A, 3.9143013590725007) && E(zx.B, 1.4957221642190404) && E(zx.Rotate, 1.7684850825631875));


            var geogebra = G.Execute(
                G.Sphere(x1, y1, z1, r1, "s1"),
                G.Sphere(x2, y2, z2, r2, "s2"),
                G.IntersectConic("s1", "s2", "i1"),
                ok ? G.EllipseXy(xy, "Xy") : "",
                ok ? G.EllipseYz(yz, "Yz") : "",
                ok ? G.EllipseZx(zx, "Zx") : "",
                "");
        }
    }
}