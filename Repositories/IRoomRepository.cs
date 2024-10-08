using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoApi.Models;

namespace PruebaDesempenoApi.Repositories
{
    public interface IRoomRepository
    {
        public Task<ICollection<Room>> GetRoomsAvailables();
        public Task<Dictionary<bool, int>> GetAvailabilityCount();
        public Task<ICollection<Room>> GetallRooms();
        public Task<Room> GetRoomById(int id);
        public Task<ICollection<Room>> GetUnavailableRooms();

    }
}