using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Entities
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateofBirth { get; set; }

        [Required]
        public string Specialty { get; set; }
        
        [Required]
        public string PhoneNumber { get; set; }
        
        [Required]
        public string Email { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}