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
        readonly IRepository<Order> _OrderRepository;
        public OrderService(IRepository<Order> repository)
        {
            _OrderRepository = repository;
        }

        public bool Add(Order order)
        {
           if(order == null) { return false; } 
           return _OrderRepository.Add(order);
        }

        public bool Delete(int id)
        {
            if(id==null) { return false; }
            return _OrderRepository.Delete(id);
        }

        public Order Get(int id)
        {
            return _OrderRepository.Get(id);
        }

        public List<Order> GetAll()
        {
            return _OrderRepository.GetAll();
        }

        public bool Update(int id, Order order)
        {
           return _OrderRepository.Update(id, order);
        }
    }
}
