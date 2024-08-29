using CleanArchitecture.Data.Entities;
using CleanArchitecture.Infrastructure.Abstract;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        #region FILDES
        private readonly DbSet<Student> _students;
        public StudentRepository(ApplicationDbContext _dbContxet) : base(_dbContxet)
        {
            _students = _dbContxet.Set<Student>();
        }
        #endregion

        #region GET
        public async Task<List<Student>> GetStudentsListAsync()
        {
            try
            {
                return await _students.Include(d => d.Department).Select(s => new Student
                {
                    StudentId = s.StudentId,
                    Name = s.Name,
                    Address = s.Address,
                    Phone = s.Phone,
                    Department = new Department
                    {
                        DepartmentId = s.DepartmentId,
                        Name = s.Department.Name
                    }
                }).ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<Student> { };
            }
        }
        #endregion
    }
}
