using base_dao_api.Data;
using base_dao_api.Models;
using base_dao_api.Repositories.Interfaces;

namespace base_dao_api.Repositories
{
    public class PoolActivityRepository : GenericRepository<PoolActivity>, IPoolActivityRepository
    {
        public PoolActivityRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
