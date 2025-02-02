namespace Photon
{
    public partial struct Point3
    {
        public static readonly Point3 NaN = new(Big.NaN, Big.NaN, Big.NaN);
    }

    public static partial class ExtensionMethods
    {
        public static bool IsPointReal(in Big x, in Big y, in Big z) => !x.IsNaN && !y.IsNaN && !z.IsNaN;

        public static bool IsReal(this Point3 p) => IsPointReal(p.X, p.Y, p.Z);
    }
}
