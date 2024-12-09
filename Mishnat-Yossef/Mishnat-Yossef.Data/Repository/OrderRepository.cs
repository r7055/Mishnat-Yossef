using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using Mishnat_Yossef.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Data.Repository
{
    public class OrderRepository : IRepository<Order>
    {
        readonly DataContext _idataContext;
        public OrderRepository(DataContext idataContext)
        {
            _idataContext = idataContext;
        }
        public bool Add(Order order)
        {
            try
            {
                _idataContext.Orders.Add(order);
                _idataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                _idataContext.Orders.Remove(Get(id));
                _idataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Order Get(int id)
        {
            return _idataContext.Orders.Find(id);
        }
        public List<Order> GetAll()
        {
            return _idataContext.Orders.ToList();
        }
        public bool Update(int id, Order order)
        {
            Order o = _idataContext.Orders.Find(id);
            if (o == null) return false;
            try
            {
                o.DateOrder = order.DateOrder == null ? o.DateOrder : order.DateOrder;
                o.Payment = order.Payment == null ? o.Payment : order.Payment;
                o.SellingId = order.SellingId == null ? o.SellingId : order.SellingId;
                _idataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
