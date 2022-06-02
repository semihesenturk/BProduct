using BProduct.Common.Models.Queries;
using MediatR;

namespace BProduct.Application.Features.Queries;

public class GetCategoryAttributesQuery : IRequest<List<GetCategoryAttributesViewModel>>
{
    public Guid CategoryId { get; set; }

    public GetCategoryAttributesQuery(Guid categoryId)
    {
        CategoryId = categoryId;
    }
}
