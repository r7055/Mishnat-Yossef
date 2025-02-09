
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mishnat_Yossef.Core.Entities
{
    [Table("Sellings")]
    public class Selling
    {
        [Key]
        public int SellingId { get; set; }
        public List<Product> Products { get; set; }
        public string Parasha { get; set; }
      
    }
}
