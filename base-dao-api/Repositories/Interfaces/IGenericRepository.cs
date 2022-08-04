namespace base_dao_api.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        T Get(Guid id);

        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
