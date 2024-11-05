using Mishnat.DTO;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class OrderService
    {
        public List<Order> Orders { get; set; }
        public OrderService() { }
        public List<Order> GetOrders() { return Orders; }
        public Order GetOrderById(string id)
        {
            if (Orders == null) { return null; }
            return Orders.Where(o => o.OrderId.Equals(id)).FirstOrDefault<Order>();
        }

        //update only one fied###
        public bool UpdateOrderById(string orderId, Order order)
        {
            if (Orders == null) { return false; }
            Order o = Orders.Find(p => p.OrderId.Equals(orderId));
            if (o == null) { return false; }
            o = order;
            return true;
        }
        public bool AddOrder(Order order)
        {
            Orders.Add(order);
            return true;
        }
        public bool DeleteOrder(string orderId)
        {
            if (Orders == null) { return false; }
            Order o = Orders.Find(o => o.OrderId.Equals(orderId));
            if (o == null) { return false; }
            Orders.Remove(o);
            return true;
        }
    }
}
