using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class CountryHead : Approver
    {
        public override void ProcessDiscountRequest(Product product)
        {
            if (product.Discount <= 50)
            {
                product.IsDiscountApproved = true;
            }
            else
            {
                product.IsDiscountApproved = false;
            }
        }
    }
}
