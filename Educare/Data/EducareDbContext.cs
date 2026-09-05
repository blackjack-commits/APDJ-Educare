using Microsoft.EntityFrameworkCore;
using Educare.Models;
namespace Educare.Data
{
    public class EducareDbContext: DbContext
    {
        public EducareDbContext(DbContextOptions<EducareDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<StudentProfile> StudentProfiles { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<SavedOpportunity> SavedOpportunities { get; set; }
    }
}
