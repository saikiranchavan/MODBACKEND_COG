using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MOD.TrainingService.Models
{
    [Table("Technology")]
    public class Technology
    {
        [Key]
        public int TechID { get; set; }
        [Required]
        [Column("TechnologyName",TypeName="varchar(30)")]
        public string TechnologyName { get; set; }

        [Required]
        [Column("TOC",TypeName="varchar(1000)")]
        public string TOC { get; set; }

        [Required]
       
        public double Fees { get; set; }

        
        
        public string? duration { get; set; }
        
    }
}
