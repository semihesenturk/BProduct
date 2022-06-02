using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.Queries;
using MediatR;

namespace BProduct.Application.Features.Queries;

public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, GetCategoryViewModel>
{
    #region Variables
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetCategoryQueryHandler(ICategoryRepository categoryRepositor, IMapper mapper)
    {
        _categoryRepository = categoryRepositor;
        _mapper = mapper;
    }
    #endregion

    public async Task<GetCategoryViewModel> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        var dbEntity = await _categoryRepository.GetByIdAsync(request.Id);

        return _mapper.Map<GetCategoryViewModel>(dbEntity);
    }
}
