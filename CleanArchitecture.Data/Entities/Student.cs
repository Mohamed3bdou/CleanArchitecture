namespace CleanArchitecture.Data.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }

        // Navigation Properties
        public Department Department { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
