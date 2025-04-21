using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models.Entities
{
    public class Appointments
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = "Appoinment";

        // Foreign Key
        [ForeignKey("DoctorId")]
        public string DoctorId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        [Required]
        public DateTime ScheduleTime { get; set; }

        public string Note { get; set; } = String.Empty;


        public Doctor Doctor { get; set; }
    }
}