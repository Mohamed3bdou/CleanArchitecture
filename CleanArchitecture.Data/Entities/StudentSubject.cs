namespace CleanArchitecture.Data.Entities
{
    public class StudentSubject
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }

        // Navigation Properties
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
