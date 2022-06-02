using BProduct.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BProduct.Infrastructure.Persistence.Repositories;

public class AttributeRepository : GenericRepository<Domain.Models.Attribute>, IAttributeRepository
{
    public AttributeRepository(DbContext bproductContext) : base(bproductContext)
    {
    }
}
