using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace Photon.OpenGl
{
    public struct Vertex
    {
        public Vec3 Position;
        public Vec4 Color;
        public float PointSize;
        public Vertex(Vec3 position, Vec4 color, float pointSize = 1) 
        { 
            Position = position;
            Color = color;
            PointSize = pointSize;
        }
    }
}
