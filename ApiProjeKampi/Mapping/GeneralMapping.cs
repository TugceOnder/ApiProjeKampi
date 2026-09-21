using ApiProjeKampi.Dtos.FeatureDtos;
using ApiProjeKampi.Dtos.MessageDtos;
using ApiProjeKampi.Dtos.ProductsDtos;
using ApiProjeKampi.Entities;

using ApiProjeKampi.WebUI.Dtos.CategoryDtos;
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

        }
    }
}