using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class OrdersRespositorySolution : IOrderRepository
    {
        public OrderLogger Logger;

        public OrdersRespositorySolution()
        {
            Logger = new OrderLogger();
        }
        public List<Order> GetOrders()
        {
            return new List<Order> { new Order { Id = 1, Name = "Order 1" }, new Order { Id = 2, Name = "Order 2" } };
        }


        public Order Save(Order order)
        {
            try
            {
                throw new UnauthorizedAccessException("Save Failed");
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }

            //Saved
            return order;
        }
    }
}
