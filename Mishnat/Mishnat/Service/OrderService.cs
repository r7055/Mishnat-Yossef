using Mishnat.DTO;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class OrderService
    {
        public List<Order> Orders { get; set; }
        static int id = 1;
        public List<Order> GetOrders() { return Orders; }
        public Order GetOrderById(int orderId)
        {
            if (Orders == null) { return null; }
            return Orders.Where(o => o.OrderId == orderId).FirstOrDefault<Order>();
        }

        //update only one fied###
        public bool UpdateOrderById(int orderId, Order order)
        {
            if (Orders == null) { return false; }
            Order o = Orders.Find(p => p.OrderId == orderId);
            if (o == null) { return false; }
            o = order;
            return true;
        }
        public bool AddOrder(Order order)
        {
            if(Orders == null) { return false; }
            order.OrderId =id++;
            Orders.Add(order);
            return true;
        }
        public bool DeleteOrder(int orderId)
        {
            if (Orders == null) { return false; }
            Order o = Orders.Find(o => o.OrderId == orderId);
            if (o == null) { return false; }
            Orders.Remove(o);
            return true;
        }
    }
}
