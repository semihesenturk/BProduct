using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.RequestModels;
using MediatR;

namespace BProduct.Application.Features.Commands;

public class CreateAttributeCommandHandler : IRequestHandler<CreateAttributeCommand, Guid>
{
    #region Variables
    private readonly IAttributeRepository _attributeRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateAttributeCommandHandler(IAttributeRepository attributeRepository, IMapper mapper)
    {
        _attributeRepository = attributeRepository;
        _mapper = mapper;
    }
    #endregion

    public async Task<Guid> Handle(CreateAttributeCommand request, CancellationToken cancellationToken)
    {
        var dbEntity = _mapper.Map<Domain.Models.Attribute>(request);

        var result = await _attributeRepository.AddAsync(dbEntity);

        if (result == 0)
            return Guid.Empty;

        return dbEntity.Id;
    }
}
