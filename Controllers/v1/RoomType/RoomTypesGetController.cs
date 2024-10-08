using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoApi.Data;
using PruebaDesempenoApi.Models;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1.RoomTypes
{
    [Tags("room types")]
    [Route("api/v1/room_types")]
    public class RoomTypesGetController : RoomTypesController
    {
        public RoomTypesGetController(IRoomTypeRepository roomTypeRepository, AppDbContext appDbContext) : base(roomTypeRepository, appDbContext){}
        [HttpGet]
        public async Task<IActionResult> GetRoomTypes()
        {
            var roomTypes = await _roomTypeRepository.GetAllRoomType();
            return Ok(roomTypes);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomTypeById(int id)
        {
            var Room = await _roomTypeRepository.GetRoomTypeById(id);
            if (Room == null)
            {
                return NotFound("Room doesn't exist");
            }
            return Ok(Room);
        }
    }
}