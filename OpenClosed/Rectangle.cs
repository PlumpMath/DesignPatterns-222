using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
            base.TypeOfShape = ShapreType.Rectangle;
        }

        public override double Area()
        {
            return this.Height * this.Width;
        }
    }
}
