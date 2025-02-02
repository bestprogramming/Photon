using Photon.TestIntersection;
using Photon.TestPacking;
using Photon.TestOpenGl;
using Photon.OpenGl;
using Photon.FlatScreen;
using Photon.FlatScreenVector;
using Photon.Space;
using Photon.SpaceVector;
using Photon.SphericalScreen;
using Photon.SphericalScreenVector;

namespace Photon
{
    internal static class Program
    {
        [STAThread]
        static void Main1(string[] args)
        {
            var count = 499;
            var ins = Packing.CirclesInACircle.GetCenters(count).OrderBy(p => p.X * p.X + p.Y * p.Y).ToArray();


            var sqrt2 = Math.Sqrt(2);
            var rMid = (1 + sqrt2) / 2;

            PointD[] GetOuts(int n) => Packing.CirclesInACircle.GetCenters(n)
                    .Select(p => new PointD(p.X * sqrt2, p.Y * sqrt2))
                    .Where(p => Math.Sqrt(p.X * p.X + p.Y * p.Y) >= 1.0 + Packing.CirclesInACircle.Table[n].Radius)
                    .OrderBy(p => Math.Abs(Math.Sqrt(p.X * p.X + p.Y * p.Y) - rMid)).ToArray();

            var n = count;
            var outs = GetOuts(n);

            while (outs.Length < count)
            {
                n++;
                outs = GetOuts(n);
            }


            var insStr = "public static readonly PointF[] Ins = new PointF[] { " + ins.Aggregate("", (c, n) => c + (c != "" ? ", " : "") + $"new({n.X}f, {n.Y}f)") + "};";
            var outsStr = "public static readonly PointF[] Outs = new PointF[] { " + outs.Aggregate("", (c, n) => c + (c != "" ? ", " : "") + $"new({n.X}f, {n.Y}f)") + "};";
        }

        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            #region Open file
            var pa = new ProgramArgs(args);
            if (pa.Executed)
            {
                return;
            }
            #endregion

            #region Test Algebra
            //Application.Run(new FrmQuadratic());
            //Application.Run(new FrmCubic());
            //Application.Run(new FrmQuartic());
            #endregion

            #region Test Intersection
            //Application.Run(new FrmTwoSegments());

            //Application.Run(new FrmCircleAndSegment());
            //Application.Run(new FrmTwoCircles());

            //Application.Run(new FrmEllipseAndTangentLine());
            //Application.Run(new FrmEllipseAndSegment());
            //Application.Run(new FrmEllipseAndTangentCircle());
            //Application.Run(new FrmEllipseAndCircle());
            //Application.Run(new FrmEllipseAndTangentEllipse());
            //Application.Run(new FrmTwoEllipses());

            //TwoCircle3Projections.Start();
            #endregion

            #region Test Packing
            //Application.Run(new FrmPackingCirclesInACircle());
            //Application.Run(new FrmPackingCirclesInASquare());
            //Application.Run(new FrmPackingCirclesInARectangle());
            #endregion

            #region Test OpenGl
            Application.Run(new FrmOpenGl());
            #endregion

            #region Orbit
            //Application.Run(new FrmSphericalScreen());
            //Application.Run(new FrmSphericalScreenVector());

            //Application.Run(new FrmFlatScreen());
            //Application.Run(new FrmFlatScreenVector());

            //Application.Run(new FrmSpace());
            //Application.Run(new FrmSpaceVector());
            #endregion
        }
    }
}