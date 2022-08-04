using base_dao_api.Data;
using base_dao_api.Repositories.Interfaces;

namespace base_dao_api.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        protected readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
