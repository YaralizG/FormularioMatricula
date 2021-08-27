using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormularioMatricula.Models
{

    [Table("t_alumno")]

    public class Estudiantes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        [Column("id")]
        public int id{get;set;}

        [Column("apellidos")]
        public string apellido{get;set;}

        [Column("nombres")]
        public string nombre{get;set;}

        [Column("fechanacimiento")]
        public DateTime fechanacimiento{get;set;}
        
        [Column("dni")]
        public string dni{get;set;}

        [Column("genero")]
        public string genero{get;set;}

        [Column("carrera")]
        public string carrera{get;set;}
        
    }
}
