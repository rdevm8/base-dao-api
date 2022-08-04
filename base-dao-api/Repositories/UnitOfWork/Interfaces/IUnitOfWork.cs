using base_dao_api.Repositories.Interfaces;

namespace base_dao_api.Repositories.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICodeDetailRepository CodeDetail { get; }

        ICodeHeaderRepository CodeHeader { get; }

        IFaqRepository Faq { get; }

        IPoolRepository Pool { get; }

        IPoolActivityRepository PoolActivity { get; }

        IPoolFunderRepository PoolFunder { get; }

        IUserRepository User { get; }

        IUserRoleRepository UserRole { get; }

        int Save();

        Task<int> SaveAsync();
    }
}
