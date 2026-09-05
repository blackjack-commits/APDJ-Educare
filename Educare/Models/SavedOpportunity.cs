using System.ComponentModel.DataAnnotations;

namespace Educare.Models
{
    public class SavedOpportunity
    {
        [Key]
        public int SavedOpportunityID { get; set; }

        public int StudentProfileID { get; set; }

        public int OpportunityID { get; set; }

        public DateTime SavedAt { get; set; } = DateTime.Now;

        public StudentProfile? StudentProfile { get; set; }

        public Opportunity? Opportunity { get; set; }
    }
}
