using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Product
    {
        private IProductTax _productTax;
        public Product(IProductTax productTax)
        {
            this._productTax = productTax;
        }
        public double GetTax(int price)
        {
            return this._productTax.GetProductTax(price);
        }
    }
}
