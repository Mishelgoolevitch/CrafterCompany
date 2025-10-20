using CrafterCompany.Domain.Entities;

namespace CrafterCompany.Domain.Repositories.Abstract
{
    public interface IEquipmentsRepository
    {
        Task<IEnumerable<Equipment>> GetEquipmentsAsync();
        Task<Equipment?> GetEquipmentByIdAsync(int id);
        Task SaveEquipmentAsync(Equipment entity);
        Task DeleteEquipmentAsync(int id);
    }
}
