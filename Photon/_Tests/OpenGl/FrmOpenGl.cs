using Photon.FlatScreen;
using Photon.FlatScreenVector;
using Photon.OpenGl;
using Photon.Space;
using Photon.SpaceVector;
using Photon.SphericalScreen;
using Photon.SphericalScreenVector;
using Photon.TestIntersection;
using Photon.TestPacking;
using System.Diagnostics;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace Photon.TestOpenGl
{
    public partial class FrmOpenGl : Form
    {
        private Scene? scene;
        public FrmOpenGl()
        {
            InitializeComponent();
        }

        private void FrmOpenGl_Load(object sender, EventArgs e)
        {
            PnlFill.Focus();
        }

        private void Smi_Click(object sender, EventArgs e)
        {
            if (sender == SmiSave)
            {
                FormSetting.Write(FormSetting.Get(this), $"{nameof(FrmOpenGl)}.xml");
            }
            else if (sender == SmiLoad)
            {
                var setting = FormSetting.Read($"{nameof(FrmOpenGl)}.xml");
                FormSetting.Set(this, setting);
            }

            else if (sender == SmiPackingCirclesInACircle)
            {
                new FrmPackingCirclesInACircle().Show();
            }
            else if (sender == SmiPackingCirclesInASquare)
            {
                new FrmPackingCirclesInASquare().Show();
            }
            else if (sender == SmiPackingCirclesInARectangle)
            {
                new FrmPackingCirclesInARectangle().Show();
            }

            else if (sender == SmiQuadratic)
            {
                new FrmQuadratic().Show();
            }
            else if (sender == SmiCubic)
            {
                new FrmCubic().Show();
            }
            else if (sender == SmiQuartic)
            {
                new FrmQuartic().Show();
            }

            else if (sender == SmiCircleAndSegment)
            {
                new FrmCircleAndSegment().Show();
            }
            else if (sender == SmiTwoCircles)
            {
                new FrmTwoCircles().Show();
            }

            else if (sender == SmiEllipseAndTangentLine)
            {
                new FrmEllipseAndTangentLine().Show();
            }
            else if (sender == SmiEllipseAndSegment)
            {
                new FrmEllipseAndSegment().Show();
            }
            else if (sender == SmiEllipseAndTangentCircle)
            {
                new FrmEllipseAndTangentCircle().Show();
            }
            else if (sender == SmiEllipseAndCircle)
            {
                new FrmEllipseAndCircle().Show();
            }
            else if (sender == SmiEllipseAndTangentEllipse)
            {
                new FrmEllipseAndTangentEllipse().Show();
            }
            else if (sender == SmiTwoEllipses)
            {
                new FrmTwoEllipses().Show();
            }

            else if (sender == SmiTwoSegments)
            {
                new FrmTwoSegments().Show();
            }

            else if (sender == SmiOpenGl)
            {
                new FrmOpenGl().Show();
            }
            else if (sender == SmiTwoCircle3Projections)
            {
                Process.Start("Photon.exe", "TwoCircle3Projections");
            }

            else if (sender == SmiFlatScreen)
            {
                new FrmFlatScreen().Show();
            }
            else if (sender == SmiFlatScreenVector)
            {
                new FrmFlatScreenVector().Show();
            }
            else if (sender == SmiSphericalScreen)
            {
                new FrmSphericalScreen().Show();
            }
            else if (sender == SmiSphericalScreenVector)
            {
                new FrmSphericalScreenVector().Show();
            }
            else if (sender == SmiSpace)
            {
                new FrmSpace().Show();
            }
            else if (sender == SmiSpaceVector)
            {
                new FrmSpaceVector().Show();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var scene = GetScene();
            scene.Save("scene.rnpho");
            Process.Start("Photon.exe", $"--path \"scene.rnpho\" --title \"OpenGL Demo\"{(ChbUcs.Checked ? " --ucs" : "")}");
        }

        private void BtnSaveScene_Click(object sender, EventArgs e)
        {
            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                var scene = GetScene();
                scene.Save(Sfd.FileName);
            }

        }

        public Scene GetScene()
        {
            scene = new Scene();

            if (ChbCube.Checked)
            {
                var cube = new Cube();
                cube.Scale(new(0.02f, 0.02f, 0.02f), Vec3.Zero);
                cube.Translate(new(0.1f, 0.1f, 0.1f));
                scene.Shapes.Add(cube);
            }

            if (ChbPoint.Checked)
            {
                var point = new OpenGl.Point(0.02, 0.03, 0.1, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(point);
            }

            if (ChbLine.Checked)
            {
                var line = new OpenGl.Line(0, 0, 0, 0.1, 0.1, 0.1, 100, true, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(line);
            }

            if (ChbRectangle.Checked)
            {
                var rectangle = new OpenGl.Rectangle(0, 0, 0, 0.03, 305, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(rectangle);
            }

            if (ChbRectangularArea.Checked)
            {
                var rectangularArea = new RectangularArea(0, 0, 0, 0.03, 305, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(rectangularArea);
            }

            if (ChbQuadrangular.Checked)
            {
                var quadrangular = new Quadrangular(0, 0, 0, 0.02, 0.03, 0.1, 62500, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(quadrangular);
            }

            if (ChbCircle.Checked)
            {
                var circle = new OpenGl.Circle(0, 0, 0, 0.03, 200, 0, Const.Pi2, false, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(circle);
            }

            if (ChbDisc.Checked)
            {
                var disc = new Disc(0, 0, 0, 0.03, 2000, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(disc);
            }

            if (ChbCylinder.Checked)
            {
                var cylinder = new Cylinder(0, 0, 0, 0.01, 0.1, 62500, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(cylinder);
            }

            if (ChbCylindricalShell.Checked)
            {
                var cylindricalShell = new CylindricalShell(0, 0, 0, 0.01, 0.1, 62500, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(cylindricalShell);
            }

            if (ChbSphere.Checked)
            {
                var sphere = new OpenGl.Sphere(0.001, 0.001, 0.001, 0.03, 1000, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(sphere);
            }

            if (ChbSphericalShell.Checked)
            {
                var sphericalShell = new SphericalShell(0.1, 0.1, 0.1, 0.03, 5000, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(sphericalShell);
            }

            if (ChbSpheroid.Checked)
            {
                var spheroid = new Spheroid(0, 0, 0, 0.2, 0.4, 62500, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(spheroid);
            }

            if (ChbSpheroidicalShell.Checked)
            {
                var spheroidicalShell = new SpheroidicalShell(0, 0, 0, 0.2, 0.4, 62500, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(spheroidicalShell);
            }

            if (ChbEllipsoid.Checked)
            {
                var ellipsoid = new Ellipsoid(0, 0, 0, 0.2, 0.3, 0.4, 62500, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(ellipsoid);
            }

            if (ChbEllipsoidalShell.Checked)
            {
                var ellipsoidalShell = new EllipsoidalShell(0, 0, 0, 0.2, 0.3, 0.4, 62500, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(ellipsoidalShell);
            }

            if (ChbCircle3.Checked)
            {
                var s1 = new Sphere(-0.03, 0, 0, 0.04);
                var s2 = new Sphere(0.03, 0, 0, 0.04);
                var s3 = new Sphere(0, 0.03, 0, 0.04);
                s1.Intersect(s2, out Circle3 ca);
                s1.Intersect(s3, out Circle3 cb);
                s2.Intersect(s3, out Circle3 cc);

                var circle3a = new OpenGl.Circle3(ca.X, ca.Y, ca.Z, ca.Ax, ca.Bx, ca.Ay, ca.By, ca.Az, ca.Bz, 500, 0, Big.Pi2, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(circle3a);

                var circle3b = new OpenGl.Circle3(cb.X, cb.Y, cb.Z, cb.Ax, cb.Bx, cb.Ay, cb.By, cb.Az, ca.Bz, 500, 0, Big.Pi2, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(circle3b);

                var circle3c = new OpenGl.Circle3(cc.X, cc.Y, cc.Z, cc.Ax, cc.Bx, cc.Ay, cc.By, cc.Az, ca.Bz, 500, 0, Big.Pi2, new Vec4(1.0f, 0.0f, 0.0f, 1.0f));
                scene.Shapes.Add(circle3c);
            }

            if (ChbPointSize.Checked)
            {
                var pointSize = 1.0f;
                var factor = 2.0f;
                var p1 = new OpenGl.Point(0.01, 0.01, 0, new Vec4(1.0f, 0.0f, 0.0f, 1.0f), pointSize * (1 + factor * 0));
                var p2 = new OpenGl.Point(-0.01, 0.01, 0, new Vec4(0.0f, 1.0f, 0.0f, 1.0f), pointSize * (1 + factor * 1));
                var p3 = new OpenGl.Point(-0.01, -0.01, 0, new Vec4(0.0f, 0.0f, 1.0f, 1.0f), pointSize * (1 + factor * 2));
                var p4 = new OpenGl.Point(0.01, -0.01, 0, new Vec4(1.0f, 1.0f, 1.0f, 1.0f), pointSize * (1 + factor * 3));

                scene.Shapes.AddRange(new[] { p1, p2, p3, p4 });
            }

            return scene;
        }
    }
}
