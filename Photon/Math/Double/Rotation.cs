using static System.Windows.Forms.AxHost;

namespace Photon
{
    public static partial class Rotation
    {
        public static void Circular(double ang, double cx, double cy, double r, out double x, out double y)
        {
            x = cx + r * Math.Cos(ang);
            y = cy + r * Math.Sin(ang);
        }

        public static void Circular(double ang, double cx, double cy, double r, out PointD p)
        {
            p = new PointD(cx + r * Math.Cos(ang), cy + r * Math.Sin(ang));
        }

        public static void Circular(double ang, in PointD cp, double r, out PointD p)
        {
            p = new PointD(cp.X + r * Math.Cos(ang), cp.Y + r * Math.Sin(ang));
        }

        public static void Circular(double ang, double cx, double cy, double r, out int x, out int y)
        {
            x = (int)(cx + r * Math.Cos(ang));
            y = (int)(cy + r * Math.Sin(ang));
        }

        public static void Circular(double ang, double cx, double cy, double r, out Pixel p)
        {
            p = new Pixel((int)(cx + r * Math.Cos(ang)), (int)(cy + r * Math.Sin(ang)));
        }

        public static void PointAt(this CircleD c, double ang, out double x, out double y)
        {
            Circular(ang, c.X, c.Y, c.R, out x, out y);
        }

        public static void PointAt(this CircleD c, double ang, out PointD p)
        {
            Circular(ang, c.X, c.Y, c.R, out double x, out double y);
            p = new PointD(x, y);
        }

        
        public static void AroundOrigin(double px, double py, double ang, out double x, out double y)
        {
            (var sin, var cos) = Math.SinCos(ang);
            x = px * cos - py * sin;
            y = py * cos + px * sin;
        }

        public static void Rotate(this PointD p, double ang, out PointD rotated)
        {
            AroundOrigin(p.X, p.Y, ang, out double x, out double y);
            rotated = new PointD(x, y);
        }


        public static void AroundPoint(double px, double py, double ang, double cx, double cy, out double x, out double y)
        {
            var s = Math.Sin(ang);
            var c = Math.Cos(ang);
            var x1 = px - cx;
            var y1 = py - cy;
            x = cx + x1 * c - y1 * s;
            y = cy + x1 * s + y1 * c;            
        }

        public static void AroundPoint(in PointD p, double ang, double cpx, double cpy, out double x, out double y)
        {
            AroundPoint(p.X, p.Y, ang, cpx, cpy, out x, out y);
        }

        public static void AroundPoint(in PointD p, double ang, in PointD cp, out double x, out double y)
        {
            AroundPoint(p.X, p.Y, ang, cp.X, cp.Y, out x, out y);
        }

        public static void Rotate(this PointD p, double ang, double cpx, double cpy, out double x, out double y)
        {
            AroundPoint(p.X, p.Y, ang, cpx, cpy, out x, out y);
        }

        public static void Rotate(this PointD p, double ang, double cpx, double cpy, out PointD rotated)
        {
            AroundPoint(p.X, p.Y, ang, cpx, cpy, out double x, out double y);
            rotated = new PointD(x, y);
        }

        public static void Rotate(this PointD p, double ang, in PointD cp, out PointD rotated)
        {
            AroundPoint(p.X, p.Y, ang, cp.X, cp.Y, out double x, out double y);
            rotated = new PointD(x, y);
        }


    }
}
