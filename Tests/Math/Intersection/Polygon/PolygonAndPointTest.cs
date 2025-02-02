using Photon;
using Xunit.Abstractions;
using G = Photon.Geogebra;

namespace Tests
{
    public partial class IntersectionTest
    {
        [Fact]
        public void PolygonAndPoint1()
        {
            var points = new PointD[] 
            { 
                new(-0.592676190459579, 0.718385460995784),
                new(-1.673320553959948,1.750786772334671),
                new(-0.177785943758544,0.718385460995784),
                new(2.909769380528224,1.866570096970808),
                new(-0.254974826865714,0.226306331292203),
                new(4.771951185488681,-1.394660213613713),
                new(1.964205562465401,-1.307822720136611),
                new(3.5,-2.5),
                new(0.420427900322017,-1.761307408294813),
                new(0.275698744496075,-0.304367239956758),
                new(-1.489996956580421,-0.690311655410547),
                new(-1.152295592986556,0.457872980564476),
            };
            double x, y;
            bool ok;

            x = -1.513859698324353;
            y = 2.593047251315962;
            ok = Intersection.IsPointInPolygon(x, y, points);
            Assert.True(!ok);

            x = -0.594073866994226;
            y = 1.005301365990896;
            ok = Intersection.IsPointInPolygon(x, y, points);
            Assert.True(ok);

            x = -0.593543560809806;
            y = 1.005468932112549;
            ok = Intersection.IsPointInPolygon(x, y, points);
            Assert.True(!ok);

            x = -0.25497922818843;
            y = 0.226306513506124;
            ok = Intersection.IsPointInPolygon(x, y, points);
            Assert.True(ok);

            x = -0.254963470055723;
            y = 0.226307693421588;
            ok = Intersection.IsPointInPolygon(x, y, points);
            Assert.True(!ok);


            var geogebra = G.Execute(
                G.PolygonXy(points, "poly"),
                G.Point(x,y, "P"),
                "");
        }
    }
}