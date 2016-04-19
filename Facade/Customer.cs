using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Customer
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsSmoker { get; set; }

        public Customer(string _name, int _age, bool _isSmoker)
        {
            Name = _name;
            Age = _age;
            IsSmoker = _isSmoker;
        }
      
    }
}
