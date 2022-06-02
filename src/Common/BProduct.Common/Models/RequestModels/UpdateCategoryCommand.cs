using MediatR;

namespace BProduct.Common.Models.RequestModels;

public class UpdateCategoryCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
