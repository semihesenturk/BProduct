namespace BProduct.Domain.Models;

public class CategoryAttribute :BaseEntity
{
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public Guid AttributeId { get; set; }
    public Attribute Attribute { get; set; }

}
