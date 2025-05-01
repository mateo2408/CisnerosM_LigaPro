using Microsoft.AspNetCore.Mvc;
using CisnerosM_LigaPro.Repositories;
using CisnerosM_LigaPro.Models;

namespace CisnerosM_LigaPro.Controllers
{
    public class DetallesController : Controller
    {
        private readonly EquipoRepository _equipoRepository;

        public DetallesController(EquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var equipo = _equipoRepository.GetEquipoById(id);
            if (equipo == null) return NotFound();
            return View(equipo);
        }

        [HttpPost]
        public IActionResult Editar(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _equipoRepository.UpdateEquipo(equipo);
                return RedirectToAction("TablaPosiciones", "TablaPosiciones");
            }
            return View(equipo);
        }
    }
}