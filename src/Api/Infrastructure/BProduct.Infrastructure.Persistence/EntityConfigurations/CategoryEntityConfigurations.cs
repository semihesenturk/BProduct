using BProduct.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BProduct.Infrastructure.Persistence.EntityConfigurations;

public class CategoryEntityConfigurations : BaseEntityConfiguration<Category>
{
    public override void Configure(EntityTypeBuilder<Category> builder)
    {
        base.Configure(builder);

        builder.ToTable("category", "bproduct");
    }
}
