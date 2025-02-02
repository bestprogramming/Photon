using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace Photon
{
    public static partial class Geogebra
    {
        public static string Execute(params string[] commands)
        {
            return "Execute[{" + commands.Aggregate((c, n) => c + (c != "" && n != "" ? "," : "") + n) + "}]";
        }

        public static string SetValue(string suffix, double value)
        {
            return $"\"{suffix}={value}\"";
        }

        public static string SetValue(string suffix, string value)
        {
            return $"\"{suffix}={value}\"";
        }

        public static string SetFilling(string suffix, float opacity)
        {
            return $"\"SetFilling({suffix}, {opacity})\"";
        }

        public static string SetColor(string suffix, float red, float green, float blue)
        {
            return $"\"SetColor({suffix}, {red}, {green}, {blue})\"";
        }

        public static string SetColor(string suffix, float red, float green, float blue, float opacity)
        {
            return SetColor(suffix, red, green, blue) + "," + SetFilling(suffix, opacity);
        }

        public static string SetColor(string suffix, in Color color)
        {
            return SetColor(suffix, color.R / 255f, color.G / 255f, color.B / 255f);
        }

        public static string SetColor(string suffix, in Vec4 color)
        {
            return SetColor(suffix, color.X, color.Y, color.Z);
        }


        public static string SetDynamicColor(string suffix, float red, float green, float blue, float opacity)
        {
            return $"\"SetDynamicColor({suffix}, {red}, {green}, {blue}, {opacity})\"";
        }

        public static string SetDynamicColor(string suffix, in Color color)
        {
            return SetDynamicColor(suffix, color.R / 255f, color.G / 255f, color.B / 255f, color.A / 255f);
        }

        public static string SetDynamicColor(string suffix, in Vec4 color)
        {
            return SetDynamicColor(suffix, color.X, color.Y, color.Z, color.W);
        }


        public static string SetConditionToShowObject(string suffix, bool show)
        {
            return $"\"SetConditionToShowObject({suffix}, {show})\"";
        }


        public static string Eq(string eqExpression, string suffix)
        {
            return $"\"{suffix}: ({eqExpression})\"";
        }

        public static string Point(double x, double y, string suffix = "P")
        {
            return $"\"{suffix}=({x},{y})\"";
        }

        public static string Point(in Point p, string suffix = "P")
        {
            return Point(p.X, p.Y, suffix);
        }

        public static string Point(double x, double y, double z, string suffix = "P")
        {
            return $"\"{suffix}=({x},{y},{z})\"";
        }

        public static string Point(in Point3 p, string suffix = "P")
        {
            return Point(p.X, p.Y, p.Z, suffix);
        }

        public static string Point(in Vec3 v, string suffix = "P")
        {
            return Point(v.X, v.Y, v.Z, suffix);
        }


        public static string SetPointSize(string suffix, int size)
        {
            return $"\"SetPointSize({suffix}, {size})\"";
        }


        public static string Vector(double x, double y, string suffix = "v")
        {
            return $"\"{suffix}=({x},{y})\"";
        }

        public static string Vector(in Point p, string suffix = "P")
        {
            return Vector(p.X, p.Y, suffix);
        }

        public static string Vector(double x, double y, double z, string suffix = "v")
        {
            return $"\"{suffix}=({x},{y},{z})\"";
        }

        public static string Vector(in Point3 p, string suffix = "P")
        {
            return Vector(p.X, p.Y, p.Z, suffix);
        }


        public static string Vector(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            return $"Vector(({x1},{y1},{z1}),({x2},{y2},{z2}))";
        }


        public static string UnitVector(string expression)
        {
            return $"UnitVector({expression})";
        }


        public static string Translate(string vectorExpression, double x, double y, double z)
        {
            return $"Translate({vectorExpression}, ({x},{y},{z}))";
        }

        public static string Translate(string vectorExpression, double x, double y, double z, string suffix = "v")
        {
            return $"\"{suffix}=Translate({vectorExpression}, ({x},{y},{z}))\"";
        }

        public static string Translate(string vectorExpression, in Point3 p, string suffix = "v")
        {
            return Translate(vectorExpression, p.X, p.Y, p.Z, suffix);
        }


        public static string Line(double x1, double y1, double x2, double y2, string suffix = "l")
        {
            return $"\"{suffix}=Line(({x1},{y1}),({x2},{y2}))\"";
        }

        public static string Line(in Point p1, in Point p2, string suffix = "l")
        {
            return Line(p1.X, p1.Y, p2.X, p2.Y, suffix);
        }

        public static string Line(double x1, double y1, double z1, double x2, double y2, double z2, string suffix = "l")
        {
            return $"\"{suffix}=Line(({x1},{y1},{z1}),({x2},{y2},{z2}))\"";
        }

        public static string Line(in Point3 p1, in Point3 p2, string suffix = "l")
        {
            return Line(p1.X, p1.Y, p1.Z, p2.X, p2.Y, p2.Z, suffix);
        }

        public static string Line(in Segment s, string suffix = "l")
        {
            return Line(s.X1, s.Y1, s.X2, s.Y2, suffix);
        }

        public static string Line(string suffix1, string suffix2, string suffix)
        {
            return $"\"{suffix}=Line({suffix1},{suffix2})\"";
        }

        public enum LineStyle : byte { Full = 0, DashedLong = 1, DashedShort = 2, Dotted = 3, DashDot = 4 };

        public static string SetLineStyle(string expression, LineStyle style)
        {
            return $"\"SetLineStyle({expression},{(byte)style})\"";
        }

        public static string SetLineThickness(string expression, int value)
        {
            return $"\"SetLineThickness({expression},{value})\"";
        }


        public static string SegmentXy(double x1, double y1, double x2, double y2, string suffix = "s")
        {
            return $"\"{suffix}=Segment(({x1},{y1}),({x2},{y2}))\"";
        }

        public static string SegmentXy(in Point p1, in Point p2, string suffix = "s")
        {
            return SegmentXy(p1.X, p1.Y, p2.X, p2.Y, suffix);
        }

        public static string SegmentXy(in Segment s, string suffix = "s")
        {
            return SegmentXy(s.X1, s.Y1, s.X2, s.Y2, suffix);
        }

        public static string SegmentXy(string suffix1, string suffix2, string suffix = "s")
        {
            return $"\"{suffix}=Segment({suffix1},{suffix2})\"";
        }

        public static string SegmentYz(double x1, double y1, double x2, double y2, string suffix = "s")
        {
            return $"\"{suffix}=Rotate(Rotate(Segment(({x1},{y1}),({x2},{y2})), pi/2, zAxis), pi/2, yAxis)\"";
        }

        public static string SegmentYz(in Point p1, in Point p2, string suffix = "s")
        {
            return SegmentYz(p1.X, p1.Y, p2.X, p2.Y, suffix);
        }

        public static string SegmentYz(in Segment s, string suffix = "s")
        {
            return SegmentYz(s.X1, s.Y1, s.X2, s.Y2, suffix);
        }

        public static string SegmentZx(double x1, double y1, double x2, double y2, string suffix = "s")
        {
            return $"\"{suffix}=Rotate(Rotate(Segment(({x1},{y1}),({x2},{y2})), -pi/2, yAxis), -pi/2, zAxis)\"";
        }

        public static string SegmentZx(in Point p1, in Point p2, string suffix = "s")
        {
            return SegmentZx(p1.X, p1.Y, p2.X, p2.Y, suffix);
        }

        public static string SegmentZx(in Segment s, string suffix = "s")
        {
            return SegmentZx(s.X1, s.Y1, s.X2, s.Y2, suffix);
        }

        public static string Segment(double x1, double y1, double z1, double x2, double y2, double z2, string suffix = "s")
        {
            return $"\"{suffix}=Segment(({x1},{y1},{z1}),({x2},{y2},{z2}))\"";
        }

        public static string Segment(in Point3 p1, in Point3 p2, string suffix = "s")
        {
            return Segment(p1.X, p1.Y, p1.Z, p2.X, p2.Y, p2.Z, suffix);
        }


        public static string PolygonXy(PointD[] points, string suffix = "poly")
        {
            return $"\"{suffix}=Polygon({points.Aggregate("", (c, n) => c + (c != "" ? "," : "") + $"({n.X},{n.Y})")})\"";
        }


        public static string Ray(double x1, double y1, double x2, double y2, string suffix = "r")
        {
            return $"\"{suffix}=Ray(({x1},{y1}),({x2},{y2}))\"";
        }

        public static string Ray(in Point p1, in Point p2, string suffix = "r")
        {
            return Ray(p1.X, p1.Y, p2.X, p2.Y, suffix);
        }

        public static string Ray(in Segment s, string suffix = "r")
        {
            return Ray(s.X1, s.Y1, s.X2, s.Y2, suffix);
        }


        public static string Ray(double x1, double y1, double z1, double x2, double y2, double z2, string suffix = "r")
        {
            return $"\"{suffix}=Ray(({x1},{y1},{z1}),({x2},{y2},{z2}))\"";
        }

        public static string Ray(in Point3 p1, in Point3 p2, string suffix = "r")
        {
            return Ray(p1.X, p1.Y, p1.Z, p2.X, p2.Y, p2.Z, suffix);
        }


        public static string PerpendicularLine(string suffix1, string suffix2, string suffix)
        {
            return $"\"{suffix}=PerpendicularLine({suffix1},{suffix2})\"";
        }


        public static string Circle(double x, double y, double r, string suffix = "c")
        {
            return $"\"{suffix}=Circle(({x},{y}),{r})\"";
        }

        public static string Circle(in Point p, double r, string suffix = "c")
        {
            return Circle(p.X, p.Y, r, suffix);
        }


        public static string Sphere(double x, double y, double z, double r, string suffix = "s")
        {
            return $"\"{suffix}=Sphere(({x},{y},{z}),{r})\"";
        }

        public static string Sphere(in Sphere s, string suffix = "s")
        {
            return Sphere(s.X, s.Y, s.Z, s.R, suffix);
        }


        public static string Intersect(string suffix1, string suffix2, string suffix = "i")
        {
            return $"\"{suffix}=Intersect({suffix1},{suffix2})\"";
        }


        public static string IntersectConic(string suffix1, string suffix2, string suffix = "ic")
        {
            return $"\"{suffix}=IntersectConic({suffix1},{suffix2})\"";
        }

    }
}
