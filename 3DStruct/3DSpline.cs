using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DStruct
{
    class _3DSpline
    {
        public PointF[] SplinePoints { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }

        public _3DSpline()
        {

        }

        public _3DSpline(PointF[] SplinePoints, Color Color, float Width)
        {
            this.SplinePoints = SplinePoints;
            this.Color = Color;
            this.Width = Width;
        }
    }
}
