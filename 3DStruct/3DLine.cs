using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace _3DStruct
{
    public class _3DLine
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }

        public _3DLine()
        {

        }

        public _3DLine(Point StartPoint, Point EndPoint, Color Color, float Width)
        {
            this.StartPoint = StartPoint;
            this.EndPoint = EndPoint;
            this.Color = Color;
            this.Width = Width;
        }
    }
}
