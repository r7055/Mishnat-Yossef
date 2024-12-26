using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mishnat_Yossef.Core.Entities
{
    [Table("OrderProducts")]
    public class LineOrder
    {
        [Key]
        public int Id { get; set; }
        public int LineNumber { get; set; }
        public int OrderPricerId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Order order { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Product  product { get; set; }

    }
}
