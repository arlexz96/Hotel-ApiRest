using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaDesempenoApi.Data;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1.Room
{
    [Route("[controller]")]
    public class RoomsController : Controller
    {
        protected readonly AppDbContext _appDbContext;
        protected readonly IRoomRepository _roomRepository;
        public RoomsController(IRoomRepository roomRepository, AppDbContext appDbContext)
        {
            _roomRepository = roomRepository;
            _appDbContext = appDbContext;
        }
    }
}