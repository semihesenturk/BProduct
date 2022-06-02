namespace BProduct.Common.Models.Queries;

public class GetProductViewModel
{
    public Guid Id { get; set; }
    public int ProductCatalogId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
