using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProjec.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerID { get; set; }
    }
}
