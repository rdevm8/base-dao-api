using base_dao_api.Models;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using HotChocolate.AspNetCore.Authorization;
using System.Security.Claims;
using base_dao_api.Utilities.Extensions;

namespace base_dao_api.GraphQl.Queries
{
    
    [ExtendObjectType(OperationTypeNames.Query)]
    public class CodeDetailQuery
    {
        private readonly IUnitOfWork _unitOfWork;

        public CodeDetailQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Authorize]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<CodeDetail> GetCodeDetails()
        {
            return _unitOfWork.CodeDetail.GetAll();
        }
    }
}
