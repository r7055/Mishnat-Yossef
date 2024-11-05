namespace Mishnat.NewFolder
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        //category
        public string MadeIn { get; set; }
        public double Price { get; set; }
        public bool IsCold { get; set; }
        public DateTime DateOfLastUpdate { get; set; }
        public int Qty { get; set; }
    }
}
