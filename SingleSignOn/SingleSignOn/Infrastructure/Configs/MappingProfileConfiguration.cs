using AutoMapper;
using SingleSignOn.Data.Entity;
using SingleSignOn.DTO;
using SingleSignOn.DTO.Response;
using SingleSignOn.DTO.Request;

namespace SingleSignOn.Infrastructure.Configs
{
    public class MappingProfileConfiguration : Profile
    {
        public MappingProfileConfiguration()
        {
            CreateMap<Person, CreatePersonRequest>().ReverseMap();
            CreateMap<Person, UpdatePersonRequest>().ReverseMap();
            CreateMap<Person, PersonQueryResponse>().ReverseMap();
        }
    }
}
