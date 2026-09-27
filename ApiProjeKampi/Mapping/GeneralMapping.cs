
using ApiProjeKampi.Dtos.MessageDtos;
using ApiProjeKampi.Dtos.ProductsDtos;
using ApiProjeKampi.Entities;
using ApiProjeKampi.WebApi.Dtos.AboutDtos;
using ApiProjeKampi.WebApi.Dtos.CategoryDtos;
using ApiProjeKampi.WebApi.Dtos.FeatureDtos;
using ApiProjeKampi.WebApi.Dtos.ImageDtos;
using ApiProjeKampi.WebApi.Dtos.NotificationDtos;
using ApiProjeKampi.WebApi.Dtos.ReservationDtos;

using AutoMapper;

namespace ApiProjeKampi.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDtos>().ReverseMap();
            CreateMap<Message, CreateMessageDtos>().ReverseMap();
            CreateMap<Message, UpdateMessageDtos>().ReverseMap();
            CreateMap<Message, GetByIdMessageDtos>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategoryDto>().ForMember(x => x.CategoryName, y => y.MapFrom(z => z.Category.CategoryName)).ReverseMap();

            CreateMap<Notification, ResultNotificationDto>().ReverseMap();
            CreateMap<Notification, CreateNotificationDto>().ReverseMap();
            CreateMap<Notification, UpdateNotificationDto>().ReverseMap();
            CreateMap<Notification, GetNotificationByIdDto>().ReverseMap();

            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutByIdDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();

            CreateMap<Reservation, ResultReservationDto>().ReverseMap();
            CreateMap<Reservation, CreateReservationDto>().ReverseMap();
            CreateMap<Reservation, UpdateReservationDto>().ReverseMap();
            CreateMap<Reservation, GetReservationByIdDto>().ReverseMap();


            CreateMap<Image, ResultImageDto>().ReverseMap();
            CreateMap<Image, CreateImageDto>().ReverseMap();
            CreateMap<Image, UpdateImageDto>().ReverseMap();
            CreateMap<Image, GetImageByIdDto>().ReverseMap();

        }
    }
}