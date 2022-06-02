using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.RequestModels;
using BProduct.Domain.Models;
using MediatR;

namespace BProduct.Application.Features.Commands;

public class CreateCategoryAttributeCommandHandler : IRequestHandler<CreateCategoryAttributeCommand, Guid>
{
    #region Variables
    private readonly ICategoryAttributeRepository _categoryAttributeRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Construcotr
    public CreateCategoryAttributeCommandHandler(ICategoryAttributeRepository categoryAttributeRepository, IMapper mapper)
    {
        _categoryAttributeRepository = categoryAttributeRepository;
        _mapper = mapper;
    }
    #endregion

    public async Task<Guid> Handle(CreateCategoryAttributeCommand request, CancellationToken cancellationToken)
    {
        var dbEntity = _mapper.Map<CategoryAttribute>(request);

        var result = await _categoryAttributeRepository.AddAsync(dbEntity);

        if (result == 0)
            return Guid.Empty;

        return dbEntity.Id;
    }
}
