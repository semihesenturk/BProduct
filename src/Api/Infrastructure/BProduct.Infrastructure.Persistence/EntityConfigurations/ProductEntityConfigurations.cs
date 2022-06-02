using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BProduct.Infrastructure.Persistence.EntityConfigurations;

public class ProductEntityConfigurations : BaseEntityConfiguration<Domain.Models.Product>
{
    public override void Configure(EntityTypeBuilder<Domain.Models.Product> builder)
    {
        base.Configure(builder);

        builder.ToTable("product", "bproduct");
    }
}
