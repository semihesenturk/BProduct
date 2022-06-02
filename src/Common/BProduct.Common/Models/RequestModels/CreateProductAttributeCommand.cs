using MediatR;

namespace BProduct.Common.Models.RequestModels;

public class CreateProductAttributeCommand : IRequest<Guid>
{
    public Guid ProductId { get; set; }

    public Guid AttributeId { get; set; }

    public string Value { get; set; }
}
