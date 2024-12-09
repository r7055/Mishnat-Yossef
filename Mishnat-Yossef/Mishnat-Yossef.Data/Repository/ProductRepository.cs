using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Data.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        readonly DataContext _idataContext;
        public ProductRepository(DataContext idataContext)
        {
            _idataContext = idataContext;
        }
        public bool Add(Product product)
        {
            try
            {
                _idataContext.Products.Add(product);
                _idataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                _idataContext.Products.Remove(Get(id));
                _idataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Product Get(int id)
        {
            return _idataContext.Products.Find(id);
        }
        public List<Product> GetAll()
        {
            return _idataContext.Products.ToList();
        }
        public bool Update(int id, Product product)
        {
            Product p = _idataContext.Products.Find(id);

            if (p == null) return false;
            try
            {
                p.DateOfLastUpdate = product.DateOfLastUpdate == null ? p.DateOfLastUpdate : product.DateOfLastUpdate; ;
                p.Qty = product.Qty == null ? p.Qty : product.Qty;
                p.Price = product.Price == null ? p.Price : product.Price;
                p.Name = product.Name == null ? p.Name : product.Name;
                _idataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
