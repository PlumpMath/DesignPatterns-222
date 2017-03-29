using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class InDirectTax : ProductTax
    {
        private const double _inDirectTaxRate = 2.5;
        public double GetProductTax(int price)
        {
            return ((_inDirectTaxRate / 100) * price);
        }
    }
}
