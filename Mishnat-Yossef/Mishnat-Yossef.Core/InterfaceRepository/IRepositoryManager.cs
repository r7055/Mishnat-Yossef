using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Core.InterfaceRepository
{
    public interface IRepositoryManager
    {
        ISellingRepository _sellingRepository { get; }
        IStationRepository _stationRepository { get; }
        IProductRepository _productRepository { get; }
        IUserRepository _userRepository { get; }
        IOrderRepository _orderRepository { get; }
        void Save();
    }
}
