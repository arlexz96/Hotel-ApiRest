using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaDesempenoApi.Data;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Controllers.v1.Room
{
    [Tags("rooms")]
    [Route("api/v1/rooms")]
    public class RoomsGetController : RoomsController
    {
        public RoomsGetController(IRoomRepository roomRepository, AppDbContext appDbContext) : base(roomRepository, appDbContext){}
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetRooms()
        {
            var rooms = await _roomRepository.GetallRooms();
            return Ok(rooms);
        }
        [HttpGet("available")]
        public async Task<IActionResult> GetAvailablesRooms()
        {
            var Rooms = await _roomRepository.GetRoomsAvailables();
            return Ok(Rooms);
        }
        [HttpGet("status")]
        public async Task<IActionResult> GetAvailabilityCount()
        {
            var Count = await _roomRepository.GetAvailabilityCount();
            if(!Count.ContainsKey(false))
            {
                return Ok(new{
                    RoomsAvailables = Count[true],
                    RoomsUnAvailables = 0
                });
            }
            if(!Count.ContainsKey(true))
            {
                return Ok(new{
                    RoomsAvailables = 0,
                    RoomsUnAvailables = Count[false]
                });
            }
            return Ok(new{
                RoomsAvailables = 0,
                RoomsUnAvailables = Count[false]
            });
        }
        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetRoomById(int id)
        {
            var room = await _roomRepository.GetRoomById(id);
            if (room == null){
                return NotFound("Room doesn't exist");
            }
            return Ok(new{
                id = room.Id,
                roomNumber = room.RoomNumber,
                pricePerNight = room.PricePerNight,
                availability = room.Availability,
                maxOccupancyPeople = room.MaxOccupancyPeople,
                roomType = room.RoomType.Name,
                roomDescription = room.RoomType.Description,
            });
        }
        [HttpGet("occupied")]
        [Authorize]
        public async Task<IActionResult> GetUnavailableRooms()
        {
            var rooms = await _roomRepository.GetUnavailableRooms();
            if (rooms == null || !rooms.Any())
            {
                return Ok("There are no unavailable rooms");
            }
            return Ok(rooms);
        }
    }
}