using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mishnat_Yossef.Core.Entities
{
    [Table("OrderProducts")]
    public class OrderProducts
    {
        [Key]
        public int OrderPricerId { get; set; }
        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; } 
    }
}
