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
            CreateMap<CreateAttributeCommand, Domain.Models.Attribute>()
                .ReverseMap();

            CreateMap<GetAttributeViewModel, Domain.Models.Attribute>()
                .ReverseMap();

            CreateMap<CreateCategoryAttributeCommand, CategoryAttribute>()
               .ReverseMap();

            CreateMap<GetCategoryAttributesViewModel, CategoryAttribute>()
                .ReverseMap();


            CreateMap<CreateProductCommand, Product>()
                .ReverseMap();

            CreateMap<GetProductViewModel, Product>()
                .ReverseMap();


            CreateMap<CreateCategoryCommand, Category>()
                .ReverseMap();

            CreateMap<GetCategoryViewModel, Category>()
                .ReverseMap();


            CreateMap<CreateProductAttributeCommand, ProductAttribute>()
                .ReverseMap();

            CreateMap<GetProductAttributesViewModel, ProductAttribute>()
                .ReverseMap();

        }
    }
}
