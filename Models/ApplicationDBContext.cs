using Microsoft.EntityFrameworkCore;

namespace CWK_GeaduationExam7_TakeHomeProject.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Activity> Activities { get; set; }
    }
}
