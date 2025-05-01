using Microsoft.EntityFrameworkCore;
using CisnerosM_LigaPro.Models;

namespace CisnerosM_LigaPro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
    }
}