using CleanArchitecture.API.Base;
using CleanArchitecture.Core.Features.Student.Querries.Models;
using CleanArchitecture.Data.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    public class StudentController : AppBaseController
    {
        [HttpGet(Router.StudentRouting.List)]
        public async Task<IActionResult> GetStudentsList()
        {
            var response = await Mediator.Send(new GetStudentsListQuery());
            return Ok(response);
        }
    }
}
