using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Context
{
    public class TrainingContext:DbContext
    {
        public TrainingContext(DbContextOptions<TrainingContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Mentor> Mentors { get; set; }

        public DbSet<Training> Trainings { get; set; }

        public DbSet<Technology> Technologies { get; set; }

        public DbSet<Payment> Payments { get; set; }
        
    }
}
