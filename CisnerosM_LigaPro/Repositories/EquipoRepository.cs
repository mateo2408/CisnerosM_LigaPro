using CisnerosM_LigaPro;
using CisnerosM_LigaPro.Data;
using Microsoft.EntityFrameworkCore;

namespace CisnerosM_LigaPro.Repositories
{
    public class EquipoRepository
    {
        private readonly ApplicationDbContext _context;

        public EquipoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Equipo> GetEquipos() => _context.Equipos.ToList();

        public Equipo GetEquipoById(int id) =>
            _context.Equipos.FirstOrDefault(e => e.Id == id);

        public void UpdateEquipo(Equipo equipo)
        {
            _context.Equipos.Update(equipo);
            _context.SaveChanges();
        }
    }
}