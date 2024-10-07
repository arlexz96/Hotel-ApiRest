using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDesempenoApi.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(255)]
        public required string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(255)]
        public required string LastName { get; set; }
        [Column("email")]
        [StringLength(255)]
        public required string Email { get; set; }
        [Column("identification_number")]
        [StringLength(20)]
        public required string IdentificationNumber { get; set; }
        [Column("password")]
        [StringLength(255)]
        public required string Password { get; set; }
    }
}