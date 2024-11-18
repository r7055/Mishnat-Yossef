using Mishnat_Yossef.Core.Entities;
using System.Reflection;

namespace Mishnat_Yossef.Data
{
    public class DataContext
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<Selling> Sellings { get; set; }
        public List<Station> Stations { get; set; }
        public List<User> Users { get; set; }

        public DataContext()
        {
            ///read from file 
        }

        public bool SaveUsers()
        {
            ///write from file
            return true;
        }
        public bool SaveProducts()
        {
            ///write from file

            return true;
        }
        public bool SaveSelling()
        {
            ///write from file

            return true;
        }
        public bool SaveStation()
        {
            ///write from file

            return true;
        }
        public bool SaveOrders()
        {
            ///write from file

            return true;
        }

    }
}
