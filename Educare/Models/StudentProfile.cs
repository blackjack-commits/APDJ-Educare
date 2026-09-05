using System.ComponentModel.DataAnnotations;

namespace Educare.Models
{
    public class StudentProfile
    {
        [Key]
        public int StudentProfileID { get; set; }

        public int UserID { get; set; }

        [StringLength(100)]
        public string? Location { get; set; }

        [StringLength(100)]
        public string? School { get; set; }

        [StringLength(100)]
        public string? CareerInterest { get; set; }

        [StringLength(100)]
        public string? PreferredStudyField { get; set; }

        public double? AverageMark { get; set; }

        public User? User { get; set; }
    }
}
