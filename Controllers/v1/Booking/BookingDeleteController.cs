using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoApi.Config;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1.Booking
{
    [Tags("booking")]
    public class BookingDeleteController :BookingsController
    {
        public BookingDeleteController(IBookRepository bookRepository, Utilities utilities) : base(bookRepository, utilities)
        {
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var booking = await _bookRepository.CheckExistence(id);
            if (booking == false)
            {
                return NotFound();
            }

            await _bookRepository.DeleteBookingById(id);

            return Ok("Booking Deleted Sucessfully");
        }
    }
}