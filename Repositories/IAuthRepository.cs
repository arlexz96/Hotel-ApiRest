using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoApi.DTOs.Requests;
using PruebaDesempenoApi.Models;

namespace PruebaDesempenoApi.Repositories
{
    public interface IAuthRepository
    {
        public Task<Employee> Login(AuthDTO requestData);
    }
}