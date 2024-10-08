using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaDesempenoApi.Data;
using PruebaDesempenoApi.Models;
using PruebaDesempenoApi.Repositories;

namespace PruebaDesempenoApi.Services
{
    public class RoomServices : IRoomRepository
    {
        private readonly AppDbContext _appDbContext;
        public RoomServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<ICollection<Room>> GetRoomsAvailables()
        {
            return await _appDbContext.Rooms.Include(tr => tr.RoomType)
                                                    .Where(r => r.Availability == true).ToListAsync();
        }
        public async Task<Dictionary<bool, int>> GetAvailabilityCount()
        {
            return await _appDbContext.Rooms
                .GroupBy(a => a.Availability)
                .Select(g => new
                {
                    Availability = g.Key,
                    Count = g.Count()
                })
                .ToDictionaryAsync(g => g.Availability, g => g.Count);
        }
        public async Task<ICollection<Room>> GetallRooms()
        {
            var rooms = await _appDbContext.Rooms.ToListAsync();
            return rooms;
        }
        public async Task<Room> GetRoomById(int id)
        {
            return await _appDbContext.Rooms.Include(r => r.RoomType).FirstOrDefaultAsync(r => r.Id == id);
        }
        public async Task<ICollection<Room>> GetUnavailableRooms()
        {
            return await _appDbContext.Rooms.Where(r => r.Availability == false).ToListAsync();
        }
    }
}