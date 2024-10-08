using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaDesempenoApi.DTOs.Requests;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1
{
    [Route("[controller]")]
    public class GuestsDeleteController : GuestsController
    {
        public GuestsDeleteController(IGuestRepository guestRepository) : base(guestRepository){}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuest(int id)
        {
            if (!await _guestRepository.CheckExistence(id))
            {
                return NotFound("Guest not found");
            }
            await _guestRepository.DeleteGuest(id);
            return Ok("Guest Deleted Sucessfully");
        }
    }
}