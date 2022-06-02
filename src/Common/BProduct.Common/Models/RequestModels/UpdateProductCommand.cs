using MediatR;

namespace BProduct.Common.Models.RequestModels;

public class UpdateProductCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public int ProductCatalogId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
