using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class StoreManager : Approver
    {
        public override void ProcessDiscountRequest(Product product)
        {
            //If Discount Lesser than 10% 
            if(product.Discount <=  10)
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
