using CleanArchitecture.Data.Configuration;
using CleanArchitecture.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<DepartmentSubject> DepartmentSubjects { get; set; }
        public virtual DbSet<StudentSubject> StudentSubjects { get; set; }
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}


// ↑ == → new StudentConfiguration().Configure(modelBuilder.Entity<Student>());
// ↑ == → modelBuilder.ApplyConfiguration(new StudentConfiguration());