using System.Collections.Generic;

namespace SingleResponsibility
{
    public interface IOrderRepository
    {
        Order Save(Order order);
        List<Order> GetOrders();
    }
}