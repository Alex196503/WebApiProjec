namespace WebApiProjec.Models
{
    public class Membership
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
