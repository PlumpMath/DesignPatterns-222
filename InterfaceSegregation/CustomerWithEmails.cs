using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class CustomerWithEmails : IDatabase, IEmailService
    {
        public bool Add()
        {
            return true;
        }

        public bool SendNotification()
        {
            return true;
        }
    }
}
