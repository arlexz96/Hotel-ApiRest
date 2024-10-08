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
    public class GuestServices : IGuestRepository
    {
        private readonly AppDbContext _appDbContext;
        public GuestServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddGuest(Guest guest)
        {
            if (await CheckExistence(guest.Id))
            {
                throw new InvalidOperationException("Guest already exist");
            }
            await _appDbContext.Guests.AddAsync(guest);
            await _appDbContext.SaveChangesAsync();
        }
        public async Task<bool> CheckExistence(int id)
        {
            return await _appDbContext.Guests.AnyAsync(e => e.Id == id);
        }
        public async Task<ICollection<Guest>> GetGuests()
        {
            return await _appDbContext.Guests.ToListAsync();
        }
        public async Task<Guest> GetGuestById(int id)
        {
            return await _appDbContext.Guests.FirstOrDefaultAsync(g => g.Id == id);
        }
        public async Task DeleteGuest(int id)
        {
            var Guest = await _appDbContext.Guests.FindAsync(id);
            if (Guest != null)
            {
                _appDbContext.Guests.Remove(Guest);
                await _appDbContext.SaveChangesAsync();
            }
        }
        public async Task<ICollection<Guest>> FindGuestByWord(string word)
        {
            var guests = await _appDbContext.Guests
                                .Where
                                (g => g.FirstName.Contains(word) ||
                                g.LastName.Contains(word) ||
                                g.Email.Contains(word)
                                ).ToListAsync();
            return guests;
        }
        public async Task UpdateGuest(Guest guest)
        {
            _appDbContext.Entry(guest).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
        }
    }
}