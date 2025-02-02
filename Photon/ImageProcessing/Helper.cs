using Vec4 = System.Numerics.Vector4;

namespace Photon
{
    public static partial class Helper
    {
        public static Pen AxisPen = new (Color.FromArgb(20, 20, 20));

        public static Pen[] GetPens(float width)
        {
            return new[]
            {
                new Pen(Color.White, width),
                new Pen(Color.Red, width),
                new Pen(Color.Green, width),
                new Pen(Color.Blue, width),
                new Pen(Color.Aqua, width),
                new Pen(Color.Cyan, width),
            };
        }

        public static Rgb HslToRgb(Hsl hsl)
        {
            byte r;
            byte g;
            byte b;

            if (hsl.S == 0)
            {
                r = g = b = (byte)(hsl.L * 255);
            }
            else
            {
                float v1, v2;
                float hue = (float)hsl.H / 360;

                v2 = (hsl.L < 0.5) ? (hsl.L * (1 + hsl.S)) : ((hsl.L + hsl.S) - (hsl.L * hsl.S));
                v1 = 2 * hsl.L - v2;

                r = (byte)(255 * HueToRgb(v1, v2, hue + (1.0f / 3)));
                g = (byte)(255 * HueToRgb(v1, v2, hue));
                b = (byte)(255 * HueToRgb(v1, v2, hue - (1.0f / 3)));
            }

            return new Rgb(r, g, b);
        }

        public static Rgb ToRgb(this Color c)
        {
            return new Rgb(c.R, c.G, c.B);
        }

        public static float HueToRgb(float v1, float v2, float vH)
        {
            if (vH < 0)
                vH += 1;

            if (vH > 1)
                vH -= 1;

            if ((6 * vH) < 1)
                return (v1 + (v2 - v1) * 6 * vH);

            if ((2 * vH) < 1)
                return v2;

            if ((3 * vH) < 2)
                return (v1 + (v2 - v1) * ((2.0f / 3) - vH) * 6);

            return v1;
        }

        public static bool RbgEquals(this Color c1, Color c2)
        {
            return c1.R == c2.R && c1.G == c2.G && c1.B == c2.B;
        }

        public static string ToArgbHex(this Color c) => $"#{c.A:X2}{c.R:X2}{c.G:X2}{c.B:X2}";
        public static string ToArgbHex(this Vec4 c) => $"#{(int)Math.Round(c.W * 255):X2}{(int)Math.Round(c.X * 255):X2}{(int)Math.Round(c.Y * 255):X2}{(int)Math.Round(c.Z * 255):X2}";


        private static IEnumerable<Point> GetEllipsePoints(double x, double y, double a, double b)
        {
            double dx, dy, d1, d2, i, j;
            i = 0;
            j = b;

            d1 = b * b - a * a * b + 0.25f * a * a;
            dx = 2 * b * b * i;
            dy = 2 * a * a * j;
            
            while (dx < dy)
            {
                yield return new Point(i + x, j + y);
                yield return new Point(-i + x, j + y);
                yield return new Point(i + x, -j + y);
                yield return new Point(-i + x, -j + y);

                if (d1 < 0)
                {
                    i++;
                    dx += 2 * b * b;
                    d1 += dx + b * b;
                }
                else
                {
                    i++;
                    j--;
                    dx += 2 * b * b;
                    dy -= 2 * a * a;
                    d1 += dx - dy + b * b;
                }
            }

            d2 = (b * b * ((i + 0.5f) * (i + 0.5f)))
                + (a * a * ((j - 1) * (j - 1)))
                - (a * a * b * b);

            while (j >= 0)
            {
                yield return new Point(i + x, j + y);
                yield return new Point(-i + x, j + y);
                yield return new Point(i + x, -j + y);
                yield return new Point(-i + x, -j + y);

                if (d2 > 0)
                {
                    j--;
                    dy -= 2 * a * a;
                    d2 += a * a - dy;
                }
                else
                {
                    j--;
                    i++;
                    dx += 2 * b * b;
                    dy -= 2 * a * a;
                    d2 += dx - dy + a * a;
                }
            }
        }

        public static PointF Point(this Graphics g, double x, double y)
        {
            return new PointF((float)(g.VisibleClipBounds.Width / 2 + x), (float)(g.VisibleClipBounds.Height / 2 - y));
        }

