using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BProduct.Infrastructure.Persistence.EntityConfigurations;

public class AttributeEntityConfigurations : BaseEntityConfiguration<Domain.Models.Attribute>
{
    public override void Configure(EntityTypeBuilder<Domain.Models.Attribute> builder)
    {
        base.Configure(builder);

        builder.ToTable("attribute", "bproduct");
    }
}