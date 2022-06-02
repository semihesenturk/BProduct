using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.Queries;
using MediatR;

namespace BProduct.Application.Features.Queries;

public class GetProductAttributesQueryHandler : IRequestHandler<GetProductAttributesQuery, List<GetProductAttributesViewModel>>
{
    #region Variables
    private readonly IProductAttributeRepository _productAttributeRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetProductAttributesQueryHandler(IProductAttributeRepository productAttributeRepository, IMapper mapper)
    {
        _productAttributeRepository = productAttributeRepository;
        _mapper = mapper;
    }
    #endregion

    public async Task<List<GetProductAttributesViewModel>> Handle(GetProductAttributesQuery request, CancellationToken cancellationToken)
    {
        var dbEntities = await _productAttributeRepository.GetList(s => s.ProductId == request.ProductId);

        return _mapper.Map<List<GetProductAttributesViewModel>>(dbEntities);
    }
}
