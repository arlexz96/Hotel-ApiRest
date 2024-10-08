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
    [Route("api/v1/bookings")]
    public class BookingsGetController : BookingsController
    {
        public BookingsGetController(IBookRepository bookRepository, Utilities utilities) : base(bookRepository, utilities)
        {
        }
        [HttpGet("search/{IdentificationNumber}")]
/*         [Authorize] */
        public async Task<IActionResult> GetBookingByIdentification(string IdentificationNumber)
        {
            var Reservations = await _bookRepository.GetBookingByIdentification(IdentificationNumber);
            var Data = Reservations.Select(d => new {
                id = d.Id,
                StartDate = d.StartDate,
                roomName = d.Room.RoomType.Name,
                roomDescription = d.Room.RoomType.Description,
                Guest = $"{d.Guest.FirstName} {d.Guest.LastName}",
                GuestEmail = d.Guest.Email,
                GuestPhoneNumber = d.Guest.PhoneNumber,
                Employee = $"{d.Employee.FirstName} {d.Employee.LastName}"
            });
            return Ok(Data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookingById(int id)
        {
            var Booking = await _bookRepository.GetBookingById(id);
            if (Booking == null)
            {
                return NotFound("Booking not found");
            }
            return Ok(Booking);
        }
    }
}