using System.Xml.Serialization;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    //[XmlRoot(Namespace = "Photon.OpenGl")]
    [XmlInclude(typeof(RotateSetting))]
    [XmlInclude(typeof(CloneVibrateSetting))]
    [XmlInclude(typeof(PointSetting))]
    [XmlInclude(typeof(CircleSetting))]
    [XmlInclude(typeof(CylinderSetting))]
    [XmlInclude(typeof(CylindricalShellSetting))]
    [XmlInclude(typeof(DiscSetting))]
    [XmlInclude(typeof(EllipsoidSetting))]
    [XmlInclude(typeof(EllipsoidalShellSetting))]
    [XmlInclude(typeof(LineSetting))]
    [XmlInclude(typeof(QuadrangularSetting))]
    [XmlInclude(typeof(RectangleSetting))]
    [XmlInclude(typeof(RectangularAreaSetting))]
    [XmlInclude(typeof(SphereSetting))]
    [XmlInclude(typeof(SphericalShellSetting))]
    [XmlInclude(typeof(SpheroidSetting))]
    [XmlInclude(typeof(SpheroidicalShellSetting))]
    [XmlInclude(typeof(PolygonSetting))]
    [XmlInclude(typeof(PolygonAreaSetting))]
    [XmlInclude(typeof(PolygonPrismSetting))]
    public class BaseSetting
    {
        public int Weight;
        public bool Rotate;
        public bool CloneVibrate;
        public bool OrbitVibrate;
        public RotateSetting? RotateSetting;
        public CloneVibrateSetting? CloneVibrateSetting;
        public OrbitVibrateSetting? OrbitVibrateSetting;
        public bool Selected;

        public virtual void Set(IUctShape uctShape) { }

        public virtual Shape GetShape()
        {
            throw new NotImplementedException();
        }

        public virtual void AddTo(Scene scene) { }

        public void RotateAndVibrate(Shape shape)
        {
            if (Rotate && RotateSetting != null && RotateSetting.Angle != 0)
            {
                shape.Rotate(RotateSetting.Angle, RotateSetting.X1, RotateSetting.Y1, RotateSetting.Z1, RotateSetting.X2, RotateSetting.Y2, RotateSetting.Z2);
            }

            if (CloneVibrate && CloneVibrateSetting != null && CloneVibrateSetting.Count > 0 && CloneVibrateSetting.Radius > 0)
            {
                shape.CloneVibrate(CloneVibrateSetting.Radius, CloneVibrateSetting.Count, CloneVibrateSetting.VibrateBy);
            }
        }

        public void AddTo(Scene scene, Shape shape)
        {
            RotateAndVibrate(shape);

            if (OrbitVibrate && OrbitVibrateSetting != null && OrbitVibrateSetting.Count > 0 && OrbitVibrateSetting.Radius > 0)
            {
                foreach (var vertex in shape.Vertices)
                {
                    var color = new Vec4(1.0f, 1.0f, 0.0f, 0.5f);
                    scene.Shapes.Add(new Solid.Sphere(vertex.Position.X, vertex.Position.Y, vertex.Position.Z, (float)OrbitVibrateSetting.Radius, 3, color));

                    //foreach (var v in Helper.GetVibrations(vertex.Position.X, vertex.Position.Y, vertex.Position.Z, OrbitVibrateSetting.Radius, OrbitVibrateSetting.Count, OrbitVibrateSetting.VibrateBy))
                    //{

                    //}
                }
            }
        }
    }
}
