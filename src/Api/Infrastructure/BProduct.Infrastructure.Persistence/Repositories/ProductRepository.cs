using BProduct.Application.Interfaces.Repositories;
using BProduct.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BProduct.Infrastructure.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    #region Constructor
    public ProductRepository(DbContext bproductContext) : base(bproductContext)
    {
    } 
    #endregion
}
