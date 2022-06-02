namespace BProduct.Domain.Models;

public class ProductAttribute : BaseEntity
{
    public Guid ProductId { get; set; }
    public Product Product { get; set; }

    public Guid AttributeId { get; set; }
    public Attribute Attribute { get; set; }

    public string Value { get; set; }
}
