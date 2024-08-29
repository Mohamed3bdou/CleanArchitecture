using CleanArchitecture.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Data.Configuration
{
    public class DepartmentSubjectConfiguration : IEntityTypeConfiguration<DepartmentSubject>
    {
        public void Configure(EntityTypeBuilder<DepartmentSubject> builder)
        {
            builder.HasKey(k => new { k.DepartmentId, k.SubjectId });

            builder.HasOne(ds => ds.Department)
            .WithMany(d => d.DepartmentSubjects)
            .HasForeignKey(ds => ds.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ds => ds.Subject)
                .WithMany(s => s.DepartmentSubjects)
                .HasForeignKey(ds => ds.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("DepartmentSubjects");
        }
    }
}
