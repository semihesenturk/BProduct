using MediatR;

namespace BProduct.Common.Models.RequestModels;

public class DeleteCategoryCommand : IRequest<bool>
{
    public Guid Id { get; set; }

    public DeleteCategoryCommand(Guid id)
    {
        Id = id;
    }
}
