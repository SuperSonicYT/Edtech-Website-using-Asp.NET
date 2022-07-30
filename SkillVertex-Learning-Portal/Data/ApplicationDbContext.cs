using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkillVertex_Learning_Portal.Models;

namespace SkillVertex_Learning_Portal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SkillVertex_Learning_Portal.Models.CourseCategory>? CourseCategory { get; set; }
        public DbSet<SkillVertex_Learning_Portal.Models.Courses>? Courses { get; set; }
        public DbSet<SkillVertex_Learning_Portal.Models.Contact>? Contact { get; set; }
    }
}