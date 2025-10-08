using CrafterCompany.Domain.Entities;

namespace CrafterCompany.Domain.Repositories.Abstract
{
    public interface IServiceCategoriesRepository
    {
        Task<IEnumerable<ServiceCategory>> GetServiceCategoriesAsync();
        Task<ServiceCategory?> GetServiceCategoryByIdAsync(int id);
        Task SaveServiceCategoryAsync(ServiceCategory entity);
        Task DeleteServiceCategoryAsync(int id);

    }
}
