using base_dao_api.Data;
using base_dao_api.Models;
using base_dao_api.Repositories.Interfaces;

namespace base_dao_api.Repositories
{
    public class CodeHeaderRepository : GenericRepository<CodeHeader>, ICodeHeaderRepository
    {
        public CodeHeaderRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
