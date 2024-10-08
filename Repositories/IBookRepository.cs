using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoApi.Models;

namespace PruebaDesempenoApi.Repositories
{
    public interface IBookRepository
    {
        public Task<ICollection<Booking>> GetBookingByIdentification(string NumberId);
        public Task DeleteBookingById(int id);
        public Task<bool> CheckExistence(int id);
        public Task<Booking> GetBookingById(int id);
    }
}