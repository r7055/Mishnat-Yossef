using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class ProductService
    {
        List<Product> Products { get; set; }
        static int id = 1;
        public List<Product> GetProducts() { return Products; }
        public Product GetProductById(int product)
        {
            if (Products == null) { return null; }
            return Products.Where(p => p.ProductId== product).FirstOrDefault<Product>();
        }
        public bool UpdateProductById(int productId, Product product)
        {
            if (Products == null) { return false; }
            Product p = Products.Find(p => p.ProductId == productId);
            if (p == null) { return false; }
            p = product;
            return true;
        }
        public bool AddProduct(Product product)
        {
            if(Products == null) { return false; }
            product.ProductId = id++;
            Products.Add(product);
            return true;
        }
        public bool DeleteProduct(int productId)
        {
            if (Products == null) { return false; }
            Product p=Products.Find(p=>p.ProductId==productId);
            if (p == null) { return false;}
            Products.Remove(p);
            return true;
        }
    }
}
