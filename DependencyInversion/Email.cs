using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Email : INotiificationService
    {
        public bool SendNotification()
        {
            return true;
        }
    }
}
