namespace Photon
{
    public static partial class Intersection
    {
        public static bool IsCircleInRectangle(in Big cx, in Big cy, in Big r, in Big rx, in Big ry, in Big width, in Big height) => cx - r >= rx && cy - r >= ry && cx + r <= rx + width && cy + r <= ry + height;

        public static bool IsCircleInOrIntersectRectangle(in Big cx, in Big cy, in Big r, in Big rx, in Big ry, in Big width, in Big height)
        {
            if (IsCircleInRectangle(cx, cy, r, rx, ry, width, height)) return true;
            return 
                IsCircleAndHorizontalSegmentIntersect(cx, cy, r, rx, ry, width) &&
                IsCircleAndVerticalSegmentIntersect(cx, cy, r, rx, ry, height) && 
                IsCircleAndHorizontalSegmentIntersect(cx, cy, r, rx, ry + height, width) &&
                IsCircleAndVerticalSegmentIntersect(cx, cy, r, rx + width, ry, height);
        }

        public static bool InOrIntersect(this Circle c, in Rectangle r)
        {
            return IsCircleInOrIntersectRectangle(c.X, c.Y, c.R, r.X, r.Y, r.Width, r.Height);
        }
    }
}
