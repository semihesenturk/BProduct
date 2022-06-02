using MediatR;

namespace BProduct.Common.Models.RequestModels
{
    public class CreateCategoryAttributeCommand : IRequest<Guid>
    {
        public Guid CategoryId { get; set; }

        public Guid AttributeId { get; set; }
    }
}
