using Mishnat;
using Mishnat.DTO;
using Mishnat.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TestMishnat
{
    internal class FakeConetxt : IDataContext
    {
        public static List<Order> Orders { get; set; } = new List<Order>();
        public static List<Product> Products { get; set; } = new List<Product>();
        public static List<Selling> Sellings { get; set; } = new List<Selling>();
        public static List<Station> Stations { get; set; } = new List<Station>();
        public List<Order> LoudOrders()
        {
            throw new NotImplementedException();
        }

        public List<Product> LoudProducts()
        {
            throw new NotImplementedException();
        }

        public List<Selling> LoudSellings()
        {
            throw new NotImplementedException();
        }

        public List<Station> LoudStations()
        {
            throw new NotImplementedException();
        }

        public List<User> LoudUsers()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "userData.json");
            string userJson = File.ReadAllText(path);
            var allUsers = JsonSerializer.Deserialize<List<User>>(userJson);
            return allUsers;
        }

        public bool SaveOrders(List<Order> orders)
        {
            throw new NotImplementedException();
        }

        public bool SaveProducts(List<Product> products)
        {
            throw new NotImplementedException();
        }

        public bool SaveSellings(List<Selling> sellings)
        {
            throw new NotImplementedException();
        }

        public bool SaveStations(List<Station> stations)
        {
            throw new NotImplementedException();
        }

        public bool SaveUsers(List<User> users)
        {
            try
            {

                string path = Path.Combine(AppContext.BaseDirectory, "Data", "userData.json");
                string jsonUser = JsonSerializer.Serialize<List<User>>(users);

                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonUser);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
