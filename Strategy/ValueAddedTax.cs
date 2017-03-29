using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ValueAddedTax : IProductTax
    {
        private const double _valueAddedTax = 5;
        public double GetProductTax(int price)
        {
            return ((_valueAddedTax / 100) * price);
        }
    }
}
