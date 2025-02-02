namespace Photon
{
    public static partial class Intersection
    {
        public static bool IsPointInPolygon(in Big x, in Big y, Point[] points)
        {
            var ret = false;
            int i, j;
            for (i = 0, j = points.Length - 1; i < points.Length; j = i++)
            {
                if ((((points[i].Y <= y) && (y < points[j].Y)) ||
                     ((points[j].Y <= y) && (y < points[i].Y))) &&
                    (x < (points[j].X - points[i].X) * (y - points[i].Y) / (points[j].Y - points[i].Y) + points[i].X))
                    ret = !ret;
            }

            return ret;
        }
    }
}
