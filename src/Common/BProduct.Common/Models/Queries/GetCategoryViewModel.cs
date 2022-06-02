namespace BProduct.Common.Models.Queries;

public class GetCategoryViewModel
{
    public string Name { get; set; }

    public ICollection<GetCategoryAttributesViewModel> Attributes { get; set; }
}
