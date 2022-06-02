﻿namespace BProduct.Domain.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }

    public virtual ICollection<CategoryAttribute> Attributes { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}
