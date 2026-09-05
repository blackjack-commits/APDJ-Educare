using System.ComponentModel.DataAnnotations;

namespace Educare.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Role { get; set; } = "Student";
        public StudentProfile? StudentProfile { get; set; }
    }
}
