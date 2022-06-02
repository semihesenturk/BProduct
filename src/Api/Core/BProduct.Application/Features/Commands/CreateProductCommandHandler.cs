using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.RequestModels;
using BProduct.Domain.Models;
using MediatR;

namespace BProduct.Application.Features.Commands;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
{
    #region Variables
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    #endregion

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var dbEntity = _mapper.Map<Product>(request);

        var result = await _productRepository.AddAsync(dbEntity);

        if (result == 0)
            return Guid.Empty;

        return dbEntity.Id;
    }
}
