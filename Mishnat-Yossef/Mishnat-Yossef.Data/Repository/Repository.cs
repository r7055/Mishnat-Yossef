//using Mishnat_Yossef.Core.Entities;
//using Mishnat_Yossef.Core.InterfaceRepository;
//using Mishnat_Yossef.Core.InterfaceService;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Mishnat_Yossef.Data.Repository
//{
//    public class Repository<T> : IRepository<T>
//    {
//        readonly IdataContext _idataContext;
//        public Repository(IdataContext idataContext)
//        {
//            _idataContext = idataContext;
//        }
//        public bool Add(T order)
//        {
//            _idataContext.Orders.Add(order);
//            return _idataContext.SaveDada(_idataContext.Orders);
//        }

//        public bool Add(T repository)
//        {
//            throw new NotImplementedException();
//        }

//        public bool Delete(string id)
//        {
//            return _idataContext.Orders.Remove(_idataContext.Orders.Find(o => o.OrderId == id)) &&
//                 _idataContext.SaveDada(_idataContext.Orders);
//        }
//        public T Get(string id)
//        {
//            return _idataContext.Orders.Find(o => o.OrderId == id);
//        }
//        public List<Order> GetAll()
//        {
//            return _idataContext.Orders;
//        }
//        public bool Update(string id, T order)
//        {
//           T o=_idataContext.Orders.Find(o=>o.OrderId == id);
//            if (o != null)
//            {
//                o.DateOrder = order.DateOrder;
//                o.StationId = order.StationId;
//                o.Payment = order.Payment;
//                o.SellingId = order.SellingId;
//                return _idataContext.SaveDada(_idataContext.Orders);
//            }
//            return false;
//        }

       
//    }
//}
