using BProduct.Application.Interfaces.Repositories;
using BProduct.Domain.Models;
using BProduct.Infrastructure.Persistence.Context;

namespace BProduct.Infrastructure.Persistence.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    #region Constructor
    public CategoryRepository(BProductContext bproductContext) : base(bproductContext)
    {
    } 
    #endregion
}
