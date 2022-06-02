using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.RequestModels;
using BProduct.Domain.Models;
using MediatR;

namespace BProduct.Application.Features.Commands;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Guid>
{
    #region Variables
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    #endregion

    public async Task<Guid> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var dbEntity = _mapper.Map<Product>(request);

        await _productRepository.UpdateAsync(dbEntity);

        return dbEntity.Id;
    }
}
