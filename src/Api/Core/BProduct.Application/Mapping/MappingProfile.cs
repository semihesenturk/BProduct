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
        }
    }
}
