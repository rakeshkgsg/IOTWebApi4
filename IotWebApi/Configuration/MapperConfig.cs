using AutoMapper;
using IotWebApi.Dto;
using IotWebApi.Entities;

namespace IotWebApi.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<UserDto,
                UserEto>().ReverseMap();
        }
    }
}
