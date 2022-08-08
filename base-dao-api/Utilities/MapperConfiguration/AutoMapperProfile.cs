using AutoMapper;
using base_dao_api.GraphQl.Mutations.Payloads;
using base_dao_api.Models;
using System.Security.Claims;

namespace base_dao_api.Utilities.MapperConfiguration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Faq, FaqPayload>().ReverseMap();
            CreateMap<Pool, PoolPayload>().ReverseMap();
            CreateMap<PoolFunder, PoolFunderPayload>().ReverseMap();

            //CreateMap<ClaimsPrincipal, ClaimSettings>()
            //    .ForMember(t => t.Name, opt => opt.MapFrom(s => s.FindFirstValue(ClaimTypes.Name).FirstOrDefault() == null ? s.FindFirstValue(ClaimTypes.NameIdentifier).FirstOrDefault() : s.FindFirstValue(ClaimTypes.Name).FirstOrDefault()))
            //    .ForMember(t => t.Role, opt => opt.MapFrom(s => s.FindFirstValue(ClaimTypes.Role).FirstOrDefault()))
        }
    }
}
