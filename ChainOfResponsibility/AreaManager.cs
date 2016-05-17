using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class AreaManager : Approver
    {
        public override void ProcessDiscountRequest(Product product)
        {
            //If Discount id lesser than
            if (product.Discount <= 25)
            {
                product.IsDiscountApproved = true;
            }
            else
            {
                successor.ProcessDiscountRequest(product);
            }
        }
    }
}
