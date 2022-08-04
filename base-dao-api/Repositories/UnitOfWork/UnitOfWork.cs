using base_dao_api.Data;
using base_dao_api.Repositories.Interfaces;
using base_dao_api.Repositories.UnitOfWork.Interfaces;

namespace base_dao_api.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            CodeDetail = new CodeDetailRepository(context);
            CodeHeader = new CodeHeaderRepository(context);
            Faq = new FaqRepository(context);
            PoolActivity = new PoolActivityRepository(context);
            PoolFunder = new PoolFunderRepository(context);
            Pool = new PoolRepository(context);
            User = new UserRepository(context);
            UserRole = new UserRoleRepository(context);

        }

        public ICodeDetailRepository CodeDetail
        {
            get;
            private set;
        }
        public ICodeHeaderRepository CodeHeader
        {
            get;
            private set;
        }
        public IFaqRepository Faq
        {
            get;
            private set;
        }
        public IPoolRepository Pool
        {
            get;
            private set;
        }
        public IPoolActivityRepository PoolActivity
        {
            get;
            private set;
        }
        public IPoolFunderRepository PoolFunder
        {
            get;
            private set;
        }

        public IUserRepository User
        {
            get;
            private set;
        }

        public IUserRoleRepository UserRole
        {
            get;
            private set;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
