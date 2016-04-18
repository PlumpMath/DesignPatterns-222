using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Customer : IDatabase
    {
        public bool Add()
        {
            return true;
        }
    }
}
