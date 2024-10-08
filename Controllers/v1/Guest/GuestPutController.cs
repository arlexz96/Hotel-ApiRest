using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaDesempenoApi.DTOs.Requests;
using PruebaDesempenoApi.Models;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1
{
    [Route("api/v1/guests")]
    public class GuestPutController : GuestsController
    {
        public GuestPutController(IGuestRepository guestRepository) : base(guestRepository){}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGuest(int id, [FromBody]Guest guest)
        {
            var guestFind = await _guestRepository.GetGuestById(id);
            if (guestFind == null)
            {
                return NotFound("Guest not found");
            }

            await _guestRepository.UpdateGuest(guest);
            return Ok("Guest updated sucessfully");
        }
    }
}