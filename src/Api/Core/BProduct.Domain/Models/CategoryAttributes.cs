namespace BProduct.Domain.Models;

public class CategoryAttributes
{
    #region Constructor
    public CategoryAttributes()
    {
        Variables = new List<AttributeKV>();
    } 
    #endregion

    public List<AttributeKV> Variables { get; set; }
}
