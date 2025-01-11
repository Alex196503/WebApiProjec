using Microsoft.EntityFrameworkCore;

namespace WebApiProjec.Models
{
    public class Court
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public double Size { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
