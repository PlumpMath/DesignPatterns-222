using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Square : Shape
    {
        public int Side { get; set; }
        public Square(int side)
        {
            this.Side = side;
            base.TypeOfShape = ShapreType.Square;
        }

        public override double Area()
        {
            return this.Side * this.Side;
        }
    }
}
