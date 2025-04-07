using System.ComponentModel.DataAnnotations.Schema;

namespace BookingApp.Models
{
    [Table("Booking")]
    public class Booking
    {
        public int BookingID { get; set; }

       
        public int EventID { get; set; }
        public int VenueID { get; set; }

        public DateTime BookingDate { get; set; }
    }
}
