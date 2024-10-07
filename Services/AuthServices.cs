using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaDesempenoApi.Data;
using PruebaDesempenoApi.DTOs.Requests;
using PruebaDesempenoApi.Models;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Services
{
    public class AuthServices : IAuthRepository
    {
        private readonly AppDbContext _appDbContext;
        public AuthServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Employee> Login(AuthDTO requestData)
        {
            var User = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.Email == requestData.Email);
            if (User == null)
            {
                throw new Exception(" User doesn't exist ");
            }
            if (User.Password != requestData.Password)
            {
                throw new Exception(" User Email or Password is not correct ");
            }
            return User;
        }
    }
}