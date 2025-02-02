using Photon;
using Photon.OpenGl;
using System.Drawing;
using System.Numerics;
using Xunit.Abstractions;

namespace Tests
{
    public class GetVibrationsTest : BaseTest
    {
        public GetVibrationsTest(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void Sphere()
        {
            var vibrations = Helper.GetVibrations(0, 0, 0, 0.01, 100, VibrateBy.Sphere);
            var scene = new Scene();
            foreach (var vibration in vibrations)
            {
                scene.Shapes.Add(new Photon.OpenGl.Point(vibration.X, vibration.Y, vibration.Z, Color.White.ToVec4(), 1));
            }
            scene.Save("scene.rnpho");
        }

        [Fact]
        public void RandomSphere()
        {
            var vibrations = Helper.GetVibrations(0, 0, 0, 0.01, 100, VibrateBy.RandomSphere);
            var scene = new Scene();
            foreach(var vibration in vibrations)
            {
                scene.Shapes.Add(new Photon.OpenGl.Point(vibration.X, vibration.Y, vibration.Z, Color.White.ToVec4(), 1));
            }
            scene.Save("scene.rnpho");
        }

        [Fact]
        public void SphericalShell()
        {
            var vibrations = Helper.GetVibrations(0, 0, 0, 0.01, 100, VibrateBy.SphericalShell);
            var scene = new Scene();
            foreach (var vibration in vibrations)
            {
                scene.Shapes.Add(new Photon.OpenGl.Point(vibration.X, vibration.Y, vibration.Z, Color.White.ToVec4(), 1));
            }
            scene.Save("scene.rnpho");
        }

        [Fact]
        public void RandomSphericalShell()
        {
            var vibrations = Helper.GetVibrations(0, 0, 0, 0.01, 100, VibrateBy.RandomSphericalShell);
            var scene = new Scene();
            foreach (var vibration in vibrations)
            {
                scene.Shapes.Add(new Photon.OpenGl.Point(vibration.X, vibration.Y, vibration.Z, Color.White.ToVec4(), 1));
            }
            scene.Save("scene.rnpho");
        }
    }
}