using Mishnat_Yossef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Core.InterfaceService
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public Product Get(int id);
        public bool Add(Product product);
        public bool Update(int id, Product product);
        public bool Delete(int id);
    }
}
