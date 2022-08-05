using AutoMapper;
using base_dao_api.GraphQl.Mutations.Payloads;
using base_dao_api.GraphQl.Validators;
using base_dao_api.Models;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using FluentValidation.Results;
using AppAny.HotChocolate.FluentValidation;
using HotChocolate.AspNetCore.Authorization;

namespace base_dao_api.GraphQl.Mutations
{
    [ExtendObjectType(typeof(Mutation))]
    public class FaqMutation
    {
        private readonly IMapper _mapper;

        public FaqMutation(IMapper mapper)
        {
            _mapper = mapper;
        }

        
        public async Task<Faq> AddFaq([Service] IUnitOfWork _unitOfWork,
            [UseFluentValidation, UseValidator<FaqPayloadValidator>]  FaqPayload faq)
        {
            Faq res = _mapper.Map<Faq>(faq);
            res.Order = _unitOfWork.Faq.GetMaxFaqOrder() + 1;

            _unitOfWork.Faq.Add(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        public async Task<Faq> UpdateFaq([Service] IUnitOfWork _unitOfWork,
            Guid id,
            [UseFluentValidation, UseValidator<FaqPayloadValidator>] FaqPayload faq)
        {
            Faq res = await _unitOfWork.Faq.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error("Faq not found!"));
            }

            res.Question = faq.Question;
            res.Answer = faq.Answer;
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.Faq.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        public async Task<Faq> DeleteFaq([Service] IUnitOfWork _unitOfWork,
            Guid id)
        {
            Faq res = await _unitOfWork.Faq.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error("Faq not found!"));
            }

            res.IsDeleted = true;

            _unitOfWork.Faq.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }
    }
}
