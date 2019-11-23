using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Models
{
    public class Custom
    {
        public int UserID { get; set; }
        public string TechnologyName { get; set; }


        public DateTime StartDate { get; set; }


        public DateTime EndDate { get; set; }

        
        public int Mentor_Amount { get; set; }
    }
}
