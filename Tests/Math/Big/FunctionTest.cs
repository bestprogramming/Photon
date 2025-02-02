using Photon;
using System.Diagnostics;

namespace Tests
{
    public partial class BigTest
    {
        [Fact]
        public void Sqrt1()
        {
            Stopwatch sw;
            Big b;

            sw = Stopwatch.StartNew();
            b = Big.Sqrt(25);
            sw.Stop();
            Assert.StartsWith("5.00000000", b.ToString());

            sw = Stopwatch.StartNew();
            b = Big.Sqrt(2);
            sw.Stop();
            Assert.StartsWith("1.41421356", b.ToString());
        }

        [Fact]
        public void Cbrt1()
        {
            Big b;

            b = Big.Cbrt(125);
            Assert.StartsWith("5.00000000", b.ToString());

            b = Big.Cbrt(2);
            Assert.StartsWith("1.25992104", b.ToString());

            b = Big.Cbrt(-2);
            Assert.StartsWith("-1.25992104", b.ToString());
        }

        [Fact]
        public void Pow1()
        {
            Big b;

            b = Big.Pow(10, -100000);
            Assert.True(b == Big.Zero);

            b = Big.Pow(10, 6);
            Assert.True(b == 1000000);

            b = Big.Pow(10, -3);
            Assert.True(b == 0.001);

            b = Big.Pow(2, 8);
            Assert.True(b == 256);

            b = Big.Pow(2, -3);
            Assert.True(b == 0.125);
        }


        [Fact]
        public void Sin1()
        {
            Stopwatch sw;
            Big b;

            sw = Stopwatch.StartNew();
            b = Big.Sin(Big.Zero);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, 0));

