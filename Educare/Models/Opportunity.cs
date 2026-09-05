using System.ComponentModel.DataAnnotations;

namespace Educare.Models
{
    public class Opportunity
    {
        [Key]
        public int OpportunityID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(150)]
        public string? Provider { get; set; }

        [StringLength(100)]
        public string? Location { get; set; }

        public string? Requirements { get; set; }

        public DateTime? Deadline { get; set; }

        public string? ApplicationURL { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
