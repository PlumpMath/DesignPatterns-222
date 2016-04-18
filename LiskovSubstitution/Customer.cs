using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Customer : IDiscount, IDatabase
    {
        public virtual Boolean Add()
        {
            return true;
        }

        public virtual double GetDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }
}
