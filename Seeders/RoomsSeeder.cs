using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaDesempenoApi.Models;

namespace PruebaDesempenoApi.Seeders
{
    public class RoomsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
            // Habitaciones Simples (Id RoomType = 1)
            new Room { Id = 1, RoomNumber = "101", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 2, RoomNumber = "102", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 3, RoomNumber = "103", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 4, RoomNumber = "104", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 5, RoomNumber = "105", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 6, RoomNumber = "106", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 7, RoomNumber = "107", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 8, RoomNumber = "108", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 9, RoomNumber = "109", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 10, RoomNumber = "110", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 11, RoomNumber = "111", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },
            new Room { Id = 12, RoomNumber = "112", PricePerNight = 50, Availability = true, MaxOccupancyPeople = 1, RoomTypeId = 1 },

            // Habitaciones Dobles (Id RoomType = 2)
            new Room { Id = 13, RoomNumber = "201", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 14, RoomNumber = "202", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 15, RoomNumber = "203", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 16, RoomNumber = "204", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 17, RoomNumber = "205", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 18, RoomNumber = "206", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 19, RoomNumber = "207", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 20, RoomNumber = "208", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 21, RoomNumber = "209", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 22, RoomNumber = "210", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 23, RoomNumber = "211", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },
            new Room { Id = 24, RoomNumber = "212", PricePerNight = 80, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 2 },

            // Suites (Id RoomType = 3)
            new Room { Id = 25, RoomNumber = "301", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 26, RoomNumber = "302", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 27, RoomNumber = "303", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 28, RoomNumber = "304", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 29, RoomNumber = "305", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 30, RoomNumber = "306", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 31, RoomNumber = "307", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 32, RoomNumber = "308", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 33, RoomNumber = "309", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 34, RoomNumber = "310", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 35, RoomNumber = "311", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 36, RoomNumber = "312", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },
            new Room { Id = 37, RoomNumber = "313", PricePerNight = 150, Availability = true, MaxOccupancyPeople = 2, RoomTypeId = 3 },

            // Habitaciones Familiares (Id RoomType = 4)
            new Room { Id = 38, RoomNumber = "401", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 39, RoomNumber = "402", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 40, RoomNumber = "403", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 41, RoomNumber = "404", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 42, RoomNumber = "405", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 43, RoomNumber = "406", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 44, RoomNumber = "407", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 45, RoomNumber = "408", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 46, RoomNumber = "409", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 47, RoomNumber = "410", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 48, RoomNumber = "411", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 49, RoomNumber = "412", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 },
            new Room { Id = 50, RoomNumber = "413", PricePerNight = 200, Availability = true, MaxOccupancyPeople = 4, RoomTypeId = 4 }
            );
        }
    }
}