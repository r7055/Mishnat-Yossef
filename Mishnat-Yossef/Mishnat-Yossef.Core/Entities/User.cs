﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

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
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int StationId { get; set; }
        public DateTime DateOfRegistration { get; set; }
        [ForeignKey(nameof(StationId))]
        public Station  StationUser { get; set; }
    }
}
