using BProduct.Common.Models.Queries;
using MediatR;

namespace BProduct.Application.Features.Queries;

public class GetProductQuery : IRequest<GetProductViewModel>
{
    public Guid Id { get; set; }

    public GetProductQuery(Guid id)
    {
        Id = id;
    }
}
