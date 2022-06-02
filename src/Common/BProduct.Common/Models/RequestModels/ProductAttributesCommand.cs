namespace BProduct.Common.Models.RequestModels;

public class ProductAttributesCommand
{
    public ProductAttributesCommand()
    {
        Variables = new List<AttributeKVCommand>();
    }
    public List<AttributeKVCommand> Variables { get; set; }
}
