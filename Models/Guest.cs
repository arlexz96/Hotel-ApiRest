using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDesempenoApi.Models
{
    [Table("guests")]
    public class Guest
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(255)]
        public string LastName { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("identification_number")]
        [StringLength(20)]
        public string IdentificationNumber { get; set; }
        [Column("phone_number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Column("birthdate")]
        public DateOnly Birthdate { get; set; }

        public Guest(string firstName, string lastName, string email, string identificationNumber, string phoneNumber, DateOnly birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IdentificationNumber = identificationNumber;
            PhoneNumber = phoneNumber;
            Birthdate = birthdate;
        }
        public Guest(){}
    }
}