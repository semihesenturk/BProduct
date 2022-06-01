namespace BProduct.Domain.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public CategoryAttributes CategoryAttributes { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}
