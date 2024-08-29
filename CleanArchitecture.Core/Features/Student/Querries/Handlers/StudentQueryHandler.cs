using AutoMapper;
using CleanArchitecture.Core.Basis;
using CleanArchitecture.Core.Features.Student.Querries.Models;
using CleanArchitecture.Core.Features.Student.Querries.Results;
using CleanArchitecture.Service.Abstract;
using MediatR;

namespace CleanArchitecture.Core.Features.Student.Querries.Handlers
{
    public class StudentQueryHandler : ResponseHandler,
                                      IRequestHandler<GetStudentsListQuery, Response<List<GetStudentsListResponse>>>
    {
        #region FIELDS 
        private readonly IStudentService _service;
        private readonly IMapper _mapper;
        public StudentQueryHandler(IStudentService service, IMapper mapper)
        {
            this._service = service;
            this._mapper = mapper;
        }
        #endregion
        public async Task<Response<List<GetStudentsListResponse>>> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            var _list = await _service.GetStudentsListAsync();
            var _listMapper = _mapper.Map<List<GetStudentsListResponse>>(_list);
            return Success(_listMapper);
        }
    }
}
