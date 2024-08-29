namespace CleanArchitecture.Data.Entities
{
    public class DepartmentSubject
    {
        public int DepartmentId { get; set; }
        public int SubjectId { get; set; }

        // Navigation Properties
        public Department Department { get; set; }
        public Subject Subject { get; set; }
    }
}
