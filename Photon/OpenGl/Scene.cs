using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Mat4x4 = System.Numerics.Matrix4x4;
using Vec2 = System.Numerics.Vector2;
using Vec3 = System.Numerics.Vector3;

namespace Photon.OpenGl
{
    public class Scene
    {
        public string Title = "Demo";
        public int Width = 1920;
        public int Height = 1080;

        public List<Shape> Shapes = new();

        private static IWindow? window;
        public Vec3 CameraPosition = new(0.63029486f, -0.6481463f, 0.42735794f);
        public Vec3 CameraTarget = new(0.0f, 0.0f, 0.0f);
        public Vec3 CameraUp = new(-0.2979391f, 0.3063774f, 0.90408254f);
        public float CameraYaw = 135.79999f;
        public float CameraPitch = 25.300005f;
        public float CameraZoom = 45f;
        private Vec2 lastPosition;
        private bool perspective = false;

        public void Start()
        {
            var options = WindowOptions.Default;
            options.Size = new Vector2D<int>(Width, Height);
            options.Title = Title;
            options.WindowState = WindowState.Maximized;

            window = Window.Create(options);

            window.Load += () =>
            {
                Load(window);
            };
            window.Run();
            window.Dispose();
        }

        private void Load(IWindow window)
        {
            var gl = GL.GetApi(window);

            foreach (var shape in Shapes)
            {
                shape.Bind(gl);
            }

            var shader = new Shader(gl);

            window.Render += (deltaTime) =>
            {
                Render(gl, shader);
            };

            window.Closing += () =>
            {
                Closing(shader);
            };

            var input = window.CreateInput();
            var keyboard = input.Keyboards[0];
            if (keyboard != null)
            {
                keyboard.KeyDown += (keyboard, key, arg3) =>
                {
                    KeyDown(window, gl, keyboard, key, arg3);
                };
            }
            for (int i = 0; i < input.Mice.Count; i++)
            {
                input.Mice[i].Cursor.CursorMode = CursorMode.Normal;
                input.Mice[i].MouseMove += MouseMove;
                input.Mice[i].Scroll += MouseWheel;
            }
        }

        private unsafe void Render(GL gl, Shader shader)
        {
            gl.Enable(EnableCap.Blend);
            gl.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            gl.Enable(EnableCap.CullFace);

            gl.Enable(EnableCap.DepthTest);
            gl.Clear((uint)(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit));

            gl.Enable(EnableCap.ProgramPointSize);

            shader.Use();

            var model = Mat4x4.Identity; //Mat4x4.CreateRotationX(0);
            var view = Mat4x4.CreateLookAt(CameraPosition, CameraTarget, CameraUp);
            var projection = perspective ? Mat4x4.CreatePerspectiveFieldOfView(Conversion.Rad(CameraZoom), 1f * Width / Height, 0.01f, 100.0f) :
                Mat4x4.CreateOrthographic(CameraZoom * Width / 100000f, CameraZoom * Height / 100000f, 0.01f, 100.0f);

            shader.SetUniform("uModel", model);
            shader.SetUniform("uView", view);
            shader.SetUniform("uProjection", projection);

            foreach (var shape in Shapes)
            {
                shape.Render(gl);
            }
        }

        private void Closing(Shader shader)
        {
            foreach (var shape in Shapes)
            {
                shape.Dispose();
            }
            shader.Dispose();
        }

        private void KeyDown(IWindow window, GL gl, IKeyboard keyboard, Key key, int arg3)
        {
            if (key == Key.Escape)
            {
                window.Close();
            }
            else if (key == Key.F1)
            {
                var ucs = Shapes.SingleOrDefault(p => p is Ucs);
                if (ucs != null)
                {
                    Shapes.Remove(ucs);
                }
                else
                {
                    ucs = new Ucs();
                    ucs.Scale(new(0.01f, 0.01f, 0.01f), Vec3.Zero);
                    Shapes.Add(ucs);
                    ucs.Bind(gl);
                }
            }
            else if (key == Key.F2)
            {
                perspective = !perspective;
            }
        }

