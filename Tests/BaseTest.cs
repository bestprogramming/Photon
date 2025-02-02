using Newtonsoft.Json.Linq;
using Photon;
using System.Linq;
using System.Numerics;
using Xunit.Abstractions;

namespace Tests
{
    public class BaseTest
    {
        protected readonly ITestOutputHelper output;
        public static readonly Big Epsilon = 1E-8;

        public BaseTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        public static bool E(in Big b1, in Big b2) => Big.Abs(b1 - b2) <= Epsilon;
        public static bool E(in Big b1, string b2) => Big.Abs(b1 - Big.Parse(b2)) <= Epsilon;
        public static bool Is0(in Big b) => Big.Abs(b) <= Epsilon;
        public static bool NaNs(params double[] values) => values.All(p => double.IsNaN(p));
        public static bool NaNs(params Big[] values) => values.All(p => p.IsNaN);

        public static bool PointE(double x1, double y1, double x2, double y2) => Math.Abs(x1 - x2) < Epsilon && Math.Abs(y1 - y2) < Epsilon;
        public static bool PointE(in Point p1, in Point p2) => PointE(p1.X, p1.Y, p2.X, p2.Y);

        public static bool PointE(double x1, double y1, double z1, double x2, double y2, double z2) => Math.Abs(x1 - x2) < Epsilon && Math.Abs(y1 - y2) < Epsilon && Math.Abs(z1 - z2) < Epsilon;
        public static bool PointE(in Point3 p1, in Point3 p2) => PointE(p1.X, p1.Y, p1.Z, p2.X, p2.Y, p2.Z);


        public static bool ValuesIn(Big[] array, params double[] values) => values.All(v => v.IsReal()) && values.All(v => array.All(a => !a.IsNaN && values.Any(p => E(p, a))));
        public static bool ValuesIn(Big[] array, params string[] values) => values.All(v => array.All(a => !a.IsNaN && values.Any(p => E(Big.Parse(p), a))));

        public static bool PointsIn(double[] array, params double[] points)
        {
            var points1 = new List<Point>();
            var points2 = new List<Point>();

            for (var n = 0; n < array.Length / 2; n++)
            {
                points1.Add(new(array[2 * n + 0], array[2 * n + 1]));
            }

            for (var n = 0; n < points.Length / 2; n++)
            {
                points2.Add(new(points[2 * n + 0], points[2 * n + 1]));
            }

            return points1.All(p1 => p1.IsReal()) && points2.All(p2 => p2.IsReal() && points1.Any(p1 => PointE(p1, p2)));
        }

        public static bool Point3sIn(Point3[] array, params double[] points)
        {
            var points2 = new List<Point3>();

            for (var n = 0; n < points.Length / 3; n++)
            {
                points2.Add(new(points[3 * n + 0], points[3 * n + 1], points[3 * n + 2]));
            }

            return array.All(p1 => p1.IsReal()) && points2.All(p2 => p2.IsReal() && array.Any(p1 => PointE(p1, p2)));
        }

        public static bool Point3sIn(Point3[] array, params string[] points)
        {
            var points2 = new List<Point3>();

            for (var n = 0; n < points.Length / 3; n++)
            {
                points2.Add(new(Big.Parse(points[3 * n + 0]), Big.Parse(points[3 * n + 1]), Big.Parse(points[3 * n + 2])));
            }

            return array.All(p1 => p1.IsReal()) && points2.All(p2 => p2.IsReal() && array.Any(p1 => PointE(p1, p2)));
        }


        public static bool PointsIn(Big[] array, params Big[] points)
        {
            var points1 = new List<Tuple<Big, Big>>();
            var points2 = new List<Tuple<Big, Big>>();

            for (var n = 0; n < array.Length / 2; n++)
            {
                points1.Add(new(array[2 * n + 0], array[2 * n + 1]));
            }

            for (var n = 0; n < points.Length / 2; n++)
            {
                points2.Add(new(points[2 * n + 0], points[2 * n + 1]));
            }

            return points1.All(p1 => !p1.Item1.IsNaN && !p1.Item2.IsNaN) && points2.All(p2 => !p2.Item1.IsNaN && !p2.Item2.IsNaN && points1.Any(p1 => E(p1.Item1, p2.Item1) && E(p1.Item2, p2.Item2)));
        }

        public static bool PointsIn(Big[] array, params string[] points)
        {
            var points1 = new List<Tuple<Big, Big>>();
            var points2 = new List<Tuple<Big, Big>>();

            for (var n = 0; n < array.Length / 2; n++)
            {
                points1.Add(new(array[2 * n + 0], array[2 * n + 1]));
            }

            for (var n = 0; n < points.Length / 2; n++)
            {
                points2.Add(new(Big.Parse(points[2 * n + 0]), Big.Parse(points[2 * n + 1])));
            }

            return points1.All(p1 => !p1.Item1.IsNaN && !p1.Item2.IsNaN) && points2.All(p2 => !p2.Item1.IsNaN && !p2.Item2.IsNaN && points1.Any(p1 => E(p1.Item1, p2.Item1) && E(p1.Item2, p2.Item2)));
        }
    }
}