        public static void Circle(this Graphics g, Pen pen, double cx, double cy, double r)
        {
            var p = g.Point(cx - r, cy + r);
            if (g.ClipBounds.Contains(p))
            {
                var length = (float)(2 * r);
                g.DrawEllipse(pen, p.X, p.Y, length, length);
            }
        }

        public static void FillCircle(this Graphics g, Brush brush, double cx, double cy, double r)
        {
            var p = g.Point(cx - r, cy + r);
            if (g.ClipBounds.Contains(p))
            {
                var length = (float)(2 * r);
                g.FillEllipse(brush, p.X, p.Y, length, length);
            }
        }

        public static void FillCircle(this Graphics g, Brush brush, in Point p, double r)
        {
            FillCircle(g, brush, p.X, p.Y, r);
        }

        public static void Ellipse(this Graphics g, Pen pen, double x, double y, double a, double b, double rotate)
        {
            (double ang, double r) = b > a && a / b <= 1E-6 ? (rotate + Const.PiOver2, b) : a > b && b / a <= 1E-6 ? (rotate, a) : (double.NaN, double.NaN);

            if (!double.IsNaN(ang))
            {
                var rotX = r * Math.Cos(ang);
                var rotY = r * Math.Sin(ang);
                var x1 = x - rotX;
                var y1 = y - rotY;
                var x2 = x + rotX;
                var y2 = y + rotY;

                g.Line(pen, x1, y1, x2, y2);
            }
            else
            {
                var s = Math.Sin(rotate);
                var c = Math.Cos(rotate);

                var brush = new SolidBrush(pen.Color);
                foreach (var p in GetEllipsePoints(x, y, a, b))
                {
                    var x1 = p.X - x;
                    var y1 = p.Y - y;
                    var rotX = x + x1 * c - y1 * s;
                    var rotY = y + x1 * s + y1 * c;

                    var pp = g.Point(rotX, rotY);
                    if (g.VisibleClipBounds.Contains(pp))
                    {
                        g.FillRectangle(brush, pp.X, pp.Y, pen.Width, pen.Width);
                    }
                }
            }
        }

        public static void Ellipse(this Graphics g, Pen pen, in Ellipse e)
        {
            Ellipse(g, pen, e.X, e.Y, e.A, e.B, e.Rotate);
        }

        public static void SetPixel(this Bitmap bmp, Pen pen, double x, double y)
        {
            x += bmp.Width / 2;
            y = bmp.Height / 2 - y;            
            if (x >= 0 && y >= 0 && x < bmp.Width && y < bmp.Height)
            {
                bmp.SetPixel((int)x, (int)y, pen.Color);
            }
        }

        public static void Rectangle(this Graphics g, Pen pen, double x, double y, double width, double height)
        {
            var p = g.Point(x, y + height);
            if (g.ClipBounds.Contains(p))
            {
                g.DrawRectangle(pen, p.X, p.Y, (float)width, (float)height);
            }
        }

        public static void SetPixel(this Graphics g, Brush brush, double x, double y)
        {
            var p = g.Point(x, y);
            if (g.ClipBounds.Contains(p))
            {
                g.FillRectangle(brush, p.X, p.Y, 1, 1);
            }
        }

        public static void Rectangle(this Graphics g, Pen pen, in Rectangle r)
        {
            var p = g.Point(r.Left, r.Top);
            if (g.ClipBounds.Contains(p))
            {
                g.DrawRectangle(pen, p.X, p.Y, (float)r.Width, (float)r.Height);
            }
        }

        public static void FillRectangle(this Graphics g, Brush brush, double x, double y, double width, double height)
        {
            var p = g.Point(x, y + height);
            if (g.ClipBounds.Contains(p))
            {
                g.FillRectangle(brush, p.X, p.Y, (float)width, (float)height);
            }
        }

        public static void Line(this Graphics g, Pen pen, double x1, double y1, double x2, double y2)
        {
            var p1 = g.Point(x1, y1);
            var p2 = g.Point(x2, y2);

            if (g.ClipBounds.Contains(p1) && g.ClipBounds.Contains(p2))
            {
                g.DrawLine(pen, p1.X, p1.Y, p2.X, p2.Y);
            }
        }
    }

}
