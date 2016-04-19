using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    public class Bank1
    {
        public bool CheckEligability(Customer c)
        {
            return (c.IsSmoker = false && c.Age <= 60);
        }
    }
}
