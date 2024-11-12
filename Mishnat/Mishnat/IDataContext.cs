using Mishnat.DTO;
using Mishnat.NewFolder;

namespace Mishnat
{
    public interface IDataContext
    {
        public List<User> LoudUsers();
        public bool SaveUsers(List<User> users);

        public List<Order> LoudOrders();
        public bool SaveOrders(List<Order> orders); 

        public List<Product> LoudProducts();
        public bool SaveProducts(List<Product> products); 

        public List<Station> LoudStations();
        public bool SaveStations(List<Station> stations);

        public List<Selling> LoudSellings();
        public bool SaveSellings(List<Selling> sellings);
    }
}
