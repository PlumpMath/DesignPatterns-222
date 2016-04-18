using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class AreaCalculatorBad
    {
        public double AreaBad(List<ShapeBad> shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape.TypeOfShape == ShapreTypeBad.Rectangle)
                {
                    var rectangle = (RectangleBad)shape;
                    area += rectangle.Height * rectangle.Width;
                }
                else if (shape.TypeOfShape == ShapreTypeBad.Square)
                {
                    var square = (SquareBad)shape;
                    area += square.Side * square.Side;
                }


            }

            return area;
        }
    }
}
