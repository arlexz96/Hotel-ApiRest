using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDesempenoApi.Models
{
    [Table("room_types")]
    public class RoomType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(50)]
        public required string Name { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string? Description { get; set; }
    }
}