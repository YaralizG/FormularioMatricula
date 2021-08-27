using Microsoft.AspNetCore.Mvc;
using FormularioMatricula.Models;
using FormularioMatricula.Data;

namespace FormularioMatricula.Controllers
{
    public class EstudiantesController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}