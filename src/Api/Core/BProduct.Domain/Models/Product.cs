namespace BProduct.Domain.Models;

public class Product : BaseEntity
{
    public int ProductCatalogId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public virtual ICollection<ProductAttribute> Attributes { get; set; }
    public virtual ICollection<Category> Category { get; set; }
}
