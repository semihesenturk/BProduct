using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.RequestModels;
using MediatR;

namespace BProduct.Application.Features.Commands;

public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
{
    #region Variables
    private readonly ICategoryRepository _categoryRepository;
    #endregion

    #region Constructor
    public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    #endregion

    public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var result = await _categoryRepository.DeleteAsync(request.Id);

        if (result == 0)
            return false;

        return true;
    }
}
