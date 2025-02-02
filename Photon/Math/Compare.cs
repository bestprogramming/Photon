namespace Photon
{
    public static partial class Compare
    {
        public static bool In(in Big value, in Big value1, in Big value2) => value1 < value2 ? value >= value1 && value <= value2 : value >= value2 && value <= value1;
        public static bool In(double value, double value1, double value2) => value1 < value2 ? value >= value1 && value <= value2 : value >= value2 && value <= value1;

        public static bool Lte(double value1, double value2) => value1 <= value2;
        public static bool Gte(double value1, double value2) => value1 >= value2;
    }
}
