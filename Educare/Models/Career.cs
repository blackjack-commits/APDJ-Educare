using System.ComponentModel.DataAnnotations;

namespace Educare.Models
{
    public class Career
    {
        [Key]
        public int CareerID { get; set; }

        [Required]
        [StringLength(150)]
        public string CareerName { get; set; }

        public string? Description { get; set; }

        public string? RequiredSubjects { get; set; }

        public string? RecommendedQualifications { get; set; }

        public string? Skills { get; set; }
    }
}
