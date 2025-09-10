using Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IAccesoService
    {
        Task<IEnumerable<Acceso>> GetAllAsync();
        Task<Acceso?> GetByIdAsync(int id);
        Task<Acceso> CreateAsync(Acceso acceso);
        Task<Acceso?> UpdateAsync(Acceso acceso);
        Task<bool> DeleteAsync(int id);
    }
}