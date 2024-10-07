using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoApi.Config;
using PruebaDesempenoApi.DTOs.Requests;
using PruebaDesempenoApi.Models;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController(IEmployeeRepository employeeRepository, Utilities utilities) : Controller
    {
        protected readonly IEmployeeRepository _employeeRepository = employeeRepository;
        protected readonly Utilities _utilities = utilities;

        [HttpPost("register")]
        public async Task<IActionResult> AddUser([FromBody]EmployeeDTO employeeDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Empleado no valido");
            }

            employeeDTO.Password = _utilities.EncryptSHA256(employeeDTO.Password);
            Employee EmployeeToAdd = new Employee(employeeDTO.FirstName, employeeDTO.LastName, employeeDTO.Email, employeeDTO.IdentificationNumber, employeeDTO.Password);
            await _employeeRepository.AddEmployee(EmployeeToAdd);

            return Ok("Employee registered sucessfully");
        }
    }
}