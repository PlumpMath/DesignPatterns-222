using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DirectTax : IProductTax
    {
        private const double _directTaxRate = 10;
        public double GetProductTax(int price)
        {
            return ((_directTaxRate / 100) * price);
        }
    }
}
