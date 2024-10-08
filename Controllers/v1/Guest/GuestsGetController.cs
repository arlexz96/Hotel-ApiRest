using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1
{
    [Route("api/v1/guests")]
    public class GuestsGetController : GuestsController
    {
        public GuestsGetController(IGuestRepository guestRepository) : base(guestRepository){}
        [HttpGet]
        public async Task<IActionResult> GetAllGuests()
        {
            var Guests = await _guestRepository.GetGuests();
            if (Guests == null || !Guests.Any())
            {
                return NotFound("There are no guests to show here");
            }
            return Ok(Guests);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGuestById(int id)
        {
            if(!await _guestRepository.CheckExistence(id))
            {
                return NotFound("Guest not found");
            }
            return Ok(await _guestRepository.GetGuestById(id));
        }
        [HttpGet("search/{keyword}")]
        public async Task<IActionResult> GetGuestByWord(string keyword)
        {
            var Guests = await _guestRepository.FindGuestByWord(keyword);
            if (!Guests.Any())
            {
                return NotFound("No guest found");
            }
            return Ok(Guests);
        }
    }
}