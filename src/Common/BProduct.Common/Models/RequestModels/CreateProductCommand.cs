using MediatR;

namespace BProduct.Common.Models.RequestModels;

public class CreateProductCommand : IRequest<Guid>
{
    public int ProductCatalogId { get; set; }
    public CreateProductAttributeCommand ProductAttributes { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    #region Constructor
    public CreateProductCommand(int productCatalogId, CreateProductAttributeCommand productAttributes, string name, decimal price)
    {
        ProductCatalogId = productCatalogId;
        ProductAttributes = productAttributes;
        Name = name;
        Price = price;
    }
    #endregion
}
