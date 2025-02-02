namespace Photon
{
    public partial struct Point3D
    {
        public static readonly Point3D NaN = new(double.NaN, double.NaN, double.NaN);
    }

    public static partial class ExtensionMethods
    {
        public static bool IsPointReal(double x, double y, double z) => x.IsReal() && y.IsReal() && z.IsReal();

        public static bool IsReal(this Point3D p) => IsPointReal(p.X, p.Y, p.Z);
    }
}
