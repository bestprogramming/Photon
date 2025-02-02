using Photon.OpenGl;
using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using System.Diagnostics;
using System.Timers;
using Mat4x4 = System.Numerics.Matrix4x4;
using Shader = Photon.OpenGl.Shader;
using Timer = System.Timers.Timer;
using Vec2 = System.Numerics.Vector2;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

//shortcuts:
//F1: show-hide ucs,
//1: show-hide sphere1,   2: show-hide sphere2,   3: show-hide sphere3
//movement      sphere1: (x: Q,A) (y: W,S) (z: E,D)      sphere2: (x: R,F) (y: T,G) (z: Y,H)      sphere3: (x: U,J) (y: I,K) (z: O,L)
//dec-inc radius        sphere1: (z, x)     sphere2: (c, v)     sphere3: (b, n) 
namespace Photon.TestIntersection
{
    public static class TwoCircle3Projections
    {
        public class KeyDownTimer
        {
            public IWindow Window;
            public IKeyboard Keyboard;
            public Key Key;
            public int Arg3;
            public double Interval;
            public double Current;
            public KeyDownTimer(IWindow window, IKeyboard keyboard, Key key, int arg3, double interval, double current)
            {
                Window = window;
                Keyboard = keyboard;
                Key = key;
                Arg3 = arg3;
                Interval = interval;
                Current = current;
            }
        }

        private const double moveStep = 0.001;
        private const double radiusStep = 0.001;
        private static Sphere s1 = new(-0.03, 0, 0, 0.04);
        private static Sphere s2 = new(0, 0.03, 0, 0.04);
        private static Sphere s3 = new(0.03, 0, 0, 0.04);

        private static bool showUcs = true;

        private const int order = 3;
        private static bool showS1 = true;
        private static bool showS2 = true;
        private static bool showS3 = true;

        private static KeyDownTimer? keyDownTimer = null;

        public const string Title = "Intersection (TwoCircle3s)";
        public const int Width = 1920;
        public const int Height = 1080;

        public static readonly Shape?[] Shapes = new Shape[9];

        private static IWindow? window;
        private static GL? gl;
        private static Vec3 CameraPosition = new(0.63029486f, -0.6481463f, 0.42735794f);
        private static Vec3 CameraTarget = new(0.0f, 0.0f, 0.0f);
        private static Vec3 CameraUp = new(-0.2979391f, 0.3063774f, 0.90408254f);
        private static float CameraYaw = 135.79999f;
        private static float CameraPitch = 25.300005f;
        private static float CameraZoom = 45f;
        private static Vec2 lastPosition;
        private static bool perspective = false;

        public static void Start()
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

            SetUcs();
            SetS1();
            SetS2();
            SetS3();
            Intersect();
            window.Run();
            window.Dispose();
        }

        public static void SetUcs()
        {
            Shapes[0]?.Dispose();

            if (showUcs)
            {
                var u = new Ucs();
                u.Scale(new(0.01f, 0.01f, 0.01f), Vec3.Zero);
                Shapes[0] = u;
            }
            else
            {
                Shapes[0] = null;
            }

            if (gl != null)
            {
                Shapes[0]?.Bind(gl);
            }
        }

        public static void SetS1()
        {
            Shapes[1]?.Dispose();

            if (showS1)
            {
                var color = new Vec4(1.0f, 0.0f, 0.0f, 0.3f);
                Shapes[1] = new OpenGl.Solid.Sphere((float)s1.X, (float)s1.Y, (float)s1.Z, (float)s1.R, order, color);
            }
            else
            {
                Shapes[1] = null;
            }

            if (gl != null)
            {
                Shapes[1]?.Bind(gl);
            }
        }

        public static void SetS2()
        {
            Shapes[2]?.Dispose();

            if (showS2)
            {
                var color = new Vec4(0.0f, 1.0f, 0.0f, 0.3f);
                Shapes[2] = new OpenGl.Solid.Sphere((float)s2.X, (float)s2.Y, (float)s2.Z, (float)s2.R, order, color);
            }
            else
            {
                Shapes[2] = null;
            }

            if (gl != null)
            {
                Shapes[2]?.Bind(gl);
            }
        }

