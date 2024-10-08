using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoApi.Models;

namespace PruebaDesempenoApi.Repositories
{
    public interface IGuestRepository
    {
        public Task AddGuest(Guest guest);
        public Task<bool> CheckExistence(int id);
        public Task<ICollection<Guest>> GetGuests();
        public Task<Guest> GetGuestById(int id);
        public Task DeleteGuest(int id);
        public Task<ICollection<Guest>> FindGuestByWord(string word);
        public Task UpdateGuest(Guest guest);
    }
}