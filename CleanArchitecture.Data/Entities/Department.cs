namespace CleanArchitecture.Data.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
    }
}
