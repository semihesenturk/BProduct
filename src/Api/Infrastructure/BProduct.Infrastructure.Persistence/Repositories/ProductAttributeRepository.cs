using BProduct.Application.Interfaces.Repositories;
using BProduct.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BProduct.Infrastructure.Persistence.Repositories
{
    public class ProductAttributeRepository : GenericRepository<ProductAttribute>, IProductAttributeRepository
    {
        public ProductAttributeRepository(DbContext bproductContext) : base(bproductContext)
        {
        }
    }
}
