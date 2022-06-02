using BProduct.Application.Interfaces.Repositories;
using BProduct.Domain.Models;
using BProduct.Infrastructure.Persistence.Context;

namespace BProduct.Infrastructure.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    #region Constructor
    public ProductRepository(BProductContext bproductContext) : base(bproductContext)
    {
    }
    #endregion
}
