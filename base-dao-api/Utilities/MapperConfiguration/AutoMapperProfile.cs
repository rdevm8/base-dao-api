using AutoMapper;
using base_dao_api.GraphQl.Mutations.Payloads;
using base_dao_api.Models;

namespace base_dao_api.Utilities.MapperConfiguration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Faq, FaqPayload>().ReverseMap();
            CreateMap<Pool, PoolPayload>().ReverseMap();
            CreateMap<PoolFunder, PoolFunderPayload>().ReverseMap();
        }
    }
}
