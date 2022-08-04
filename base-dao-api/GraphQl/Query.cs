using base_dao_api.Data;
using base_dao_api.Models;

namespace base_dao_api.GraphQl
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Faq> GetFaqs([Service] ApplicationDbContext context) =>
            context.Faqs;
    }


}
