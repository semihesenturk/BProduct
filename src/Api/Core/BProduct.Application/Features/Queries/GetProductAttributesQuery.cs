using BProduct.Common.Models.Queries;
using MediatR;

namespace BProduct.Application.Features.Queries;

public class GetProductAttributesQuery : IRequest<List<GetProductAttributesViewModel>>
{
    public Guid ProductId { get; set; }
    public GetProductAttributesQuery(Guid productId)
    {
        ProductId = productId;
    }
    public GetProductAttributesQuery()
    {

    }
}