        public static void SetS3()
        {
            Shapes[3]?.Dispose();

            if (showS3)
            {
                var color = new Vec4(0.0f, 0.0f, 1.0f, 0.3f);
                Shapes[3] = new OpenGl.Solid.Sphere((float)s3.X, (float)s3.Y, (float)s3.Z, (float)s3.R, order, color);
            }
            else
            {
                Shapes[3] = null;
            }

            if (gl != null)
            {
                Shapes[3]?.Bind(gl);
            }
        }

        public static void Intersect()
        {
            var m = 10;
            var test = @$"
                        s1 = new Sphere({m * s1.X}, {m * s1.Y}, {m * s1.Z}, {m * s1.R});
                        s2 = new Sphere({m * s2.X}, {m * s2.Y}, {m * s2.Z}, {m * s2.R});
                        s3 = new Sphere({m * s3.X}, {m * s3.Y}, {m * s3.Z}, {m * s3.R});
                        ok1 = s1.Intersect(s3, out cp1);
                        ok2 = s2.Intersect(s3, out cp2);
                        ok3 = cp1.Intersect(cp2, out p1, out p2);
                        //Assert.True(ok3 && E(p1.X, ) && E(p1.Y, ) && E(p1.Z, ) && E(p2.X, ) && E(p2.Y, ) && E(p2.Z, ));
            ";
            Debug.WriteLine(test);
            Debug.WriteLine("-------------------------------------");

            Shapes[4]?.Dispose();
            Shapes[5]?.Dispose();
            Shapes[6]?.Dispose();
            Shapes[7]?.Dispose();
            Shapes[8]?.Dispose();

            var ok1 = s1.Intersect(s3, out Circle3 c1);
            var ok2 = s2.Intersect(s3, out Circle3 c2);
            if (ok1 && ok2)
            {
                var ok3 = s1.Intersect(s3, out Circle3Projection cp1);
                var ok4 = s2.Intersect(s3, out Circle3Projection cp2);
                var ok5 = s1.Intersect(s2, out Circle3 c3);

                if (!ok3 || !ok4 || !ok5)
                {
                    throw new Exception("No intersection error");
                }

                Shapes[4] = new OpenGl.Circle3(c1, 500, 0, Big.Pi2, Color.Magenta.ToVec4());
                Shapes[5] = new OpenGl.Circle3(c2, 500, 0, Big.Pi2, Color.Cyan.ToVec4());
                Shapes[6] = new OpenGl.Circle3(c3, 500, 0, Big.Pi2, Color.Yellow.ToVec4());

                var ok = cp1.Intersect(cp2, out Point3 p1, out Point3 p2);
                Shapes[7] = ok ? new OpenGl.Solid.Sphere((float)p1.X, (float)p1.Y, (float)p1.Z, 0.0005f, 1, Color.White.ToVec4()) : null;
                Shapes[8] = ok ? new OpenGl.Solid.Sphere((float)p2.X, (float)p2.Y, (float)p2.Z, 0.0005f, 1, Color.White.ToVec4()) : null;
            }
            else
            {
                Shapes[4] = null;
                Shapes[5] = null;
                Shapes[6] = null;
                Shapes[7] = null;
                Shapes[8] = null;
            }

            if (gl != null)
            {
                Shapes[4]?.Bind(gl);
                Shapes[5]?.Bind(gl);
                Shapes[6]?.Bind(gl);
                Shapes[7]?.Bind(gl);
                Shapes[8]?.Bind(gl);
            }
        }

