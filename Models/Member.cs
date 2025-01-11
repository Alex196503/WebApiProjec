using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProjec.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [ForeignKey("Membership")]
        public int MembershipID { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerID { get; set; }
        public string Name => $"{FirstName}{LastName}";
        [ForeignKey("Reservation")]
        public int ReservationID { get; set; }

    }
}
