using Mishnat.entities;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class ProductService
    {
       
        static int id = 1;
        public List<Product> GetProducts() { return DataContextManager.Manager.Products; }
        public Product GetProductById(int product)
        {
            if (DataContextManager.Manager.Products == null) { return null; }
            return DataContextManager.Manager.Products.Where(p => p.ProductId== product).FirstOrDefault<Product>();
        }
        public bool UpdateProductById(int productId, Product product)
        {
            if (DataContextManager.Manager.Products == null) { return false; }
            Product p = DataContextManager.Manager.Products.Find(p => p.ProductId == productId);
            if (p == null) { return false; }
            p.DateOfLastUpdate = product.DateOfLastUpdate;
            p.Qty = product.Qty;
            p.Price = product.Price;
            p.Name = product.Name;
            return true;
        }
        public bool AddProduct(Product product)
        {
            if(DataContextManager.Manager.Products == null) { return false; }
            product.ProductId = id++;
            DataContextManager.Manager.Products.Add(product);
            return true;
        }
        public bool DeleteProduct(int productId)
        {
            if (DataContextManager.Manager.Products == null) { return false; }
            Product p= DataContextManager.Manager.Products.Find(p=>p.ProductId==productId);
            if (p == null) { return false;}
            DataContextManager.Manager.Products.Remove(p);
            return true;
        }
    }
}
