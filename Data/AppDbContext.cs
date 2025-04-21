using Microsoft.EntityFrameworkCore;
using webapi.Models.Entities;

namespace webapi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Appointments> Appointments { get; set; }

    }
}