using CleanArchitecture.Infrastructure.Abstract;
using CleanArchitecture.Infrastructure.InfrastructureBases;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection service)
        {
            service.AddTransient<IStudentRepository, StudentRepository>();
            service.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return service;
        }
    }
}
