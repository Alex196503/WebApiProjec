using Microsoft.EntityFrameworkCore;

namespace WebApiProjec.Models
{
    public class Trainer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public ICollection<Member> Members { get; set; }
       
        public ICollection<Review>? Reviews { get; set; }
        public int ReviewID { get; set; }
    }
}
