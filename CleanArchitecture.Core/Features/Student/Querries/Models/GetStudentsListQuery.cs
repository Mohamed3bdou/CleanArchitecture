using CleanArchitecture.Core.Basis;
using CleanArchitecture.Core.Features.Student.Querries.Results;
using MediatR;

namespace CleanArchitecture.Core.Features.Student.Querries.Models
{
    public class GetStudentsListQuery : IRequest<Response<List<GetStudentsListResponse>>>
    {
    }
}
