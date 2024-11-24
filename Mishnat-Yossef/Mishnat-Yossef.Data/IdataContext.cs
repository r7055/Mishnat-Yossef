using Mishnat_Yossef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Data
{
    internal interface IdataContext
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<Selling> Sellings { get; set; }
        public List<Station> Stations { get; set; }
        public List<User> Users { get; set; }
        public List<T> LoadData<T>();
        public bool SaveDada<T>(List<T> values);

    }
}
