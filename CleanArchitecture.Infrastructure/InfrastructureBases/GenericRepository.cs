using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CleanArchitecture.Infrastructure.InfrastructureBases
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region FIELDS
        private readonly ApplicationDbContext _dbContxet;

        public GenericRepository(ApplicationDbContext dbContxet)
        {
            this._dbContxet = dbContxet;
        }
        #endregion

        #region CREATE
        public virtual async Task<T> AddAsync(T entity)
        {
            try
            {
                await _dbContxet.Set<T>().AddAsync(entity);
                await _dbContxet.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public virtual async Task AddRangeAsync(ICollection<T> entities)
        {
            try
            {
                await _dbContxet.Set<T>().AddRangeAsync(entities);
                await _dbContxet.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        #endregion

        #region UPDATE 
        public virtual async Task UpdateAsync(T entity)
        {
            try
            {
                _dbContxet.Set<T>().Update(entity);
                await _dbContxet.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public virtual async Task UpdateRangeAsync(ICollection<T> entities)
        {
            try
            {
                _dbContxet.Set<T>().UpdateRange(entities);
                await _dbContxet.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        #endregion

        #region DELETE
        public virtual async Task DeleteAsync(T entity)
        {
            try
            {
                _dbContxet.Set<T>().Remove(entity);
                await _dbContxet.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public virtual async Task DeleteRangeAsync(ICollection<T> entities)
        {
            try
            {
                _dbContxet.Set<T>().RemoveRange(entities);
                await _dbContxet.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        #endregion

        #region GET 
        public virtual async Task<T> GetByIdAsync(dynamic id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            try
            {
                return await _dbContxet.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving the entity.", ex);
            }
        }
        public IQueryable<T> GetTableAsTracking()
        {
            try
            {
                return _dbContxet.Set<T>().AsQueryable();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Something went wrong!.", ex);
            }
        }
        public IQueryable<T> GetTableNoTracking()
        {
            try
            {
                return _dbContxet.Set<T>().AsNoTracking().AsQueryable();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Something went wrong!.", ex);
            }
        }
        #endregion

        #region TRANSACTION
        public async Task<IDbContextTransaction> BeginTransaction()
        {
            try
            {
                return await _dbContxet.Database.BeginTransactionAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Something went wrong!.", ex);
            }
        }

        public async Task Commit()
        {
            try
            {
                await _dbContxet.Database.CommitTransactionAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Something went wrong!", ex);
            }
        }

        public async Task RollBack()
        {
            try
            {
                await _dbContxet.Database.RollbackTransactionAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Something went wrong!", ex);
            }
        }
        #endregion

        #region SAVECHANGES
        public async Task SaveChangesAsync()
        {
            try
            {
                await _dbContxet.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Something went wrong!", ex);
            }
        }
        #endregion
    }
}
