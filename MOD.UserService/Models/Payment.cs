using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        [ForeignKey("user")]
        public int UID { get; set; }
        [Required]
        [ForeignKey("Mentor")]
        public int MentorID { get; set; }

        [Required]
        [ForeignKey("Training")]
        public int TrainingID { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public int Mentor_Amount { get; set; }

        public User user { get; set; }
        public Mentor Mentor { get; set; }

        public Training Training { get; set; }
    }
}
