using AutoMapper;
using base_dao_api.GraphQl.Mutations.Payloads;
using base_dao_api.GraphQl.Validators;
using base_dao_api.Models;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using FluentValidation.Results;
using AppAny.HotChocolate.FluentValidation;
using HotChocolate.AspNetCore.Authorization;
using base_dao_api.Utilities.Constants;
using System.Security.Claims;
using base_dao_api.Utilities.Extensions;

namespace base_dao_api.GraphQl.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class FaqMutation
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public FaqMutation(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [Authorize(Roles = new[] { RoleCodes.System})]
        public async Task<Faq> AddFaq(ClaimsPrincipal _claimsPrincipal,
            [UseFluentValidation, UseValidator<FaqPayloadValidator>]  FaqPayload faq)
        {
            Faq res = _mapper.Map<Faq>(faq);
            res.Order = _unitOfWork.Faq.GetMaxFaqOrder() + 1;
            res.CreatedBy = _claimsPrincipal.GetUserName();
            res.UpdatedBy = _claimsPrincipal.GetUserName();

            _unitOfWork.Faq.Add(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { RoleCodes.System })]
        public async Task<Faq> UpdateFaq(Guid id,
            ClaimsPrincipal _claimsPrincipal,
            [UseFluentValidation, UseValidator<FaqPayloadValidator>] FaqPayload faq)
        {
            Faq res = await _unitOfWork.Faq.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error("Faq not found!"));
            }

            res.Question = faq.Question;
            res.Answer = faq.Answer;
            res.UpdatedBy = _claimsPrincipal.GetUserName();
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.Faq.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { RoleCodes.System })]
        public async Task<Faq> DeleteFaq(Guid id,
            ClaimsPrincipal _claimsPrincipal)
        {
            Faq res = await _unitOfWork.Faq.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error("Faq not found!"));
            }

            res.IsDeleted = true;
            res.UpdatedBy = _claimsPrincipal.GetUserName();
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.Faq.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }
    }
}
