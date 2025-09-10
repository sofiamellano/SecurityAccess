using Backend.DataContext;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using Service.Models;

namespace Service.Services
{
    public class HuellaService : IHuellaService
    {
        public Task<Huella> CreateAsync(Huella huella)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Huella>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Huella?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Huella?> UpdateAsync(Huella huella)
        {
            throw new NotImplementedException();
        }
    }
}