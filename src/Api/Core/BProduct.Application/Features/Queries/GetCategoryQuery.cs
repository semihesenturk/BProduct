using BProduct.Common.Models.Queries;
using MediatR;

namespace BProduct.Application.Features.Queries;

public class GetCategoryQuery : IRequest<GetCategoryViewModel>
{
    public Guid Id { get; set; }
}
