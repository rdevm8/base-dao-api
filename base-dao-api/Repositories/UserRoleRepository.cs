using base_dao_api.Data;
using base_dao_api.Models;
using base_dao_api.Repositories.Interfaces;

namespace base_dao_api.Repositories
{
    public class UserRoleRepository : GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
