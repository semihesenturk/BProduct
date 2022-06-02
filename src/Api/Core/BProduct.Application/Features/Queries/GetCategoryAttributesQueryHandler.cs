using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.Queries;
using MediatR;

namespace BProduct.Application.Features.Queries;

public class GetCategoryAttributesQueryHandler : IRequestHandler<GetCategoryAttributesQuery, List<GetCategoryAttributesViewModel>>
{
    #region Variables
    private readonly ICategoryAttributeRepository _categoryAttributeRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetCategoryAttributesQueryHandler(ICategoryAttributeRepository categoryAttributeRepository, IMapper mapper)
    {
        _categoryAttributeRepository = categoryAttributeRepository;
        _mapper = mapper;
    }
    #endregion


    public async Task<List<GetCategoryAttributesViewModel>> Handle(GetCategoryAttributesQuery request, CancellationToken cancellationToken)
    {
        var dbReuslt = await _categoryAttributeRepository.GetAttributesByCategory(request.CategoryId);

        var returnResult = _mapper.Map<List<GetCategoryAttributesViewModel>>(dbReuslt);

        return returnResult;
    }
}
