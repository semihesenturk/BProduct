using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.Queries;
using MediatR;

namespace BProduct.Application.Features.Queries;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductViewModel>
{
    #region Variables
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Construcotr
    public GetProductQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    #endregion

    public async Task<GetProductViewModel> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var dbEntity = await _productRepository.GetSingleAsync(s => s.Id == request.Id, false, s => s.Attributes);
        //var dbEntity = await _categoryRepository.GetSingleAsync(s => s.Id == request.Id, false, s => s.Attributes);

        return _mapper.Map<GetProductViewModel>(dbEntity);
    }
}
