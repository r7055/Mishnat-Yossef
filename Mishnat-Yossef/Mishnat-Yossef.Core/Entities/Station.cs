using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mishnat_Yossef.Core.Entities
{
    [Table("Stations")]
    public class Station
    {
        [Key]
        public int StationId { get; set; }
        public string Manager { get; set; }
        public string Name { get; set; }
        public int SellingId { get; set; }
        public DateTime Time { get; set; }
        public string Address { get; set; }
    }
}
