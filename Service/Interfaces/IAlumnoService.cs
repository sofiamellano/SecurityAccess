using Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IAlumnoService
    {
        Task<IEnumerable<Alumno>> GetAllAsync();
        Task<Alumno?> GetByIdAsync(int id);
        Task<Alumno> CreateAsync(Alumno alumno);
        Task<Alumno?> UpdateAsync(Alumno alumno);
        Task<bool> DeleteAsync(int id);
    }
}