using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using Mishnat_Yossef.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIshnat_Yossef.Service.Service
{
    public class OrderService : IOrderService
    {
        readonly IRepositoryManager _repositoryManager;
        public OrderService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public bool Add(Order order)
        {
           if(order == null) { return false; } 
           return _repositoryManager._orderRepository.Add(order);
        }

        public bool Delete(int id)
        {
            if(id==null) { return false; }
            return _repositoryManager._orderRepository.Delete(id);
        }

        public Order Get(int id)
        {
            return _repositoryManager._orderRepository.Get(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _repositoryManager._orderRepository.GetAll();
        }

        public bool Update(int id, Order order)
        {
           return _repositoryManager._orderRepository.Update(id, order);
        }
    }
}
