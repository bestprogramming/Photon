using Photon.OpenGl;
using Photon.TestIntersection;
using Vec3 = System.Numerics.Vector3;

namespace Photon
{
    public class ProgramArgs
    {
        public bool Executed;

        public ProgramArgs(string[] args)
        {
            string? path = null;
            string? title = null;
            var showUcs = false;

            if (args.Length == 1 && args[0] == "TwoCircle3Projections")
            {
                Executed = true;
                TwoCircle3Projections.Start();
            }
            else if (args.Length == 1 && Path.GetExtension(args[0]).ToLower() == ".rnpho" && File.Exists(args[0]))
            {
                path = args[0];
                title = Path.GetFileNameWithoutExtension(args[0]);
                showUcs = true;
            }
            else if (args.Length == 1 && Path.GetExtension(args[0]).ToLower() == ".ptpho" && File.Exists(args[0]))
            {
                path = args[0];
                title = Path.GetFileNameWithoutExtension(args[0]);
                showUcs = true;
            }
            else
            {
                var i = Array.IndexOf(args, "--path");
                path = i != -1 ? args[i + 1] : null;

                i = Array.IndexOf(args, "--title");
                title = i != -1 ? args[i + 1] : null;

                i = Array.IndexOf(args, "--ucs");
                showUcs = i != -1;
            }

            if (path != null)
            {
                Executed = true;

                var scene = new Scene
                {
                    Title = title ?? Path.GetFileNameWithoutExtension(path),
                    CameraYaw = 180,
                    CameraPitch = 90,
                    CameraPosition = new(0f, 0f, 1f),
                    CameraTarget = new(0f, 0f, 0f),
                    CameraUp = new(0f, 1f, 0f),
                };

                scene.Open(path);

                if (showUcs)
                {
                    var ucs = new Ucs();
                    ucs.Scale(new(0.01f, 0.01f, 0.01f), Vec3.Zero);
                    scene.Shapes.Add(ucs);
                }

                scene.Start();
            }
        }
    }
}
