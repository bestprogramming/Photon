using System.Text.RegularExpressions;

namespace Photon.Packing
{
    public static partial class CirclesInACircle
    {
        public const string DirectoryPath = @"C:\Quantum\Files\Packing\CirclesInACircle";

        private static readonly Dictionary<int, PointD[]> centers = new();

        public static PointD[] GetCenters(int n)
        {
            var filename = Path.Combine(DirectoryPath, $"cci{n}.txt");
            if (!centers.ContainsKey(n) && File.Exists(filename))
            {
                string s = File.ReadAllText(filename);
                var matches = Regex.Matches(s, @"([0-9]+)\s+(-?[0-9]+\.?[0-9]*)\s+(-?[0-9]+\.?[0-9]*)");
                centers.Add(n, matches.Select(p => new PointD(Convert.ToDouble(p.Groups[2].Value), Convert.ToDouble(p.Groups[3].Value))).ToArray());
            }

            return centers[n];
        }
    }
}