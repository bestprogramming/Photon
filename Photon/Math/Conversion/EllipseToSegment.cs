namespace Photon
{
    public static partial class Conversion
    {
        public static bool EllipseToSegment(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, out Big x1, out Big y1, out Big x2, out Big y2)
        {
            if (eb == 0)
            {
                var dx = ea * Big.Cos(rotate);
                var dy = ea * Big.Sin(rotate);
                (x1, y1, x2, y2) = (ex + dx, ey + dy, ex - dx, ey - dy);
                return true;
            }

            if (ea == 0)
            {
                var dx = -eb * Big.Sin(rotate); //cos(x + π/2) = –sinx
                var dy = eb * Big.Cos(rotate); //sin(x + π/2) = cosx
                (x1, y1, x2, y2) = (ex + dx, ey + dy, ex - dx, ey - dy);
                return true;
            }

            (x1, y1, x2, y2) = (Big.NaN, Big.NaN, Big.NaN, Big.NaN);
            return false;
        }

        public static bool EllipseToSegment(in Big ex, in Big ey, in Big ea, in Big eb, in Big rotate, out Segment s)
        {
            s = Segment.NaN;
            return EllipseToSegment(ex, ey, ea, eb, rotate, out s.X1, out s.Y1, out s.X2, out s.Y2);
        }
    }
}
