using Microsoft.AspNetCore.Mvc;
using Mishnat.DTO;
using Mishnat.NewFolder;

namespace Mishnat.entities
{
    public class DataContext
    {
        public List<Order>  Orders { get; set; } = new List<Order>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Selling> Sellings { get; set; } = new List<Selling>();
        public List<Station> Stations { get; set; } = new List<Station>();
        public List<User> Users { get; set; } = new List<User>();
    }
}
