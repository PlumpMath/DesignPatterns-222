using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class CustomerWithRead : IDatabaseRead, IDatabase
    {
        public bool Add()
        {
            return true;
        }

        public int ReadCustomer()
        {
            return 1;
        }
    }
}
