using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mishnat_Yossef.Core.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        public string Name { get; set; } 
        public string Tz { get; set; } 
        public string Email { get; set; }
        public string  Phon { get; set; }
        public string Address { get; set; }
        public int StationId { get; set; }
        public DateTime DateOfRegistration { get; set; }
    }
}
