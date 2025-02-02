namespace Photon
{
    public static partial class Intersection
    {
        public static bool IsPointInRectangle(in Big x, in Big y, in Big rx, in Big ry, in Big width, in Big height) => x >= rx && y >= ry && x <= rx + width && y <= ry + height;
        public static bool IsPointIn(in Big x, in Big y, in Rectangle r) => IsPointInRectangle(x, y, r.X, r.Y, r.Width, r.Height);
        public static bool In(this Point p, in Rectangle r) => IsPointInRectangle(p.X, p.Y, r.X, r.Y, r.Width, r.Height);            
    }
}
