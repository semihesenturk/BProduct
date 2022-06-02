using MediatR;

namespace BProduct.Common.Models.RequestModels
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public int ProductCatalogId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
