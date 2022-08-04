using base_dao_api.Data;
using base_dao_api.Models;
using base_dao_api.Repositories.Interfaces;

namespace base_dao_api.Repositories
{
    public class PoolFunderRepository : GenericRepository<PoolFunder>, IPoolFunderRepository
    {
        public PoolFunderRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
