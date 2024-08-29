using CleanArchitecture.Core.Features.Student.Querries.Results;
using CleanArchitecture.Data.Entities;

namespace CleanArchitecture.Core.Mapping.StudentMaping
{
    public partial class StudentProfile
    {
        public void GetStudentsListMapper()
        {
            CreateMap<Student, GetStudentsListResponse>()
                .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.StudentId))
                .ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.StudentAddress, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.StudentPhone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.Department.DepartmentId))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name));
        }
    }
}
