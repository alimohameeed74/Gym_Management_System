
using Gym_Management_System.Entities.Classes;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Gym_Management_System.Contexts
{
    public class AppDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=GymManagementSystem;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Member> Members { get; set; }

    }
}
