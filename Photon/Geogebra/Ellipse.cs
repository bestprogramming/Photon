using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photon
{
    public static partial class Geogebra
    {
        public static string EllipseXy(double x, double y, double a, double b, double rotate, string suffix = "E")
        {
            if (Conversion.EllipseToSegment(x, y, a, b, rotate, out Segment s))
            {
                return SegmentXy(s, suffix);
            }
            return $"\"cos{suffix}=cos({rotate})\",\"sin{suffix}=sin({rotate})\",\"x{suffix}={x}\",\"y{suffix}={y}\",\"fa{suffix}=cos{suffix}(x-x{suffix}) + sin{suffix}(y-y{suffix})\",\"fb{suffix}=sin{suffix}(x-x{suffix}) - cos{suffix}(y-y{suffix})\",\"{suffix}:(fa{suffix}^2/{a}^2 + fb{suffix}^2/{b}^2 = 1)\"";
        }

        public static string EllipseXy(in Ellipse e, string suffix = "E")
        {
            return EllipseXy(e.X, e.Y, e.A, e.B, e.Rotate, suffix);
        }

        public static string EllipseYz(double x, double y, double a, double b, double rotate, string suffix = "E")
        {
            if (Conversion.EllipseToSegment(x, y, a, b, rotate, out Segment s))
            {
                return SegmentYz(s, suffix);
            }
            return $"\"cos{suffix}=cos({rotate})\",\"sin{suffix}=sin({rotate})\",\"x{suffix}={x}\",\"y{suffix}={y}\",\"fa{suffix}=cos{suffix}(x-x{suffix}) + sin{suffix}(y-y{suffix})\",\"fb{suffix}=sin{suffix}(x-x{suffix}) - cos{suffix}(y-y{suffix})\",\"{suffix}=Rotate(Rotate((fa{suffix}^2/{a}^2 + fb{suffix}^2/{b}^2 = 1), pi/2, zAxis), pi/2, yAxis)\"";
        }

        public static string EllipseYz(in Ellipse e, string suffix = "E")
        {
            return EllipseYz(e.X, e.Y, e.A, e.B, e.Rotate, suffix);
        }

        public static string EllipseZx(double x, double y, double a, double b, double rotate, string suffix = "E")
        {
            if (Conversion.EllipseToSegment(x, y, a, b, rotate, out Segment s))
            {
                return SegmentZx(s, suffix);
            }
            return $"\"cos{suffix}=cos({rotate})\",\"sin{suffix}=sin({rotate})\",\"x{suffix}={x}\",\"y{suffix}={y}\",\"fa{suffix}=cos{suffix}(x-x{suffix}) + sin{suffix}(y-y{suffix})\",\"fb{suffix}=sin{suffix}(x-x{suffix}) - cos{suffix}(y-y{suffix})\",\"{suffix}=Rotate(Rotate((fa{suffix}^2/{a}^2 + fb{suffix}^2/{b}^2 = 1), -pi/2, yAxis), -pi/2, zAxis)\"";
        }

        public static string EllipseZx(in Ellipse e, string suffix = "E")
        {
            return EllipseZx(e.X, e.Y, e.A, e.B, e.Rotate, suffix);
        }
    }
}
