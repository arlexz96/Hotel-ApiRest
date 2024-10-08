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
    public class BookServices : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<ICollection<Booking>> GetBookingByIdentification(string NumberId)
        {
            var Reservations = await _appDbContext.Bookings.Include(p => p.Guest).Where(b => b.Guest.IdentificationNumber == NumberId).ToListAsync();
            return Reservations;
        }
        public async Task DeleteBookingById(int id)
        {
            var booking = await _appDbContext.Bookings.FindAsync(id);
            if (booking != null)
            {
                _appDbContext.Bookings.Remove(booking);
                await _appDbContext.SaveChangesAsync();
            }
        }
        public async Task<bool> CheckExistence(int id)
        {
            return await _appDbContext.Bookings.AnyAsync(e => e.Id == id);
        }
    }
}