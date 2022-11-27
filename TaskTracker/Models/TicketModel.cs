using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Models
{
    public class TicketModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime RequestDate { get; set; } = DateTime.Now;
        [Required]
        public string Description { get; set; }
        [Required]
        public string TechAssign { get; set; }
        public DateTime CompleteDate { get; set; } = new DateTime();
        [Required]
        public string Comments { get; set; }
    }
}

