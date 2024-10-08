using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoApi.Models;

namespace PruebaDesempenoApi.Repositories
{
    public interface IRoomTypeRepository
    {
        public Task<ICollection<RoomType>> GetAllRoomType();
        public Task<RoomType> GetRoomTypeById(int id);
    }
}