using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Entities
{
    public class Doctor
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int DateofBirth { get; set; }

        [Required]
        public int Specialty { get; set; }
        
        [Required]
        public string PhoneNumber { get; set; }
        
        [Required]
        public string Email { get; set; }

        public ICollection<Appointments> Appointments { get; set; }
    }
}