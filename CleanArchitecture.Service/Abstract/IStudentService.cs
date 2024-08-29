using CleanArchitecture.Data.Entities;

namespace CleanArchitecture.Service.Abstract
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudentsListAsync();
    }
}
