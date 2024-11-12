using Mishnat.DTO;
using Mishnat.entities;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class OrderService
    {
        
        static int id = 1;
        public List<Order> GetOrders()
        { 
            return DataContext.Orders; 
        }
        public Order GetOrderById(int orderId)
        {
            if (DataContext.Orders == null) { return null; }
            return DataContext.Orders.Where(o => o.OrderId == orderId).FirstOrDefault<Order>();
        }

        //update only one fied###
        public bool UpdateOrderById(int orderId, Order order)
        {
            if (DataContext.Orders == null) { return false; }
            Order o = DataContext.Orders.Find(p => p.OrderId == orderId);
            if (o == null) { return false; }
            o.DateOrder = order.DateOrder;
            o.StationId = order.StationId;
            o.Payment = order.Payment;
            o.SellingId = order.SellingId;
            return true;
        }
        public bool AddOrder(Order order)
        {
            if(DataContext.Orders == null) { return false; }
            order.OrderId =id++;
            DataContext.Orders.Add(order);
            return true;
        }
        public bool DeleteOrder(int orderId)
        {
            if (DataContext.Orders == null) { return false; }
            Order o = DataContext.Orders.Find(o => o.OrderId == orderId);
            if (o == null) { return false; }
            DataContext.Orders.Remove(o);
            return true;
        }
    }
}
