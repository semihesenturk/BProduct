using BProduct.Application.Interfaces.Repositories;
using BProduct.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BProduct.Infrastructure.Persistence.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    #region Constructor
    public CategoryRepository(DbContext bproductContext) : base(bproductContext)
    {
    } 
    #endregion
}
