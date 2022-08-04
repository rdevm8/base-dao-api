using AutoMapper;
using base_dao_api.GraphQl.Payload;
using base_dao_api.Models;

namespace base_dao_api.Utilities.MapperConfiguration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Faq, FaqPayload>().ReverseMap();
        }
    }
}