            sw = Stopwatch.StartNew();
            b = Big.Sin(Big.PiOver2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, 1));

            sw = Stopwatch.StartNew();
            b = Big.Sin(Big.Pi);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, 0));

            sw = Stopwatch.StartNew();
            b = Big.Sin(Big.Pi3Over2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -1));

            sw = Stopwatch.StartNew();
            b = Big.Sin(Big.Pi2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, 0));
        }

        [Fact]
        public void Sin2()
        {
            var sinPiOver4 = Big.Parse("0.7071067811865475244008443621048490392848359376884740365883398689953662392310535194251937671638207863675069231154561485124624180279");
            Stopwatch sw;
            Big b;

            for (var n = 0; n <= 360; n++)
            {
                sw = Stopwatch.StartNew();
                b = Big.Sin(n * Big.PiOver180);
                sw.Stop();
                Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Math.Sin(n * Const.PiOver180)));
            }

            sw = Stopwatch.StartNew();
            b = Big.Sin(Big.PiOver4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, sinPiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Sin(-Big.PiOver4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -sinPiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Sin(Big.Pi3Over4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, sinPiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Sin(Big.Pi5Over4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -sinPiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Sin(Big.Pi7Over4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -sinPiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Sin(Big.Pi / 6);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, 0.5));

            sw = Stopwatch.StartNew();
            b = Big.Sin(26 * Big.Pi2 + Big.Pi / 6);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, 0.5));
        }


        [Fact]
        public void Cos1()
        {
            var cosPiOver4 = Big.Parse("0.7071067811865475244008443621048490392848359376884740365883398689953662392310535194251937671638207863675069231154561485124624180279");
            Stopwatch sw;
            Big b;

            sw = Stopwatch.StartNew();
            b = Big.Cos(Big.PiOver4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, cosPiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Cos(-Big.PiOver4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, cosPiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Cos(Big.Pi3Over4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -cosPiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Cos(Big.Pi5Over4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -cosPiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Cos(Big.Pi7Over4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, cosPiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Cos(Big.Pi / 3);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, 0.5));

            sw = Stopwatch.StartNew();
            b = Big.Cos(26 * Big.Pi2 + Big.Pi / 3);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, 0.5));
        }

        [Fact]
        public void Cos2()
        {
            Stopwatch sw;
            Big b;

            for (var n = 0; n <= 360; n++)
            {
                sw = Stopwatch.StartNew();
                b = Big.Cos(n * Big.PiOver180);
                sw.Stop();
                Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Math.Cos(n * Const.PiOver180)));
            }
        }


        [Fact]
        public void Tan1()
        {
            var tanPiOver3 = Big.Parse("1.732050807568877293527446341505872366942805253810380628055806979451933016908800037081146186757248575675626141415406703029969945095");
            Stopwatch sw;
            Big b;

            sw = Stopwatch.StartNew();
            b = Big.Tan(Big.PiOver4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.One));

            sw = Stopwatch.StartNew();
            b = Big.Tan(-Big.PiOver4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -Big.One));

            sw = Stopwatch.StartNew();
            b = Big.Tan(Big.Pi3Over4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -Big.One));

            sw = Stopwatch.StartNew();
            b = Big.Tan(Big.Pi5Over4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.One));

            sw = Stopwatch.StartNew();
            b = Big.Tan(Big.Pi7Over4);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -Big.One));

            sw = Stopwatch.StartNew();
            b = Big.Tan(Big.Pi / 3);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, tanPiOver3));

            sw = Stopwatch.StartNew();
            b = Big.Tan(26 * Big.Pi2 + Big.Pi / 3);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, tanPiOver3));
        }

        [Fact]
        public void Tan2()
        {
            Stopwatch sw;
            Big b;

            for (var n = 0; n <= 360; n++)
            {
                if (n % 90 == 0) continue;

                sw = Stopwatch.StartNew();
                b = Big.Tan(n * Big.PiOver180);
                sw.Stop();
                Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Math.Tan(n * Const.PiOver180)));
            }

            sw = Stopwatch.StartNew();
            b = Big.Tan(Big.Rad(Big.Parse("89.999999999999999")));
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "57295779513082320.8767981548141051645146412991521323984701910155658270175259278306536206501795954374073973375062023"));

            sw = Stopwatch.StartNew();
            b = Big.Tan(Big.Rad(Big.Parse("0.000000000000001")));
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "0.00000000000000001745329251994329576923690768488612890662103028801328653835617749621163322685801890953927370623069113758576803483112460180498084714"));
        }


        [Fact]
        public void Asin1()
        {
            Stopwatch sw;
            Big b;

            sw = Stopwatch.StartNew();
            b = Big.Asin(Big.One / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.Pi / 6));

            sw = Stopwatch.StartNew();
            b = Big.Asin(Big.Sqrt3 / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.Pi / 3));

            sw = Stopwatch.StartNew();
            b = Big.Asin(-Big.One / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -Big.Pi / 6));

            sw = Stopwatch.StartNew();
            b = Big.Asin(-Big.Sqrt3 / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -Big.Pi / 3));
        }

        [Fact]
        public void Asin2()
        {
            Stopwatch sw;
            Big b;

            for (var n = -1000; n <= 1000; n++)
            {
                sw = Stopwatch.StartNew();
                b = Big.Asin(Big.One * n / 1000);
                sw.Stop();
                Assert.True(sw.ElapsedMilliseconds < 20 && E(b, Math.Asin(n / 1000.0)));
            }
        }


        [Fact]
        public void ACos1()
        {
            Stopwatch sw;
            Big b;

            sw = Stopwatch.StartNew();
            b = Big.Acos(Big.One / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.Pi / 3));

            sw = Stopwatch.StartNew();
            b = Big.Acos(Big.Sqrt3 / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.Pi / 6));

            sw = Stopwatch.StartNew();
            b = Big.Acos(-Big.One / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.Pi - Big.Pi / 3));

            sw = Stopwatch.StartNew();
            b = Big.Acos(-Big.Sqrt3 / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.Pi - Big.Pi / 6));
        }

        [Fact]
        public void Acos2()
        {
            Stopwatch sw;
            Big b;

            for (var n = -1000; n <= 1000; n++)
            {
                sw = Stopwatch.StartNew();
                b = Big.Acos(Big.One * n / 1000);
                sw.Stop();
                Assert.True(sw.ElapsedMilliseconds < 20 && E(b, Math.Acos(n / 1000.0)));
            }
        }


        [Fact]
        public void Atan1()
        {
            Stopwatch sw;
            Big b;

            sw = Stopwatch.StartNew();
            b = Big.Atan(Big.MinusOne * 5 / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "-1.190289949682531732927733774829318337601178986029452072911166673829707745314101396955153966575185598813039185930215474374731346632"));

            sw = Stopwatch.StartNew();
            b = Big.Atan(Big.MinusOne * 3 / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "-0.9827937232473290679857106110146660144968774536316285567614250883179880715497960353897065343728173111081651397020119367662299410392"));

            sw = Stopwatch.StartNew();
            b = Big.Atan(Big.One * 5 / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "1.190289949682531732927733774829318337601178986029452072911166673829707745314101396955153966575185598813039185930215474374731346632"));

            sw = Stopwatch.StartNew();
            b = Big.Atan(Big.One * 3 / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "0.9827937232473290679857106110146660144968774536316285567614250883179880715497960353897065343728173111081651397020119367662299410392"));

            sw = Stopwatch.StartNew();
            b = Big.Atan(Big.MinusOne * 1 / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "-0.4636476090008061162142562314612144020285370542861202638109330887201978641657417053006002839848878925565298522511908375135058181816"));

            sw = Stopwatch.StartNew();
            b = Big.Atan(Big.One * 1 / 2);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "0.4636476090008061162142562314612144020285370542861202638109330887201978641657417053006002839848878925565298522511908375135058181816"));

            sw = Stopwatch.StartNew();
            b = Big.Atan(Big.One);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.PiOver4));

            sw = Stopwatch.StartNew();
            b = Big.Atan(Big.MinusOne / 3);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "-0.3217505543966421934014046143586613190207552955576561914328030593567562374058105443564084223506413744390071693771297391482676429708"));

            sw = Stopwatch.StartNew();
            b = Big.Atan(Big.One / 3);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "0.3217505543966421934014046143586613190207552955576561914328030593567562374058105443564084223506413744390071693771297391482676429708"));
        }

        [Fact]
        public void Atan2()
        {
            Stopwatch sw;
            Big b;

            sw = Stopwatch.StartNew();
            b = Big.Atan(Big.MinusOne * 149 / 100);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, "-0.9797025429849916144143102185174022235625350369398515722433897614492547355323676676433344726911500318309188427938851251454367729113"));

            for (var n = -1000; n <= 1000; n++)
            {
                sw = Stopwatch.StartNew();
                b = Big.Atan(Big.One * n / 100);
                sw.Stop();
                Assert.True(sw.ElapsedMilliseconds < 20 && E(b, Math.Atan(n / 100.0)));
            }
        }


        [Fact]
        public void Atan21()
        {
            Stopwatch sw;
            Big b;

            sw = Stopwatch.StartNew();
            b = Big.Atan2(0, 1);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.Zero) && E(b, Math.Atan2(0, 1)));

            sw = Stopwatch.StartNew();
            b = Big.Atan2(1, 1);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.PiOver4) && E(b, Math.Atan2(1, 1)));

            sw = Stopwatch.StartNew();
            b = Big.Atan2(1, 0);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.PiOver2) && E(b, Math.Atan2(1, 0)));

            sw = Stopwatch.StartNew();
            b = Big.Atan2(1, -1);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.Pi3Over4) && E(b, Math.Atan2(1, -1)));

            sw = Stopwatch.StartNew();
            b = Big.Atan2(0, -1);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, Big.Pi) && E(b, Math.Atan2(0, -1)));

            sw = Stopwatch.StartNew();
            b = Big.Atan2(-1, -1);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -Big.Pi3Over4) && E(b, Math.Atan2(-1, -1)));

            sw = Stopwatch.StartNew();
            b = Big.Atan2(-1, 0);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -Big.PiOver2) && E(b, Math.Atan2(-1, 0)));

            sw = Stopwatch.StartNew();
            b = Big.Atan2(-1, 1);
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds < 10 && E(b, -Big.PiOver4) && E(b, Math.Atan2(-1, 1)));
        }

        [Fact]
        public void Atan22()
        {
            Stopwatch sw;
            Big b;

            for (var n = 0; n <= 1000; n++)
            {
                var y = Rand.Int(-100, 100);
                var x = Rand.Int(-100, 100);
                sw = Stopwatch.StartNew();
                b = Big.Atan2(y, x);
                sw.Stop();
                Assert.True(sw.ElapsedMilliseconds < 20 && E(b, Math.Atan2(y, x)));
            }
        }
    }
}