        private static void Load(IWindow window)
        {
            gl = GL.GetApi(window);

            foreach (var shape in Shapes)
            {
                shape?.Bind(gl);
            }

            var shader = new Shader(gl);

            window.Render += (deltaTime) =>
            {
                if (keyDownTimer != null)
                {
                    keyDownTimer.Current += deltaTime * 10000;
                    if (keyDownTimer.Current > keyDownTimer.Interval)
                    {
                        KeyDown(keyDownTimer.Window, keyDownTimer.Keyboard, keyDownTimer.Key, keyDownTimer.Arg3);
                        keyDownTimer.Current -= keyDownTimer.Interval;
                    }
                }
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
                    KeyDown(window, keyboard, key, arg3);
                };

                keyboard.KeyUp += KeyUp;
            }
            for (int i = 0; i < input.Mice.Count; i++)
            {
                input.Mice[i].Cursor.CursorMode = CursorMode.Normal;
                input.Mice[i].MouseMove += MouseMove;
                input.Mice[i].Scroll += MouseWheel;
            }
        }

        private static unsafe void Render(GL gl, Shader shader)
        {
            gl.Enable(EnableCap.Blend);
            gl.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            gl.Enable(EnableCap.CullFace);

            gl.Enable(EnableCap.DepthTest);
            //gl.Clear(ClearBufferMask.ColorBufferBit);
            gl.Clear((uint)(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit));

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
                shape?.Render(gl);
            }
        }

        private static void Closing(Shader shader)
        {
            foreach (var shape in Shapes)
            {
                shape?.Dispose();
            }
            shader.Dispose();
        }

        private static void KeyDown(IWindow window, IKeyboard keyboard, Key key, int arg3)
        {
            if (key == Key.Escape)
            {
                window.Close();
            }
            else if (key == Key.F1)
            {
                showUcs = !showUcs;
                SetUcs();
            }
            else if (key == Key.Number1)
            {
                showS1 = !showS1;
                SetS1();
            }
            else if (key == Key.Number2)
            {
                showS2 = !showS2;
                SetS2();
            }
            else if (key == Key.Number3)
            {
                showS3 = !showS3;
                SetS3();
            }

            else if (key == Key.Q)
            {
                s1.X += moveStep;
                SetS1();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.A)
            {
                s1.X -= moveStep;
                SetS1();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.W)
            {
                s1.Y += moveStep;
                SetS1();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.S)
            {
                s1.Y -= moveStep;
                SetS1();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.E)
            {
                s1.Z += moveStep;
                SetS1();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.D)
            {
                s1.Z -= moveStep;
                SetS1();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }

            else if (key == Key.R)
            {
                s2.X += moveStep;
                SetS2();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.F)
            {
                s2.X -= moveStep;
                SetS2();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.T)
            {
                s2.Y += moveStep;
                SetS2();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.G)
            {
                s2.Y -= moveStep;
                SetS2();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.Y)
            {
                s2.Z += moveStep;
                SetS2();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.H)
            {
                s2.Z -= moveStep;
                SetS2();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }

            else if (key == Key.U)
            {
                s3.X += moveStep;
                SetS3();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.J)
            {
                s3.X -= moveStep;
                SetS3();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.I)
            {
                s3.Y += moveStep;
                SetS3();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.K)
            {
                s3.Y -= moveStep;
                SetS3();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.O)
            {
                s3.Z += moveStep;
                SetS3();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.L)
            {
                s3.Z -= moveStep;
                SetS3();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }


            else if (key == Key.Z)
            {
                s1.R -= radiusStep;
                SetS1();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.X)
            {
                s1.R += radiusStep;
                SetS1();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }

            else if (key == Key.C)
            {
                s2.R -= radiusStep;
                SetS2();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.V)
            {
                s2.R += radiusStep;
                SetS2();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }

            else if (key == Key.B)
            {
                s3.R -= radiusStep;
                SetS3();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
            else if (key == Key.N)
            {
                s3.R += radiusStep;
                SetS3();
                Intersect();
                keyDownTimer ??= new(window, keyboard, key, arg3, 1000d, 0d);
            }
        }

        private static void KeyUp(IKeyboard keyboard, Key key, int arg3)
        {
            if (keyDownTimer != null)
            {
                keyDownTimer = null;
            }
        }

        private static unsafe void MouseMove(IMouse mouse, Vec2 position)
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

        private static unsafe void MouseWheel(IMouse mouse, ScrollWheel scrollWheel)
        {
            CameraZoom = Math.Clamp(CameraZoom * (1 - scrollWheel.Y * 0.1f), 0.01f, 90f);
        }
    }
}
