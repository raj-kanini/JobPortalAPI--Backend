using Microsoft.EntityFrameworkCore;

namespace Job_Portal_API.Model
{
    public class JobDBContext:DbContext
    {
        // Represents the 'Form' table in the database
        public DbSet<Form> Form { get; set; }

        // Represents the 'JobDescription' table in the database
        public DbSet<Job_Description> JobDescription { get; set; }

        public JobDBContext(DbContextOptions<JobDBContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
