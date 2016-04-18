using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Color : ColorPrototype
    {
        private int _green;
        private int _red;
        private int _blue;

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        public override ColorPrototype Clone()
        {
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
