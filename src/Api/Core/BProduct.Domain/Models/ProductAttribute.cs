namespace BProduct.Domain.Models;

public class ProductAttribute : BaseEntity
{
    public Guid ProductId { get; set; }
    public Product Product { get; set; }

    public string Value { get; set; }
}
