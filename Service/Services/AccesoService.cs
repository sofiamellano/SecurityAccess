using Service.Interfaces;
using Service.Models;

namespace Service.Services
{
    public class AccesoService : IAccesoService
    {
        public Task<Acceso> CreateAsync(Acceso acceso)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Acceso>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Acceso?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Acceso?> UpdateAsync(Acceso acceso)
        {
            throw new NotImplementedException();
        }
    }
}