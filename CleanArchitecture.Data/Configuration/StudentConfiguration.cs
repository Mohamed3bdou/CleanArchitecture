using CleanArchitecture.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Data.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(k => k.StudentId);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("NVARCHAR(50)");

            builder.Property(p => p.Address)
            .HasMaxLength(100)
            .HasColumnType("NVARCHAR(100)");

            builder.Property(p => p.Phone)
                .HasMaxLength(15)
                .HasColumnType("NVARCHAR(15)");

            builder.HasOne(d => d.Department)
                .WithMany(s => s.Students)
                .HasForeignKey(k => k.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(ss => ss.StudentSubjects)
                .WithOne(s => s.Student)
                .HasForeignKey(k => k.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Students");
        }
    }
}
