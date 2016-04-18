using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public enum ShapreTypeBad { Rectangle = 1, Square = 2 };

    public abstract class ShapeBad
    {
        public ShapreTypeBad TypeOfShape;
    }
}
