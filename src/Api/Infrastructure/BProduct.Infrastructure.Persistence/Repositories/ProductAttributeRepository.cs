using BProduct.Application.Interfaces.Repositories;
using BProduct.Domain.Models;
using BProduct.Infrastructure.Persistence.Context;

namespace BProduct.Infrastructure.Persistence.Repositories
{
    public class ProductAttributeRepository : GenericRepository<ProductAttribute>, IProductAttributeRepository
    {
        public ProductAttributeRepository(BProductContext bproductContext) : base(bproductContext)
        {
        }
    }
}
