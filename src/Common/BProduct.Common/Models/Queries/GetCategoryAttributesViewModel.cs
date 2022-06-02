namespace BProduct.Common.Models.Queries;

public class GetCategoryAttributesViewModel
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }

    public Guid AttributeId { get; set; }
}