        private unsafe void MouseMove(IMouse mouse, Vec2 position)
        {
            if (mouse.IsButtonPressed(MouseButton.Left))
            {
                var lookSensitivity = 0.1f;

                var xOffset = (position.X - lastPosition.X) * lookSensitivity;
                var yOffset = (position.Y - lastPosition.Y) * lookSensitivity;

                CameraYaw += xOffset;
                CameraPitch += yOffset;
                CameraPitch = Math.Clamp(CameraPitch, -89.9999f, 89.9999f);

                CameraPosition = new Vec3(
                    MathF.Sin(Conversion.Rad(CameraYaw)) * MathF.Cos(Conversion.Rad(CameraPitch)),
                    MathF.Cos(Conversion.Rad(CameraYaw)) * MathF.Cos(Conversion.Rad(CameraPitch)),
                    MathF.Sin(Conversion.Rad(CameraPitch)));
                CameraPosition = Vec3.Normalize(CameraPosition);

                var right = Vec3.Normalize(Vec3.Cross(CameraPosition, Vec3.UnitZ));

                CameraUp = Vec3.Normalize(Vec3.Cross(right, CameraPosition));
            }
            else if (mouse.IsButtonPressed(MouseButton.Middle))
            {
                var panSensitivity = 0.000018f * CameraZoom;

                var xOffset = (position.X - lastPosition.X) * panSensitivity;
                var yOffset = (position.Y - lastPosition.Y) * panSensitivity;

                CameraYaw += xOffset;
                CameraPitch += yOffset;
                CameraPitch = Math.Clamp(CameraPitch, -89.0f, 89.0f);

                CameraPosition = new Vec3(
                    MathF.Sin(Conversion.Rad(CameraYaw)) * MathF.Cos(Conversion.Rad(CameraPitch)),
                    MathF.Cos(Conversion.Rad(CameraYaw)) * MathF.Cos(Conversion.Rad(CameraPitch)),
                    MathF.Sin(Conversion.Rad(CameraPitch)));
                CameraPosition = Vec3.Normalize(CameraPosition);

                var right = Vec3.Normalize(Vec3.Cross(CameraPosition, Vec3.UnitZ));

                var up = CameraUp * yOffset;

                CameraPosition += right * xOffset + up;
                CameraTarget += right * xOffset + up;

                CameraUp = Vec3.Normalize(Vec3.Cross(right, CameraPosition));
            }

            lastPosition = position;
        }

        private unsafe void MouseWheel(IMouse mouse, ScrollWheel scrollWheel)
        {
            CameraZoom = Math.Clamp(CameraZoom * (1 - scrollWheel.Y * 0.1f), 0.01f, 90f);
        }


        public void Save(string filename)
        {
            using var fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            using var bw = new BinaryWriter(fs);

            foreach (var shape in Shapes)
            {
                foreach (var vertex in shape.Vertices)
                {
                    bw.Write(vertex.Position.X);
                    bw.Write(vertex.Position.Y);
                    bw.Write(vertex.Position.Z);
                    bw.Write(vertex.Color.X);
                    bw.Write(vertex.Color.Y);
                    bw.Write(vertex.Color.Z);
                    bw.Write(vertex.Color.W);
                    bw.Write(vertex.PointSize);
                }
            }

            bw.Close();
        }

        public void Open(string filename)
        {
            if (Path.GetExtension(filename).ToLower() == ".ptpho")
            {
                var ps = PatternSetting.Read(filename);
                Open(ps.BaseSettings);
            }
            else
            {
                var vertices = new List<Vertex>();

                using var fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using var br = new BinaryReader(fs);
                br.BaseStream.Seek(0, SeekOrigin.Begin);

                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    vertices.Add(new(new(br.ReadSingle(), br.ReadSingle(), br.ReadSingle()), new(br.ReadSingle(), br.ReadSingle(), br.ReadSingle(), br.ReadSingle()), br.ReadSingle()));
                }

                Shapes.Add(new Points(vertices.ToArray()));
            }
        }

        public void Open(BaseSetting[] settings)
        {
            foreach (var setting in settings)
            {
                setting.AddTo(this);
            }
        }
    }
}
