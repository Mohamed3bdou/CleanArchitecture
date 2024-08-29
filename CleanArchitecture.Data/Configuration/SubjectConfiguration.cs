using CleanArchitecture.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Data.Configuration
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(k => k.SubjectId);

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR(100)");

            builder.HasMany(s => s.DepartmentSubjects)
                .WithOne(ds => ds.Subject)
                .HasForeignKey(ds => ds.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(s => s.StudentSubjects)
                .WithOne(ss => ss.Subject)
                .HasForeignKey(ss => ss.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Subjects");
        }
    }
}
