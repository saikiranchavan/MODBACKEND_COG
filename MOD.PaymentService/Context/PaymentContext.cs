using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.PaymentService.Models;

namespace MOD.PaymentService.Context
{
    public class PaymentContext:DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Mentor> Mentors { get; set; }

        public DbSet<Training> Trainings { get; set; }

        public DbSet<Technology> Technologies { get; set; }

        public DbSet<Payment> Payments { get; set; }
        
    }
}
