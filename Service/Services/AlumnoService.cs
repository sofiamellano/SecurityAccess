using Backend.DataContext;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using Service.Models;

namespace Service.Services
{
    public class AlumnoService : IAlumnoService
    {
        public Task<Alumno> CreateAsync(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Alumno>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Alumno?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Alumno?> UpdateAsync(Alumno alumno)
        {
            throw new NotImplementedException();
        }
    }
}