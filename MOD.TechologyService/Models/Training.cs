using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MOD.TechnologyService.Models
{
    [Table("Training")]
    public class Training
    {
        [Key]
        public int TrainingID { get; set; }

        [Required]
        [ForeignKey("user")]
        public int UID { get; set; }
        [Required]
        [ForeignKey("Mentor")]
        public int MentorID { get; set; }
        [Required]
        public string TechnologyName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int StartTime { get; set; }

        [Required]
        public int EndTime { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int Progress { get; set; }


        public string? rating { get; set; }

        public IEnumerable<Payment> Payments { get; set; }

        public User user { get; set; }
        public Mentor Mentor { get; set; }

    }
}
