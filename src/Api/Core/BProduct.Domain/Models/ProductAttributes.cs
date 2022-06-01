namespace BProduct.Domain.Models;

public class ProductAttributes
{
    #region Constructor
    public ProductAttributes()
    {
        Variables = new List<AttributeKV>();
    } 
    #endregion

    public List<AttributeKV> Variables { get; set; }
}
