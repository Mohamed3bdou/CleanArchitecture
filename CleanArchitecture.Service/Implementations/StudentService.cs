using CleanArchitecture.Data.Entities;
using CleanArchitecture.Infrastructure.Abstract;
using CleanArchitecture.Service.Abstract;

namespace CleanArchitecture.Service.Implementations
{
    public class StudentService : IStudentService
    {
        #region FILDS
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }
        #endregion

        #region GET 
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _studentRepository.GetStudentsListAsync();
        }
        #endregion
    }
}
