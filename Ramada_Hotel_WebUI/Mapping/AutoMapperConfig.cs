using AutoMapper;
using EntityLayer.Concrete;
using Ramada_Hotel_WebUI.Dtos.AboutDto;
using Ramada_Hotel_WebUI.Dtos.BookingDto;
using Ramada_Hotel_WebUI.Dtos.GuestDto;
using Ramada_Hotel_WebUI.Dtos.LoginDto;
using Ramada_Hotel_WebUI.Dtos.RegisterDto;
using Ramada_Hotel_WebUI.Dtos.ServiceDto;
using Ramada_Hotel_WebUI.Dtos.StaffDto;
using Ramada_Hotel_WebUI.Dtos.SubscribeDto;
using Ramada_Hotel_WebUI.Dtos.TestimonialDto;

namespace Ramada_Hotel_WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            //CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            //CreateMap<LoginUserDto, AppUser>().ReverseMap();

            //CreateMap<ResultAboutDto, About>().ReverseMap();
            //CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            //CreateMap<CreateBookingDto, Booking>().ReverseMap();
            //CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

            //CreateMap<CreateGuestDto, Guest>().ReverseMap();
            //CreateMap<UpdateGuestDto, Guest>().ReverseMap();
        }
    }
}