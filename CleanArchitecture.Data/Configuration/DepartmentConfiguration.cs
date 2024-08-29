using CleanArchitecture.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Data.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(k => k.DepartmentId);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("NVARCHAR(50)");

            builder.HasMany(s => s.Students)
                .WithOne(d => d.Department)
                .HasForeignKey(k => k.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(s => s.DepartmentSubjects)
                .WithOne(d => d.Department)
                .HasForeignKey(k => k.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Departments");
        }
    }
}
