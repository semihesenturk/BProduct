using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.RequestModels;
using BProduct.Domain.Models;
using MediatR;

namespace BProduct.Application.Features.Commands;

public class CreateProductAttributeCommandHandler : IRequestHandler<CreateProductAttributeCommand, Guid>
{
    #region Variables
    private readonly IProductAttributeRepository _productAttributeRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateProductAttributeCommandHandler(IProductAttributeRepository productAttributeRepository, IMapper mapper)
    {
        _productAttributeRepository = productAttributeRepository;
        _mapper = mapper;
    }
    #endregion

    public async Task<Guid> Handle(CreateProductAttributeCommand request, CancellationToken cancellationToken)
    {
        var dbEntity = _mapper.Map<ProductAttribute>(request);

        var result = await _productAttributeRepository.AddAsync(dbEntity);

        if (result == 0)
            return Guid.Empty;

        return dbEntity.Id;
    }
}
