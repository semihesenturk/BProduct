namespace BProduct.Domain.Models;

public abstract class BaseEntity
{
    public Guid Id { get; set; }

    public DateTime CreateDate { get; set; }

    public bool? IsDeleted { get; set; }
}
