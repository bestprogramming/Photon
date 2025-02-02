namespace Photon
{
    public static partial class ExtensionMethods
    {
        public static bool IsReal(this double d) => !double.IsNaN(d) && !double.IsInfinity(d);
    }
}
