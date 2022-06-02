using AutoMapper;
using BProduct.Common.Models.Queries;
using BProduct.Common.Models.RequestModels;
using BProduct.Domain.Models;

namespace BProduct.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProductCommand, Product>()
                .ReverseMap();

            CreateMap<GetCategoryAttributesViewModel, CategoryAttribute>()
                .ReverseMap();

            CreateMap<CreateCategoryAttributeCommand, CategoryAttribute>()
                .ReverseMap();

            CreateMap<CreateAttributeCommand, Domain.Models.Attribute>()
                .ReverseMap();

            CreateMap<GetCategoryViewModel, Category>()
                .ReverseMap();

            CreateMap<GetProductAttributesViewModel, ProductAttribute>()
                .ReverseMap();

            CreateMap<CreateProductAttributeCommand, ProductAttribute>()
                .ReverseMap();
        }
    }
}
