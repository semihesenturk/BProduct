using BProduct.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BProduct.Infrastructure.Persistence.EntityConfigurations;

public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.CreateDate).ValueGeneratedOnAdd();
        builder.Property(x => x.IsDeleted).ValueGeneratedOnAdd();
    }
}
