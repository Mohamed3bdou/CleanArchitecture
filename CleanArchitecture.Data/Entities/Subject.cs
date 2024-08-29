namespace CleanArchitecture.Data.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Title { get; set; }

        // Navigation Properties
        public ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
