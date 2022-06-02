namespace BProduct.Application.Interfaces.Repositories;

public interface ICategoryAttributeRepository : IGenericRepository<Domain.Models.CategoryAttribute>
{
    Task<List<Domain.Models.CategoryAttribute>> GetAttributesByCategory(Guid categoryId);
}
