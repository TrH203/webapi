using Microsoft.EntityFrameworkCore;
using webapi.Models.Entities;

namespace webapi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.PatientId);

            modelBuilder.Entity<User>()
                .HasOne(a => a.Role)
                .WithMany(d => d.Users)
                .HasForeignKey(a => a.RoleId);
        }
    }
}