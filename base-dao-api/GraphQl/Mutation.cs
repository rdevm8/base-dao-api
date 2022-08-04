using AutoMapper;
using base_dao_api.Data;
using base_dao_api.GraphQl.Payload;
using base_dao_api.Models;

namespace base_dao_api.GraphQl
{
    public class Mutation
    {
        private readonly IMapper _mapper;

        public Mutation(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<Faq> AddFaq([Service] ApplicationDbContext context, FaqPayload faq)
        {
            Faq res = _mapper.Map<Faq>(faq);

            //Faq res = new Faq {
            //    Question = faq.Question,
            //    Answer = faq.Answer,
            //    Order = faq.Order
            //};


            context.Faqs.Add(res);
            await context.SaveChangesAsync();
            return res;
            // Omitted code for brevity
        }
    }


}
