using Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Acceso
    {
        public int IdAcceso { get; set; }
        public int IdAlumno { get; set; }
        public DateTime FechaHora { get; set; } = DateTime.Now;
        public TipoAccesoEnum TipoAcceso { get; set; } = TipoAccesoEnum.Entrada;

        public ResultadoAccesoEnum ResultadoAcceso { get; set; } = ResultadoAccesoEnum.Permitido;
        public string? Ubicacion { get; set; }

        // Relación
        public Alumno Alumno { get; set; } = null!;
    }
}
