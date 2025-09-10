using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Models;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnosController : ControllerBase
    {
        private readonly IAlumnoService _service;
        public AlumnosController(IAlumnoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var alumno = await _service.GetByIdAsync(id);
            if (alumno == null) return NotFound();
            return Ok(alumno);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Alumno alumno)
        {
            var created = await _service.CreateAsync(alumno);
            return CreatedAtAction(nameof(GetById), new { id = created.IdAlumno }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Alumno alumno)
        {
            if (id != alumno.IdAlumno) return BadRequest();
            var updated = await _service.UpdateAsync(alumno);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}