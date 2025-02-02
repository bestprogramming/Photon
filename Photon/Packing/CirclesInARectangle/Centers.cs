using System.Text.RegularExpressions;

namespace Photon.Packing
{
    public static partial class CirclesInARectangle
    {
        public const string DirectoryPath = @"C:\Quantum\Files\Packing\CirclesInARectangle";

        private static readonly Dictionary<int, PointD[]> centers = new();

        private static void Get(int n)
        {
            var height = Table[n].Height.ToString("N12");
            var filename = Path.Combine(DirectoryPath, $"crc{n}_{height}.txt");
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
            var b_2 = Table[n].Height / 2 - row.Radius;

            foreach (var c in centers[n])
            {
                if (Compare.In(c.X, -a_2 - row.Radius, -a_2 + row.Radius) ||
                    Compare.In(c.Y, -b_2 - row.Radius, -b_2 + row.Radius) ||
                    Compare.In(c.X, a_2 - row.Radius, a_2 + row.Radius) ||
                    Compare.In(c.Y, b_2 - row.Radius, b_2 + row.Radius))
                {
                    ret.Add(c);
                }
            }

            return ret.ToArray();
        }
    }
}