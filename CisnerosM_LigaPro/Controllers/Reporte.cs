using Microsoft.AspNetCore.Mvc;
using CisnerosM_LigaPro.Data;
using System.Linq;
using CisnerosM_LigaPro.Models;

namespace CisnerosM_LigaPro.Controllers
{
    public class ReporteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReporteController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult GenerarReporte()
        {
            var goleadores = _context.Jugadores
                .OrderByDescending(j => j.Goles)
                .Take(5)
                .Select(j => new Goleador
                {
                    Nombre = j.Nombre,
                    Goles = j.Goles
                })
                .ToList();
        
            var asistentes = _context.Jugadores
                .OrderByDescending(j => j.Asistencias)
                .Take(5)
                .Select(j => new Asistente
                {
                    Nombre = j.Nombre,
                    Asistencias = j.Asistencias
                })
                .ToList();
        
            var equiposPresupuesto = _context.Equipos
                .Select(e => new EquipoPresupuesto
                {
                    Nombre = e.Nombre,
                    Presupuesto = e.Jugadores.Sum(j => j.Sueldo)
                })
                .OrderByDescending(e => e.Presupuesto)
                .Take(5)
                .ToList();
        
            return View(new ReporteViewModel
            {
                Goleadores = goleadores,
                Asistentes = asistentes,
                EquiposPresupuesto = equiposPresupuesto
            });
        }
    }
}