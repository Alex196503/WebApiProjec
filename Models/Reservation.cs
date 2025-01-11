using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProjec.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public DateTime ReservationDate { get; set; }

        public int Duration { get; set; }
        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public Member Member { get; set; }
        [ForeignKey("Court")]
        public int CourtID { get; set; }
       
        public Court Court { get; set; }
    }
}
