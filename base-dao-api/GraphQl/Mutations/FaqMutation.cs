using AutoMapper;
using base_dao_api.GraphQl.Payloads;
using base_dao_api.GraphQl.Validators;
using base_dao_api.Models;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using FluentValidation.Results;
using AppAny.HotChocolate.FluentValidation;

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

            _unitOfWork.Faq.Add(res);

            await _unitOfWork.SaveAsync();
            return res;
        }
    }
}
