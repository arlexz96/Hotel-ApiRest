using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaDesempenoApi.Config;
using PruebaDesempenoApi.DTOs.Requests;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1.auth
{
    [Route("api/v1/auth")]
    public class AuthController(IAuthRepository authRepository, Utilities utilities) : Controller
    {
        protected readonly IAuthRepository _authRepository = authRepository;
        protected readonly Utilities _utilities = utilities;
        [HttpPost("login")]
        public async Task<IActionResult> Login(AuthDTO authDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Data is no valid");
            }
            authDTO.Password = _utilities.EncryptSHA256(authDTO.Password);
            var User = await _authRepository.Login(authDTO);
            var Token = _utilities.GenerateJwtToken(User);
            return Ok(new{
                Message = "This is your token",
                token = Token
            });
        }
    }
}