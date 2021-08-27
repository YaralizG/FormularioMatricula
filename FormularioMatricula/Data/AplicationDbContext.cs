using  System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FormularioMatricula.Data
{
    public class AplicationDbContext:IdentityDbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
        public DbSet<FormularioMatricula.Models.Estudiantes> DataEstudiantes {get; set;}

    }
}