namespace BProduct.Domain.Models;

public class Attribute : BaseEntity
{
    public string Name { get; set; }

    public ICollection<Product> Products { get; set; }
    public ICollection<Category> Categories { get; set; }
}
