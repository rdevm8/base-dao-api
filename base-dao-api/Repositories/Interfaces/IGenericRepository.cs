namespace base_dao_api.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
