using AutoMapper;

namespace CleanArchitecture.Core.Mapping.StudentMaping
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudentsListMapper();
        }
    }
}
