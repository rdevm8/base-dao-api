using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace base_dao_api.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<IEnumerable<T>> GetAsync(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);

        Task<T> GetAsync(Guid id);

        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
