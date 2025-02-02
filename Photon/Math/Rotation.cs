using static System.Windows.Forms.AxHost;

namespace Photon
{
    public static partial class Rotation
    {
        public static void Circular(in Big ang, in Big cx, in Big cy, in Big r, out Big x, out Big y)
        {
            x = cx + r * Big.Cos(ang);
            y = cy + r * Big.Sin(ang);
        }

        public static void Circular(in Big ang, in Big cx, in Big cy, in Big r, out Point p)
        {
            p = new Point(cx + r * Big.Cos(ang), cy + r * Big.Sin(ang));
        }

        public static void Circular(in Big ang, in Point cp, in Big r, out Point p)
        {
            p = new Point(cp.X + r * Big.Cos(ang), cp.Y + r * Big.Sin(ang));
        }

        public static void Circular(in Big ang, in Big cx, in Big cy, in Big r, out int x, out int y)
        {
            x = (int)(cx + r * Big.Cos(ang));
            y = (int)(cy + r * Big.Sin(ang));
        }

        public static void Circular(in Big ang, in Big cx, in Big cy, in Big r, out Pixel p)
        {
            p = new Pixel((int)(cx + r * Big.Cos(ang)), (int)(cy + r * Big.Sin(ang)));
        }

        public static void PointAt(this Circle c, in Big ang, out Big x, out Big y)
        {
            Circular(ang, c.X, c.Y, c.R, out x, out y);
        }

        public static void PointAt(this Circle c, in Big ang, out Point p)
        {
            Circular(ang, c.X, c.Y, c.R, out Big x, out Big y);
            p = new Point(x, y);
        }

        
        public static void AroundOrigin(in Big px, in Big py, in Big ang, out Big x, out Big y)
        {
            Big.SinCos(ang, out Big sin, out Big cos);
            x = px * cos - py * sin;
            y = py * cos + px * sin;
        }

        public static void Rotate(this Point p, in Big ang, out Point rotated)
        {
            AroundOrigin(p.X, p.Y, ang, out Big x, out Big y);
            rotated = new Point(x, y);
        }


        public static void AroundPoint(in Big px, in Big py, in Big ang, in Big cx, in Big cy, out Big x, out Big y)
        {
            var s = Big.Sin(ang);
            var c = Big.Cos(ang);
            var x1 = px - cx;
            var y1 = py - cy;
            x = cx + x1 * c - y1 * s;
            y = cy + x1 * s + y1 * c;            
        }

        public static void AroundPoint(in Point p, in Big ang, in Big cpx, in Big cpy, out Big x, out Big y)
        {
            AroundPoint(p.X, p.Y, ang, cpx, cpy, out x, out y);
        }

        public static void AroundPoint(in Point p, in Big ang, in Point cp, out Big x, out Big y)
        {
            AroundPoint(p.X, p.Y, ang, cp.X, cp.Y, out x, out y);
        }

        public static void Rotate(this Point p, in Big ang, in Big cpx, in Big cpy, out Big x, out Big y)
        {
            AroundPoint(p.X, p.Y, ang, cpx, cpy, out x, out y);
        }

        public static void Rotate(this Point p, in Big ang, in Big cpx, in Big cpy, out Point rotated)
        {
            AroundPoint(p.X, p.Y, ang, cpx, cpy, out Big x, out Big y);
            rotated = new Point(x, y);
        }

        public static void Rotate(this Point p, in Big ang, in Point cp, out Point rotated)
        {
            AroundPoint(p.X, p.Y, ang, cp.X, cp.Y, out Big x, out Big y);
            rotated = new Point(x, y);
        }
    }
}
