using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Data.Repository
{
    internal class ProductRepository : IRepository<Product>
    {
        readonly IdataContext _idataContext;
        public bool Add(Product product)
        {
           _idataContext.Products.Add(product);
            return _idataContext.SaveDada(_idataContext.Products);
        }
        public bool Delete(string id)
        {
            return _idataContext.Products.Remove(_idataContext.Products.First(p => p.ProductId == id)) &&
                _idataContext.SaveDada(_idataContext.Products);
        }
        public Product Get(string id)
        {
            return _idataContext.Products.Find(p => p.ProductId == id);
        }
        public List<Product> GetAll()
        {
            return _idataContext.Products;
        }
        public bool Update(string id, Product product)
        {
           Product p=_idataContext.Products.Find(p=>p.ProductId == id);
            if (p != null)
            {
                p.DateOfLastUpdate = product.DateOfLastUpdate;
                p.Qty = product.Qty;
                p.Price = product.Price;
                p.Name = product.Name;
                return _idataContext.SaveDada(_idataContext.Products);
            }
            return false;
        }
    }
}
