using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photon
{
    public struct Hsl
    {
        private int h;
        private float s;
        private float l;

        public Hsl(int h, float s, float l)
        {
            this.h = h;
            this.s = s;
            this.l = l;
        }

        public int H
        {
            get { return h; }
            set { h = value; }
        }

        public float S
        {
            get { return s; }
            set { s = value; }
        }

        public float L
        {
            get { return l; }
            set { l = value; }
        }

        public bool Equals(Hsl hsl)
        {
            return (H == hsl.H) && (S == hsl.S) && (L == hsl.L);
        }

        public Color ToColor()
        {
            var color = Helper.HslToRgb(this);
            return Color.FromArgb(color.R, color.G, color.B);
        }

        public Brush ToBrush()
        {
            return new SolidBrush(ToColor());
        }

        public Pen ToPen(int width = 1)
        {
            return new Pen(ToColor(), width);
        }
    }
}
