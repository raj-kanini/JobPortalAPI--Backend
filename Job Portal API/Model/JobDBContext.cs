using Microsoft.EntityFrameworkCore;

namespace Job_Portal_API.Model
{
    public class JobDBContext:DbContext
    {
        public DbSet<Form> Form { get; set; }
        public DbSet<Job_Description> JobDescription { get; set; }

        public JobDBContext(DbContextOptions<JobDBContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
