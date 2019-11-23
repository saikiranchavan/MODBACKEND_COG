using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Models
{
    [Table("Mentor")]
    public class Mentor
    {
        [Key]
        public int MentorID { get; set; }
        [Required]
        [StringLength(20)]
        [Column(TypeName="varchar(20)")]
        public string MentorName { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Email { get; set; }

        [Required]
        
        public long MentorPhoneNo { get; set; }

        [Required]
        public int StartTime { get; set; }

        [Required]
        public int EndTime { get; set; }

        [Required]
        public int experience { get; set; }

        [Required]
        [Column(TypeName = "varchar(1000)")]
        public string MentorProfile{ get; set; }

        [Required]
        [Column(TypeName="varchar(30)")]
        public string PrimaryTechnology { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string LinkedIn { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string Password { get; set; }

        public bool? MentorBlock { get; set; }

        public IEnumerable<Training> Training { get; set; }

        public IEnumerable<Payment> Payment { get; set; }
    }
}
