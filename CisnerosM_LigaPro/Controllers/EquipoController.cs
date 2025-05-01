using Microsoft.AspNetCore.Mvc;
using CisnerosM_LigaPro.Repositories;

namespace CisnerosM_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        private readonly EquipoRepository _equipoRepository;

        // Constructor con inyección de dependencias
        public EquipoController(EquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        // Acción para listar todos los equipos
        public IActionResult Index()
        {

            var equipos = _equipoRepository.DevuelveListaEquipos();
            return View(equipos);
        }

        // Acción para mostrar los detalles de un equipo
        public IActionResult Detalles(int id)
        {
            var equipo = _equipoRepository.ObtenerEquipoPorId(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }

        // Acción para mostrar el formulario de edición
        public IActionResult Editar(int id)
        {
            var equipo = _equipoRepository.ObtenerEquipoPorId(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }

        // Acción para mostrar el formulario de eliminación
        public IActionResult Eliminar(int id)
        {
            var equipo = _equipoRepository.ObtenerEquipoPorId(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }
    }
}