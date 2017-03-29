using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DirectTax : ProductTax
    {
        private const double _directTaxRate = 10;
        public double GetProductTax(int price)
        {
            return ((_directTaxRate / 100) * price);
        }
    }
}
