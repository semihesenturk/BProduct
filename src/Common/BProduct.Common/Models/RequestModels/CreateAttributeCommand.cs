using MediatR;

namespace BProduct.Common.Models.RequestModels;

public class CreateAttributeCommand : IRequest<Guid>
{
    public string Name { get; set; }
}
