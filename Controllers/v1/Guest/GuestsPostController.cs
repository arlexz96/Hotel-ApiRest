using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaDesempenoApi.DTOs.Requests;
using PruebaDesempenoApi.Repositories;
using PruebaDesempenoApi.Models;

namespace PruebaDesempenoApi.Controllers.v1
{
    [Route("api/v1/guest")]
    public class GuestsPostController : GuestsController
    {
        public GuestsPostController(IGuestRepository guestRepository) : base(guestRepository){}

        [HttpPost]
        public async Task<IActionResult> CreateGuest([FromBody] GuestDTO guestDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Guest is not valid");
            }
            Guest GuestToAdd = new Guest(guestDTO.FirstName, guestDTO.LastName, guestDTO.Email, guestDTO.IdentificationNumber, guestDTO.PhoneNumber, guestDTO.Birthdate);
            await _guestRepository.AddGuest(GuestToAdd);

            return Ok("Guest registered sucessfully");
        }
    }
}