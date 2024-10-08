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
    [Route("[controller]")]
    public class GuestsController : Controller
    {
        protected readonly IGuestRepository _guestRepository;

        public GuestsController(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }
    }
}