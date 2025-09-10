using Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string Dni { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public DateTime? FechaNacimiento { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public EstadoAlumnoEnum EstadoAlumno { get; set; } = EstadoAlumnoEnum.Activo;

        // Relaciones
        public ICollection<Huella> Huellas { get; set; } = new List<Huella>();
        public ICollection<Acceso> Accesos { get; set; } = new List<Acceso>();
    }
}
