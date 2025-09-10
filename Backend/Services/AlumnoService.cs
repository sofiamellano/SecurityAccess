using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.DataContext;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using Service.Models;

namespace Service.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly RegistroAccesoContext _context;
        public AlumnoService(RegistroAccesoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Alumno>> GetAllAsync()
        {
            return await _context.Alumnos.ToListAsync();
        }
        public async Task<Alumno?> GetByIdAsync(int id)
        {
            return await _context.Alumnos.FirstOrDefaultAsync(a => a.IdAlumno == id);
        }
        public async Task<Alumno> CreateAsync(Alumno alumno)
        {
            _context.Alumnos.Add(alumno);
            await _context.SaveChangesAsync();
            return alumno;
        }
        public async Task<Alumno?> UpdateAsync(Alumno alumno)
        {
            var existing = await _context.Alumnos.FindAsync(alumno.IdAlumno);
            if (existing == null) return null;
            _context.Entry(existing).CurrentValues.SetValues(alumno);
            await _context.SaveChangesAsync();
            return existing;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var alumno = await _context.Alumnos.FindAsync(id);
            if (alumno == null) return false;
            _context.Alumnos.Remove(alumno);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}