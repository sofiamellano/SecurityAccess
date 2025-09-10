using Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Huella
    {
        public int IdHuella { get; set; }
        public int IdAlumno { get; set; }
        public byte[] TemplateHuella { get; set; } = null!; // huella encriptada
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public EstadoHuellaEnum EstadoHuella { get; set; } = EstadoHuellaEnum.Activo;

        // Relación
        public Alumno Alumno { get; set; } = null!;
    }
}
