using BProduct.Application.Interfaces.Repositories;
using BProduct.Infrastructure.Persistence.Context;

namespace BProduct.Infrastructure.Persistence.Repositories;

public class CategoryAttributeRepository : GenericRepository<Domain.Models.CategoryAttribute>, ICategoryAttributeRepository
{
    public CategoryAttributeRepository(BProductContext bproductContext) : base(bproductContext)
    {
    }

    public async Task<List<Domain.Models.CategoryAttribute>> GetAttributesByCategory(Guid categoryId)
    {
        var result = await GetList(s => s.CategoryId == categoryId);

        return result;
    }
}
