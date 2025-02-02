using System.Xml;
using System.Xml.Serialization;

namespace Photon.TestOpenGl
{
    public class FormSetting
    {
        public bool Ucs;
        public bool Cube;
        public bool Point;
        public bool Line;
        public bool Rectangle;
        public bool RectangularArea;
        public bool Quadrangular;
        public bool Circle;
        public bool Disc;
        public bool Cylinder;
        public bool CylindricalShell;
        public bool Sphere;
        public bool SphericalShell;
        public bool Spheroid;
        public bool SpheroidicalShell;
        public bool Ellipsoid;
        public bool EllipsoidalShell;
        public bool Circle3;
        public bool PointSize;

        public static FormSetting Get(FrmOpenGl frm)
        {
            return new FormSetting
            {
                Ucs = frm.ChbUcs.Checked,
                Cube = frm.ChbCube.Checked,
                Point = frm.ChbPoint.Checked,
                Line = frm.ChbLine.Checked,
                Rectangle = frm.ChbRectangle.Checked,
                RectangularArea = frm.ChbRectangularArea.Checked,
                Quadrangular = frm.ChbQuadrangular.Checked,
                Circle = frm.ChbCircle.Checked,
                Disc = frm.ChbDisc.Checked,
                Cylinder = frm.ChbCylinder.Checked,
                CylindricalShell = frm.ChbCylindricalShell.Checked,
                Sphere = frm.ChbSphere.Checked,
                SphericalShell = frm.ChbSphericalShell.Checked,
                Spheroid = frm.ChbSpheroid.Checked,
                SpheroidicalShell = frm.ChbSpheroidicalShell.Checked,
                Ellipsoid = frm.ChbEllipsoid.Checked,
                EllipsoidalShell = frm.ChbEllipsoidalShell.Checked,
                Circle3 = frm.ChbCircle3.Checked,
                PointSize = frm.ChbPointSize.Checked,
            };
        }

        public static void Set(FrmOpenGl frm, FormSetting fs)
        {
            frm.ChbUcs.Checked = fs.Ucs;
            frm.ChbCube.Checked = fs.Cube;
            frm.ChbPoint.Checked = fs.Point;
            frm.ChbLine.Checked = fs.Line;
            frm.ChbRectangle.Checked = fs.Rectangle;
            frm.ChbRectangularArea.Checked = fs.RectangularArea;
            frm.ChbQuadrangular.Checked = fs.Quadrangular;
            frm.ChbCircle.Checked = fs.Circle;
            frm.ChbDisc.Checked = fs.Disc;
            frm.ChbCylinder.Checked = fs.Cylinder;
            frm.ChbCylindricalShell.Checked = fs.CylindricalShell;
            frm.ChbSphere.Checked = fs.Sphere;
            frm.ChbSphericalShell.Checked = fs.SphericalShell;
            frm.ChbSpheroid.Checked = fs.Spheroid;
            frm.ChbSpheroidicalShell.Checked = fs.SpheroidicalShell;
            frm.ChbEllipsoid.Checked = fs.Ellipsoid;
            frm.ChbEllipsoidalShell.Checked = fs.EllipsoidalShell;
            frm.ChbCircle3.Checked = fs.Circle3;
            frm.ChbPointSize.Checked = fs.PointSize;
        }

        public static void Write(FormSetting fs, string path)
        {
            var serializer = new XmlSerializer(fs.GetType());
            var directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }
            using var writer = XmlWriter.Create(path);
            serializer.Serialize(writer, fs);
        }

        public static FormSetting Read(string path)
        {
            var serializer = new XmlSerializer(typeof(FormSetting));
            using var reader = XmlReader.Create(path);
            var fs = (FormSetting?)serializer.Deserialize(reader);
            return fs ?? new FormSetting();
        }
    }
}
