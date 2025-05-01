using Microsoft.AspNetCore.Mvc;
using CisnerosM_LigaPro.Repositories;

namespace CisnerosM_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        private readonly EquipoRepository _equipoRepository;

        // Constructor with dependency injection
        public EquipoController(EquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        // Action to list all teams
        public IActionResult Index()
        {
            var equipos = _equipoRepository.GetEquipos();
            return View(equipos); // Pass the list of teams to the view
        }

        // Action to show team details
        public IActionResult Detalles(int id)
        {
            var equipo = _equipoRepository.GetEquipoById(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo); // Pass the team details to the view
        }

        // Action to show the edit form
        public IActionResult Editar(int id)
        {
            var equipo = _equipoRepository.GetEquipoById(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo); // Pass the team details to the view
        }

        // Action to show the delete confirmation
        public IActionResult Eliminar(int id)
        {
            var equipo = _equipoRepository.GetEquipoById(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo); // Pass the team details to the view
        }
    }
}