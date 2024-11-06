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
            return DataContextManager.Manager.Orders; 
        }
        public Order GetOrderById(int orderId)
        {
            if (DataContextManager.Manager.Orders == null) { return null; }
            return DataContextManager.Manager.Orders.Where(o => o.OrderId == orderId).FirstOrDefault<Order>();
        }

        //update only one fied###
        public bool UpdateOrderById(int orderId, Order order)
        {
            if (DataContextManager.Manager.Orders == null) { return false; }
            Order o = DataContextManager.Manager.Orders.Find(p => p.OrderId == orderId);
            if (o == null) { return false; }
            o.DateOrder = order.DateOrder;
            o.Products = order.Products;
            o.StationId = order.StationId;
            o.Payment = order.Payment;
            o.SellingId = order.SellingId;
            return true;
        }
        public bool AddOrder(Order order)
        {
            if(DataContextManager.Manager.Orders == null) { return false; }
            order.OrderId =id++;
            DataContextManager.Manager.Orders.Add(order);
            return true;
        }
        public bool DeleteOrder(int orderId)
        {
            if (DataContextManager.Manager.Orders == null) { return false; }
            Order o = DataContextManager.Manager.Orders.Find(o => o.OrderId == orderId);
            if (o == null) { return false; }
            DataContextManager.Manager.Orders.Remove(o);
            return true;
        }
    }
}
