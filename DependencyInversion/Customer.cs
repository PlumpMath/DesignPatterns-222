using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Customer 
    {
        private INotiificationService _iNotificationService;
        public Customer(INotiificationService iNotificationService)
        {
            _iNotificationService = iNotificationService;
        }
        public bool Add()
        {
           return _iNotificationService.SendNotification();
        }
    }
}
