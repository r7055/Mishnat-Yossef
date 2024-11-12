using Mishnat.entities;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class ProductService
    {
       
        static int id = 1;
        public List<Product> GetProducts() { return DataContext.Products; }
        public Product GetProductById(int product)
        {
            if (DataContext.Products == null) { return null; }
            return DataContext.Products.Where(p => p.ProductId== product).FirstOrDefault<Product>();
        }
        public bool UpdateProductById(int productId, Product product)
        {
            if (DataContext.Products == null) { return false; }
            Product p = DataContext.Products.Find(p => p.ProductId == productId);
            if (p == null) { return false; }
            p.DateOfLastUpdate = product.DateOfLastUpdate;
            p.Qty = product.Qty;
            p.Price = product.Price;
            p.Name = product.Name;
            return true;
        }
        public bool AddProduct(Product product)
        {
            if(DataContext.Products == null) { return false; }
            product.ProductId = id++;
            DataContext.Products.Add(product);
            return true;
        }
        public bool DeleteProduct(int productId)
        {
            if (DataContext.Products == null) { return false; }
            Product p= DataContext.Products.Find(p=>p.ProductId==productId);
            if (p == null) { return false;}
            DataContext.Products.Remove(p);
            return true;
        }
    }
}
