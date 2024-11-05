using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class ProductService
    {
        List<Product> Products { get; set; }
        public List<Product> GetProducts() { return Products; }
        public Product GetProductById(string id)
        {
            if (Products == null) { return null; }
            return Products.Where(p => p.ProductId.Equals(id)).FirstOrDefault<Product>();
        }
        public bool UpdateProductById(string productId, Product product)
        {
            if (Products == null) { return false; }
            Product p = Products.Find(p => p.ProductId.Equals(productId));
            if (p == null) { return false; }
            p = product;
            return true;
        }
        public bool AddProduct(Product product)
        {
            Products.Add(product);
            return true;
        }
        public bool DeleteProduct(string productId)
        {
            if (Products == null) { return false; }
            Product p=Products.Find(p=>p.ProductId.Equals(productId));
            if (p == null) { return false;}
            Products.Remove(p);
            return true;
        }
    }
}
