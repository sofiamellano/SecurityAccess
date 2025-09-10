using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Class
{
    public static class ApiEndpoints
    {
        public static string Alumno { get; set; } = "alumnos";


        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Alumno) => Alumno,
                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
