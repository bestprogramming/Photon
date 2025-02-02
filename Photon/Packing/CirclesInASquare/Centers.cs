using System.Text.RegularExpressions;

namespace Photon.Packing
{
    public static partial class CirclesInASquare
    {
        public const string DirectoryPath = @"C:\Quantum\Files\Packing\CirclesInASquare";

        private static readonly Dictionary<int, PointD[]> centers = new();

        private static void Get(int n)
        {
            var filename = Path.Combine(DirectoryPath, $"csq{n}.txt");
            if (!centers.ContainsKey(n) && File.Exists(filename))
            {
                string s = File.ReadAllText(filename);
                var matches = Regex.Matches(s, @"([0-9]+)\s+(-?[0-9]+\.?[0-9]*)\s+(-?[0-9]+\.?[0-9]*)");
                centers.Add(n, matches.Select(p => new PointD(Convert.ToDouble(p.Groups[2].Value), Convert.ToDouble(p.Groups[3].Value))).ToArray());
            }
        }

        public static PointD[] GetAreaCenters(int n)
        {
            Get(n);
            return centers[n];
        }

        public static PointD[] GetBorderCenters(int n)
        {
            var ret = new List<PointD>();
            var row = Table[n];
            Get(n);

            var a_2 = 0.5 - row.Radius;
            var d1 = -a_2 - row.Radius;
            var d2 = -a_2 + row.Radius;
            var d3 = a_2 - row.Radius;
            var d4 = a_2 + row.Radius;

            foreach (var c in centers[n])
            {
                if (Compare.In(c.X, d1, d2) ||
                    Compare.In(c.Y, d1, d2) ||
                    Compare.In(c.X, d3, d4) ||
                    Compare.In(c.Y, d3, d4))
                {
                    ret.Add(c);
                }
            }

            return ret.ToArray();
        }
    }
}