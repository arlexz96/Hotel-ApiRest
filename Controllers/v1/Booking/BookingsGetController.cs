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
    public class BookingsGetController : BookingsController
    {
        public BookingsGetController(IBookRepository bookRepository, Utilities utilities) : base(bookRepository, utilities)
        {
        }
        [HttpGet("search/{IdentificationNumber}")]
        [Authorize]
        public async Task<IActionResult> GetBookingByIdentification(string IdentificationNumber)
        {
            var Reservations = _bookRepository.GetBookingByIdentification(IdentificationNumber);
            return Ok(Reservations);
        }
    }
}