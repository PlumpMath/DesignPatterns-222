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
    public class Bank2
    {
        public bool CheckEligability(Customer c)
        {
            return (c.IsSmoker = true && c.Age <= 60);
        }
    }
}
