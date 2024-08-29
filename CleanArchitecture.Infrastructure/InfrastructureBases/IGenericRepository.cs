using Microsoft.EntityFrameworkCore.Storage;

namespace CleanArchitecture.Infrastructure.InfrastructureBases
{
    public interface IGenericRepository<T> where T : class
    {
        Task DeleteRangeAsync(ICollection<T> entities);
        Task<T> GetByIdAsync(dynamic id);
        Task SaveChangesAsync();
        Task<IDbContextTransaction> BeginTransaction();
        Task Commit();
        Task RollBack();
        IQueryable<T> GetTableNoTracking(); // We use no tracking in Get Actions
        IQueryable<T> GetTableAsTracking(); // We use tracking with Insert, Update, Delete Acctions
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(ICollection<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(ICollection<T> entities);
        Task DeleteAsync(T entity);
    }
}
