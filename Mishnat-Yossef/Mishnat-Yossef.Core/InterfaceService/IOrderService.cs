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
        public List<Order> GetAll();
        public Order Get(string id);
        public bool Add(Order order);
        public bool Update(string id, Order order);
        public bool Delete(string id);
    }
}
