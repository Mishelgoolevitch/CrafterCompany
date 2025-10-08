using CrafterCompany.Domain.Entities;

namespace CrafterCompany.Domain.Repositories.Abstract
{
    public interface IEquipmentsRepository
    {
        Task<IEnumerable<Equipment>> GetServicesAsync();
        Task<Equipment?> GetServiceByIdAsync(int id);
        Task SaveServiceAsync(Equipment entity);
        Task DeleteServiceAsync(int id);
    }
}
