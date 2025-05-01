using Microsoft.AspNetCore.Mvc;
using CisnerosM_LigaPro.Repositories;

namespace CisnerosM_LigaPro.Controllers
{
    public class TablaPosicionesController : Controller
    {
        private readonly EquipoRepository _equipoRepository;

        public TablaPosicionesController(EquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        public IActionResult TablaPosiciones()
        {
            var equipos = _equipoRepository.GetEquipos();
            return View(equipos);
        }
    }
}