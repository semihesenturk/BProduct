using BProduct.Application.Interfaces.Repositories;
using BProduct.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BProduct.Infrastructure.Persistence.Repositories;

public class AttributeRepository : GenericRepository<Domain.Models.Attribute>, IAttributeRepository
{
    public AttributeRepository(BProductContext bproductContext) : base(bproductContext)
    {
    }
}
