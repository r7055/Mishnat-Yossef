using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mishnat_Yossef.Core.Entities
{
    [Table("Stations")]
    public class Station
    {
        [Key]
        public int StationId { get; set; }
        public int OrderId { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPhon { get; set; }
        public string Name { get; set; }
        public int SellingId { get; set; }
        public DateTime Time { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [ForeignKey(nameof(OrderId))]
        public List<Order> StationOrders { get; set; }
        public List<User> StationUsers { get; set; }
    }
}
