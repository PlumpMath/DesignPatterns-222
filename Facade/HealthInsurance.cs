using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HealthInsurance
    {
        private Bank1 _bank1 = new Bank1();
        private Bank2 _bank2 = new Bank2();

        public bool IsEligibleForHealthInsurance(Customer customer)
        {
            bool _isEligble = false;

            if (_bank1.CheckEligability(customer))
            {
                _isEligble = true;
            }

            if (_bank2.CheckEligability(customer))
            {
                _isEligble = true;
            }

            return _isEligble;
        }
    }
}
