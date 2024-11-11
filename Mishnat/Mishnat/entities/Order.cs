using Mishnat.NewFolder;

namespace Mishnat.DTO
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Payment { get; set; }
       // public List<Product> Products { get; set; }
        public int UserId { get; set; }
        public DateTime DateOrder { get; set; }
        public string  StationId { get; set; }
        public string SellingId { get; set; }
    }
}
