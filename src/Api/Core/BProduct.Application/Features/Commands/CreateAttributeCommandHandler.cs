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

        await _attributeRepository.AddAsync(dbEntity);
     
        return dbEntity.Id;



        //var dbEntry = _mapper.Map<Api.Domain.Models.Entry>(request);

        //await _entryRepository.AddAsync(dbEntry);

        //return dbEntry.Id;
    }
}
