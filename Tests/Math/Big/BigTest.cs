using Photon;
using System.Numerics;
using Xunit.Abstractions;

namespace Tests
{
    public partial class BigTest : BaseTest
    {
        public BigTest(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void PlusPlus()
        {
            Big b;

            b = Big.One;
            b++;
            Assert.True(E(b, 2));
        }

        [Fact]
        public void MinusMinus()
        {
            Big b;

            b = Big.One;
            b--;
            Assert.True(E(b, Big.Zero));
        }

        [Fact]
        public void Add()
        {
            Big b;

            b = 1.23 + Big.One;
            Assert.True(E(b, 2.23));

            b = Big.One + 2;
            Assert.True(E(b, 3));

            b = -Big.One + 2;
            Assert.True(E(b, 1));

            b = Big.One + new BigInteger(2);
            Assert.True(E(b, 3));
        }

        [Fact]
        public void Subtract()
        {
            Big b;

            b = Big.One - 2;
            Assert.True(E(b, -1));

            b = -Big.One - 2;
            Assert.True(E(b, -3));

            b = Big.One * 15 - Big.One * 12;
            Assert.True(E(b, 3));

            b = Big.One - new BigInteger(2);
            Assert.True(E(b, -1));
        }

        [Fact]
        public void Multiply()
        {
            Big b;

            b = 2 * Big.One;
            Assert.True(E(b, 2));

            b = Big.One * 2 * 3 * 4 * 5;
            Assert.True(E(b, 120));

            b = Big.One * 1.2345;
            Assert.True(E(b, 1.2345));

            b = Big.One * 1.2 * 1.3;
            Assert.True(E(b, 1.56));

            b = Big.Parse("1.2345") * Big.Parse("1.2") * Big.Parse("1.3");
            Assert.True(E(b, 1.92582));

            b = Big.Parse("1.5") * Big.Parse("8.6");
            Assert.True(E(b, 12.9));

            b = Big.One * new BigInteger(2);
            Assert.True(E(b, 2));
        }

        [Fact]
        public void Divide()
        {
            Big b;

            b = Big.One / 2;
            Assert.True(E(b, 0.5));
            Assert.StartsWith("0.50000000", b.ToString());

            b = -Big.One / 2;
            Assert.True(E(b, -0.5));
            Assert.StartsWith("-0.50000000", b.ToString());

            b = Big.One / 3;
            Assert.True(E(b, 0.333333333333333));

            b = -Big.One / 3;
            Assert.True(E(b, -0.333333333333333));

            b = Big.Parse("12") / Big.Parse("5");
            Assert.True(E(b, 2.4));

            b = Big.One / new BigInteger(3);
            Assert.True(E(b, 0.333333333333333));
        }

        [Fact]
        public void Parse()
        {
            Big b;

            b = Big.Parse("1");
            Assert.True(b.ToString() == "1." + new string('0', Big.Digits));

            b = Big.Parse("123456789");
            Assert.True(b.ToString() == "123456789." + new string('0', Big.Digits));

            b = Big.Parse("0.00001");
            Assert.True(b.ToString() == "0.00001" + new string('0', Big.Digits - 5));

            b = Big.Parse("-1");
            Assert.True(b.ToString() == "-1." + new string('0', Big.Digits));

            b = Big.Parse("-123456789");
            Assert.True(b.ToString() == "-123456789." + new string('0', Big.Digits));

            b = Big.Parse("-0.00001");
            Assert.True(b.ToString() == "-0.00001" + new string('0', Big.Digits - 5));

            b = Big.Parse("321.12345678901234567890");
            Assert.True(b.ToString().Length == Big.Digits + 4 && b.ToString().StartsWith("321.12345678"));

            b = Big.Parse("-321.12345678901234567890");
            Assert.True(b.ToString().Length == Big.Digits + 5 && b.ToString().StartsWith("-321.12345678"));
        }

        [Fact]
        public void ToBig()
        {
            float f;
            double d;
            Big b;

            f = 12.345f;
            b = f;
            Assert.True(b == f);

            f = 0.123456789f;
            b = f;
            Assert.True(b == f);

            d = 1.234;
            b = d;
            Assert.True(b == d);

            d = 1.23456789123456789;
            b = d;
            Assert.True(b == d);

            d = 0.000000000000001;
            b = d;
            Assert.True(b == d);

            d = 1E-8;
            b = d;
            Assert.True(b == d);
        }

        [Fact]
        public void FromBig()
        {
            var one = Big.One;
            var byte1 = (byte)one;
            Assert.True(byte1 == 1);

            var sbyte1 = (sbyte)one;
            Assert.True(sbyte1 == 1);

            var short1 = (short)one;
            Assert.True(short1 == 1);

            var ushort1 = (ushort)one;
            Assert.True(ushort1 == 1);

            var int1 = (int)one;
            Assert.True(int1 == 1);

            var uint1 = (uint)one;
            Assert.True(uint1 == 1);

            var long1 = (long)one;
            Assert.True(long1 == 1);

            var ulong1 = (ulong)one;
            Assert.True(ulong1 == 1);

            var float1 = (float)one;
            Assert.True(float1 == 1);

            var double1 = (double)one;
            Assert.True(double1 == 1);

            var decimal1 = (decimal)one;
            Assert.True(decimal1 == 1);

            var bigInteger1 = (BigInteger)one;
            Assert.True(bigInteger1 == 1);
        }
    }
}