using AutoMapper;
using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.RequestModels;
using BProduct.Domain.Models;
using MediatR;

namespace BProduct.Application.Features.Commands;

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Guid>
{
    #region Variables
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }
    #endregion

    public async Task<Guid> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var dbEntity = _mapper.Map<Category>(request);

        await _categoryRepository.UpdateAsync(dbEntity);

        return dbEntity.Id;
    }
}
