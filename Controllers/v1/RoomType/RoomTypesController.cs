using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoApi.Data;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1.RoomTypes
{
    public class RoomTypesController : Controller
    {
        protected readonly AppDbContext _appDbContext;
        protected readonly IRoomTypeRepository _roomTypeRepository;
        public RoomTypesController(IRoomTypeRepository roomTypeRepository, AppDbContext appDbContext)
        {
            _roomTypeRepository = roomTypeRepository;
            _appDbContext = appDbContext;
        }
    }
}