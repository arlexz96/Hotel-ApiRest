using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoApi.Config;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1.Booking
{
    [Route("api/v1/bookings")]
    [Tags("booking")]
    public class BookingsController(IBookRepository bookRepository, Utilities utilities) : Controller
    {
        protected readonly IBookRepository _bookRepository = bookRepository;
        protected readonly Utilities _utilities = utilities;
    }
}