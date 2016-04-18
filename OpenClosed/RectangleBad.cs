using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class RectangleBad : ShapeBad
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public RectangleBad(int height, int width)
        {
            this.Height = height;
            this.Width = width;
            base.TypeOfShape = ShapreTypeBad.Rectangle;
        }
    }
}
