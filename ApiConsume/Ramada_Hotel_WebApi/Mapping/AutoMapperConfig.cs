using AutoMapper;
using DTOLayer.DTOs.RoomDto;
using EntityLayer.Concrete;

namespace Ramada_Hotel_WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<RoomUpdateDto, Room>().ReverseMap();
        }
    }
}
