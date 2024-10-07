using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoApi.Models;

namespace PruebaDesempenoApi.Repositories
{
    public interface IEmployeeRepository
    {
        public Task AddEmployee(Employee employee);
        public Task<bool> CheckExistence(string email);
    }
}