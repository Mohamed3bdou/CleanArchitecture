using CleanArchitecture.Service.Abstract;
using CleanArchitecture.Service.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Service
{
    public static class ModuleServicesDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}
