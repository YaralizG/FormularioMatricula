using Microsoft.AspNetCore.Mvc;
using FormularioMatricula.Models;
using FormularioMatricula.Data;

namespace FormularioMatricula.Controllers
{
    public class EstudiantesController: Controller
    {
        private readonly AplicationDbContext _context;

        public EstudiantesController(AplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar(Estudiantes objEstudiantes)
        {
            _context.Add(objEstudiantes);
            _context.SaveChanges();
            ViewData["Message"] = "Estudiante registrado";
            return View("Index");
        }
        

        
    }
}