

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mishnat_Yossef.Core.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int Payment { get; set; }
        public int UserId { get; set; }
        public DateTime DateOrder { get; set; }
        public string  StationId { get; set; }
        public string SellingId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        List<LineOrder> LineOrders { get; set; }

    }
}
