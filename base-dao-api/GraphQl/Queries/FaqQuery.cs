using base_dao_api.Models;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using HotChocolate.AspNetCore.Authorization;

namespace base_dao_api.GraphQl.Queries
{
    
    [ExtendObjectType(typeof(Query))]
    public class FaqQuery
    {
        
        public FaqQuery()
        {
        }

        [Authorize(Roles = new[] { "ROLE-SYSTEM" })]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Faq> GetFaqs([Service] IUnitOfWork _unitOfWork)
        {
            return _unitOfWork.Faq.GetAll();
        }
    }
}
