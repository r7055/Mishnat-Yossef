using Mishnat_Yossef.Core.InterfaceRepository;
using Mishnat_Yossef.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Data.Repositories
{
    public class RepositoryManager:IRepositoryManager
    {
        public RepositoryManager(DataContext dataContext, IUserRepository userRepository, IOrderRepository orderRepository, ISellingRepository sellingRepository, IStationRepository stationRepository, IProductRepository productRepository)
        {
            _dataContext = dataContext;
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _sellingRepository = sellingRepository;
            _stationRepository = stationRepository;
            _productRepository = productRepository;
        }
        private readonly DataContext _dataContext;
        public IUserRepository _userRepository { get; set; }
        public IOrderRepository _orderRepository { get; set; }
        public ISellingRepository _sellingRepository { get; set; }
        public IStationRepository _stationRepository { get; set; }
        public IProductRepository _productRepository { get; set; }
        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
