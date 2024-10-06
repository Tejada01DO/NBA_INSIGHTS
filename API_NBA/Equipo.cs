using System.ComponentModel.DataAnnotations;

namespace API_NBA
{
    public class Equipo
    {
        [Key]
        public int EquipoId { get; set; }
        public string Nombre { get; set; }
        public string Conferencia { get; set; }
        public byte[] Imagen { get; set; }
    }
}
