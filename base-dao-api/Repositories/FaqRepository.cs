using base_dao_api.Data;
using base_dao_api.Models;
using base_dao_api.Repositories.Interfaces;

namespace base_dao_api.Repositories
{
    public class FaqRepository : GenericRepository<Faq>, IFaqRepository
    {
        public FaqRepository(ApplicationDbContext context) : base(context)
        {
        }

        public int GetMaxFaqOrder()
        {
            int res = 0;

            res = base._context.Faqs.Max(x => x.Order);

            return res;
        }
    }
}
