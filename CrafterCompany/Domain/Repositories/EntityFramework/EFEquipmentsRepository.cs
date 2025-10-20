using CrafterCompany.Domain.Entities;
using CrafterCompany.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CrafterCompany.Domain.Repositories.EntityFramework
{
    public class EFEquipmentsRepository:IEquipmentsRepository
    {
        private readonly AppDbContext _context;

        public EFEquipmentsRepository(AppDbContext context)
        {
            _context = context;
        }
        //Services
        public async Task<IEnumerable<Equipment>> GetEquipmentsAsync()
        {
            return await _context.Equipments.Include(x => x.Service).ToListAsync();

        }

        public async Task<Equipment?> GetEquipmentByIdAsync(int id)
        {
            return await _context.Equipments.Include(x => x.Service).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveEquipmentAsync(Equipment entity)
        {
            _context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEquipmentAsync(int id)
        {
            _context.Entry(new Equipment() { Id = id }).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
