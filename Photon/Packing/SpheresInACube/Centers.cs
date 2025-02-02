using System.Text.RegularExpressions;

namespace Photon.Packing
{
    public static partial class SpheresInASphere
    {
        public const string DirectoryPath = @"C:\Quantum\Files\Packing\SpheresInASphere";

        private static readonly Dictionary<int, Point3D[]> centers = new();

        public static Point3D[] GetCenters(int n)
        {
            var filename = Path.Combine(DirectoryPath, $"ssp{n}.txt");
            if (!centers.ContainsKey(n) && File.Exists(filename))
            {
                string s = File.ReadAllText(filename);
                var matches = Regex.Matches(s, @"^\s*([0-9]+)\s+(-?[0-9]+\.?[0-9]*)\s+(-?[0-9]+\.?[0-9]*)\s+(-?[0-9]+\.?[0-9]*)\s*$", RegexOptions.Multiline);
                centers.Add(n, matches.Select(p => new Point3D(Convert.ToDouble(p.Groups[2].Value), Convert.ToDouble(p.Groups[3].Value), Convert.ToDouble(p.Groups[4].Value))).ToArray());
            }

            return centers[n];
        }
    }
}