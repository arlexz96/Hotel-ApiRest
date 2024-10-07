using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaDesempenoApi.Data;
using PruebaDesempenoApi.DTOs.Requests;
using PruebaDesempenoApi.Models;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Services
{
    public class EmployeeServices : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AddEmployee(Employee employee)
        {
            if (await CheckExistence(employee.Email))
            {
                throw new InvalidOperationException("Employee already exist");
            }
            await _appDbContext.Employees.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckExistence(string email)
        {
            return await _appDbContext.Employees.AnyAsync(e => e.Email == email.ToLower().Trim());
        }
    }
}