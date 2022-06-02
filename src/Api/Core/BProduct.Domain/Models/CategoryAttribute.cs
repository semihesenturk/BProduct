namespace BProduct.Domain.Models;

public class CategoryAttribute :BaseEntity
{
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

}
