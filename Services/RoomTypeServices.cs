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
    public class RoomTypeServices : IRoomTypeRepository
    {
        private readonly AppDbContext _appDbContext;
        public RoomTypeServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<ICollection<RoomType>> GetAllRoomType()
        {
            var RoomTypes = await _appDbContext.RoomTypes.ToListAsync();
            return RoomTypes;
        }
        public async Task<RoomType> GetRoomTypeById(int id)
        {
            var Room = await _appDbContext.RoomTypes.FirstOrDefaultAsync(r => r.Id == id);
            return Room;
            
        }
    }
}