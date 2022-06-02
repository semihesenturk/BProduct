using MediatR;

namespace BProduct.Common.Models.RequestModels
{
    public class CreateCategoryCommand : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
