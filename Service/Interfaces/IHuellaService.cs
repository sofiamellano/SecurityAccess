using Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IHuellaService
    {
        Task<IEnumerable<Huella>> GetAllAsync();
        Task<Huella?> GetByIdAsync(int id);
        Task<Huella> CreateAsync(Huella huella);
        Task<Huella?> UpdateAsync(Huella huella);
        Task<bool> DeleteAsync(int id);
    }
}