using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_NBA
{
    public class Jugador
    {
        [Key]
        public int JugadorId { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public double PuntosporPartido { get; set; }
        public double AsistenciasporPartido { get; set; }
        public double RebotesporPartido { get; set; }
        public double BloqueosporPartido { get; set; }
        public double RobosporPartido { get; set; }

        [ForeignKey("EquipoId")]
        public int EquipoId { get; set; }
    }
}
