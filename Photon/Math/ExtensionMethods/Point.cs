namespace Photon
{
    public partial struct Point
    {
        public static readonly Point NaN = new(Big.NaN, Big.NaN);
    }

    public static partial class ExtensionMethods
    {
        public static bool IsPointReal(in Big x, in Big y) => !x.IsNaN && !y.IsNaN;

        public static bool IsReal(this Point p) => IsPointReal(p.X, p.Y);
    }
}
