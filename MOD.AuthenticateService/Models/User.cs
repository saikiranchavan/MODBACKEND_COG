using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Models
{
    
    public class User
    {
        [Key]
        public int UID { get; set; }

        [StringLength(20)]
        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserEmail { get; set; }

        [Required]
        public long UserPhoneNo { get; set; }

        [Required]
        //[MinLength(4)]
        public string Password { get; set; }

        public bool? UserBlock { get; set; }
    }
}
