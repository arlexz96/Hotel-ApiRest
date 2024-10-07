using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDesempenoApi.DTOs.Requests
{
    public class EmployeeDTO
    {
        [Required(ErrorMessage = "First Name is requiered")]
        [MaxLength(255, ErrorMessage = "the field First Name cannot exceed 255 characters")]
        public required string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is requiered")]
        [MaxLength(255, ErrorMessage = "the field Last Name cannot exceed 255 characters")]
        public required string LastName { get; set; }
        [Required(ErrorMessage = "Email is requiered")]
        [MaxLength(255, ErrorMessage = "the field Email cannot exceed 255 characters")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "Identification Number is requiered")]
        [MaxLength(20, ErrorMessage = "the field Identification Number cannot exceed 20 characters")]
        public required string IdentificationNumber { get; set; }
        [Required(ErrorMessage = "Password is requiered")]
        [MaxLength(255, ErrorMessage = "the field Password cannot exceed 255 characters")]
        public required string Password { get; set; }
    }
}