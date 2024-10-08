using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaDesempenoApi.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("room_id")]
        public int RoomId { get; set; }
        [Column("guest_id")]
        public int GuestId { get; set; }
        [Column("employee_id")]
        public int EmployeeId { get; set; }
        [Column("start_date")]
        public required DateTime StartDate { get; set; }
        [Column("end_date")]
        public DateTime? EndDate { get; set; }
        [Column("total_cost")]
        public required double TotalCost{ get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }
        [ForeignKey("GuestId")]
        public Guest Guest { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}