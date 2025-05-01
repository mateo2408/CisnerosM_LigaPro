using Microsoft.AspNetCore.Mvc;
using CisnerosM_LigaPro.Data;

namespace CisnerosM_LigaPro.Controllers
{
    public class JugadorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JugadorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult ListarJugadores(int equipoId)
        {
            var jugadores = _context.Jugadores.Where(j => j.EquipoId == equipoId).ToList();
            return View(jugadores);
        }
    }
}