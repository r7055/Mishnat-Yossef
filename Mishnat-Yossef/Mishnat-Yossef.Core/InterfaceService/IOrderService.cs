using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Core.InterfaceService
{
    public interface IOrderService
    {
        public IEnumerable<Order> GetAll();
        public Order Get(int id);
        public bool Add(Order order);
        public bool Update(int id, Order order);
        public bool Delete(int id);
    }
}
