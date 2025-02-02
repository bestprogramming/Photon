﻿using System.Numerics;

namespace Photon
{
    public partial struct Big
    {
        public static Big operator +(in Big left, in Big right) => left.nan || right.nan ? NaN : left.bi + right.bi;
        public static Big operator +(in Big left, in BigInteger right) => left.nan ? NaN : left.bi + right * pow;
        public static Big operator +(in Big left, byte right) => left.nan ? NaN : left.bi + right * pow;
        public static Big operator +(in Big left, sbyte right) => left.nan ? NaN : left.bi + right * pow;
        public static Big operator +(in Big left, short right) => left.nan ? NaN : left.bi + right * pow;
        public static Big operator +(in Big left, ushort right) => left.nan ? NaN : left.bi + right * pow;
        public static Big operator +(in Big left, int right) => left.nan ? NaN : left.bi + right * pow;
        public static Big operator +(in Big left, uint right) => left.nan ? NaN : left.bi + right * pow;
        public static Big operator +(in Big left, long right) => left.nan ? NaN : left.bi + right * pow;
        public static Big operator +(in Big left, ulong right) => left.nan ? NaN : left.bi + right * pow;
        public static Big operator +(in Big left, float right) => left.nan ? NaN : left.bi + new Big(right).bi;
        public static Big operator +(in Big left, double right) => left.nan ? NaN : left.bi + new Big(right).bi;
        public static Big operator +(in Big left, decimal right) => left.nan ? NaN : left.bi + new Big(right).bi;
    }
}
