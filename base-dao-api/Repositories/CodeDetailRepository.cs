using base_dao_api.Data;
using base_dao_api.Models;
using base_dao_api.Repositories.Interfaces;

namespace base_dao_api.Repositories
{
    public class CodeDetailRepository : GenericRepository<CodeDetail>, ICodeDetailRepository
    {
        public CodeDetailRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
