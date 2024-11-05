
using Mishnat.NewFolder;

namespace Mishnat.DTO
{
    public class Selling
    {
        public int SellingId { get; set; }
        public List<Product> Products { get; set; }
        public string Parasha { get; set; }
        public DateOnly Date { get; set; }
    }
}
