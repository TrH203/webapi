using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateofBirth { get; set; }
        
        [Required]
        public float Weight { get; set; }

        [Required]
        public float Height { get; set; }

        [Required]
        public string HealthStatus { get; set; }

        public string PhoneNumber { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public List<Appointment> Appointments { get; set; }
    }
}