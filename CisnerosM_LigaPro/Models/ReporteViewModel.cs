namespace CisnerosM_LigaPro.Models
{
    public class ReporteViewModel
    {
            public List<Goleador> Goleadores { get; set; } = new();
            public List<Asistente> Asistentes { get; set; } = new();
            public List<EquipoPresupuesto> EquiposPresupuesto { get; set; } = new();
    }

    public class Goleador
    {
        public string Nombre { get; set; }
        public int Goles { get; set; }
    }

    public class Asistente
    {
        public string Nombre { get; set; }
        public int Asistencias { get; set; }
    }

    public class EquipoPresupuesto
    {
        public string Nombre { get; set; }
        public decimal Presupuesto { get; set; }
    }
}