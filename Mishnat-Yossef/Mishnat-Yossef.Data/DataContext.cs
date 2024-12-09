using Microsoft.EntityFrameworkCore;
using Mishnat_Yossef.Core.Entities;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;

namespace Mishnat_Yossef.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Selling> Sellings { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<User> Users { get; set; }
       

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(mesege => Debug.Write(mesege));
        }

       
        //public List<T> LoadData<T>()
        //{

        //    string path = GetPath<T>();
        //    string dataJson = File.ReadAllText(path);
        //    var allData = JsonSerializer.Deserialize<List<T>>(dataJson);
        //    return allData; 
        //}
        //public bool SaveDada<T>(List<T> values)
        //{
        //    try
        //    {

        //        string path =GetPath<T>();
        //        string dataJson = JsonSerializer.Serialize(values);

        //        if (File.Exists(path))
        //        {
        //            File.Delete(path);
        //        }
        //        File.WriteAllText(path, dataJson);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        //private string GetPath<T>()
        //{
        //    string dir = "\\Mishnat-Yossef\\Mishnat-Yossef\\";
        //    string s=AppContext.BaseDirectory;
        //    int x = s.IndexOf(dir);
        //    string path = AppContext.BaseDirectory.Substring(0,x+ dir.Length);
        //    return Path.Combine(path, "Mishnat-Yossef.Data\\FileJSON", $"{typeof(T).Name}.json");
        //}
    }
}
