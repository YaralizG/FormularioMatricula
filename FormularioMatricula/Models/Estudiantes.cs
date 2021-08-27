using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormularioMatricula.Models
{
    public class Estudiantes
    {
        public string apellido{get;set;}
        public string nombre{get;set;}
        public DateTime fechanacimiento{get;set;}
        public string dni{get;set;}
        public string genero{get;set;}
        public string carrera{get;set;}
        
    }
}
