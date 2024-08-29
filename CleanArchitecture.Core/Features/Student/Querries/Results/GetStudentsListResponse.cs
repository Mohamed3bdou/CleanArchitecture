namespace CleanArchitecture.Core.Features.Student.Querries.Results
{
    public class GetStudentsListResponse
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? StudentAddress { get; set; }
        public string? StudentPhone { get; set; }
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
    }
}
