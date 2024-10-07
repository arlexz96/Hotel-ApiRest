using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDesempenoApi.Models
{
    [Table("rooms")]
    public class Room
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("room_number")]
        [StringLength(10)]
        public required string RoomNumber { get; set; }
        [Column("price_per_night")]
        public required double PricePerNight { get; set; }
        [Column("availability")]
        public required bool Availability { get; set; }
        [Column("max_occupancy_people")]
        public required byte MaxOccupancyPeople { get; set; }
        [Column("room_type_id")]
        public int RoomTypeId { get; set; }
        [ForeignKey("RoomTypeId")]
        public RoomType RoomType{ get; set; }
    }
}