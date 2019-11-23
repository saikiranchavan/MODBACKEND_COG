using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Models
{
    public class Token
    {
        public string message { get; set; }
        public string token { get; set; }

        public string Name { get; set; }

        public int userID { get; set; }

        public int mentorID { get; set; }

        public int ID { get; set; }

        public bool Block { get; set; }

        public Mentor obj { get; set; }
    }
}
