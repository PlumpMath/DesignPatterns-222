using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Enquiry : IDiscount
    {
        public double GetDiscount(double TotalSales)
        {
            return TotalSales - 50;
        }
    }
}
