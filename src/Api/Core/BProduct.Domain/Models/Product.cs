namespace BProduct.Domain.Models;

public class Product : BaseEntity
{
    public int ProductCatalogId { get; set; }
    public ProductAttributes ProductAttributes { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public virtual ICollection<Category> Categories { get; set; }
}
