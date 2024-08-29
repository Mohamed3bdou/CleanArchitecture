using CleanArchitecture.Data.Entities;
using CleanArchitecture.Infrastructure.InfrastructureBases;

namespace CleanArchitecture.Infrastructure.Abstract
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<List<Student>> GetStudentsListAsync();
    }
}
