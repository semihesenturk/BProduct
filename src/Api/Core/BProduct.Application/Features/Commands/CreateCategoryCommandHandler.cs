using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.RequestModels;
using BProduct.Domain.Models;
using MediatR;

namespace BProduct.Application.Features.Commands;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Guid>
{
    #region Variables
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }
    #endregion

    public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var dbEntity = _mapper.Map<Category>(request);

        var result = await _categoryRepository.AddAsync(dbEntity);

        if (result == 0)
            return Guid.Empty;

        return dbEntity.Id;
    }
}
