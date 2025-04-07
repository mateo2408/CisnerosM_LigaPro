using System.ComponentModel.DataAnnotations;

namespace CisnerosM_LigaPro
{
    public class Equipo
    {
        [Key]
        public int Id {get; set;}
        [Required]
        [MaxLength(100)]
        
        public string Nombre {get; set;}
        public int PartidosJugados {get; set;}
        public int PartidosGanados {get; set;}
        public int PartidosEmpatados {get; set;}
        public int PartidosPerdidos {get; set;}

    }
}