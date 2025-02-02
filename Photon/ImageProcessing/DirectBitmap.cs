using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Photon
{
    public class DirectBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        public int[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new int[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }

        private void SetPixel(int x, int y, Color color)
        {
            int index = x + (y * Width);
            int col = color.ToArgb();

            Bits[index] = col;
        }

        public void SetPixel(Color color, int x, int y)
        {
            x += Width / 2;
            y = Height / 2 - y;

            if (x >= 0 && y >= 0 && x < Width && y < Height)
            {
                SetPixel(x, y, color);
            }
        }

        public void SetPixel(Color color, Pixel p)
        {
            SetPixel(color, p.X, p.Y);
        }

        public void SetPixel(Pen pen, double x, double y)
        {
            x += Width / 2;
            y = Height / 2 - y;

            if (x >= 0 && y >= 0 && x < Width && y < Height)
            {
                SetPixel((int)x, (int)y, pen.Color);
            }
        }

        public void SetPixel(Pen pen, in Point p)
        {
            SetPixel(pen, p.X, p.Y);
        }

        public Color GetPixel(int x, int y)
        {
            int index = x + (y * Width);
            int col = Bits[index];
            Color result = Color.FromArgb(col);

            return result;
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
            GC.SuppressFinalize(this);
        }
    }
}
