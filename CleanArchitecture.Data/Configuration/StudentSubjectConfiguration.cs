using CleanArchitecture.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Data.Configuration
{
    public class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasKey(k => new { k.StudentId, k.SubjectId });

            builder.HasOne(s => s.Student)
                .WithMany(ss => ss.StudentSubjects)
                .HasForeignKey(s => s.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ds => ds.Subject)
            .WithMany(s => s.StudentSubjects)
            .HasForeignKey(ds => ds.SubjectId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("StudentSubjects");
        }
    }
}
