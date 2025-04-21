using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models.Entities
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "Appoinment";

        // Foreign Key
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        [Required]
        public DateTime ScheduleTime { get; set; }

        public string Note { get; set; } = String.Empty;
    }
}