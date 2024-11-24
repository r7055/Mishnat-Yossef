using Mishnat_Yossef.Core.Entities;
using System.Reflection;
using System.Text.Json;

namespace Mishnat_Yossef.Data
{
    public class DataContext:IdataContext
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<Selling> Sellings { get; set; }
        public List<Station> Stations { get; set; }
        public List<User> Users { get; set; }
        public DataContext()
        {
            Orders=LoadData<Order>();
            Products=LoadData<Product>();
            Sellings=LoadData<Selling>();
            Stations=LoadData<Station>();
            Users=LoadData<User>();
        }
        public List<T> LoadData<T>()
        {
            string path = GetPath<T>();
            string dataJson = File.ReadAllText(path);
            var allData = JsonSerializer.Deserialize<List<T>>(dataJson);
            return allData; 
        }
        public bool SaveDada<T>(List<T> values)
        {
            try
            {

                string path =GetPath<T>();
                string dataJson = JsonSerializer.Serialize(values);

                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, dataJson);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private string GetPath<T>()
        {
            return Path.Combine(AppContext.BaseDirectory,"FileJSON", $"{typeof(T).Name}.json");
        }
    }
}
