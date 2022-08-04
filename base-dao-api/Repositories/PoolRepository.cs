using base_dao_api.Data;
using base_dao_api.Models;
using base_dao_api.Repositories.Interfaces;

namespace base_dao_api.Repositories
{
    public class PoolRepository : GenericRepository<Pool>, IPoolRepository
    {
        public PoolRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
