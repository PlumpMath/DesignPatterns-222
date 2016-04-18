using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class SquareBad : ShapeBad
    {
        public int Side { get; set; }
        public SquareBad(int side)
        {
            this.Side = side;
            base.TypeOfShape = ShapreTypeBad.Square;
        }
    }
}
