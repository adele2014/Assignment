using AutoMapper;
using StockAPI.Data.Entity;
using StockAPI.DTO;
using StockAPI.DTO.Response;
using StockAPI.DTO.Request;

namespace StockAPI.Infrastructure.Configs
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
