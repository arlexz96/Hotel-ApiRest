using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column("password")]
        [StringLength(255)]
        public string Password { get; set; }

        public Employee(string firstName, string lastName, string email, string identificationNumber ,string password)
        {
            FirstName = firstName.ToLower().Trim();
            LastName = lastName.ToLower().Trim();
            Email = email.ToLower().Trim();
            IdentificationNumber = identificationNumber;
            Password = password;
        }
    }
}