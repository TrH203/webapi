using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        
        [Required]
        public string UserName { get; set; }

        [Required]
        public string PassWord { get; set; }

        public string Email { get; set; }

        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}