using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TSI.Model
{
    [Table("TipoIdentificacion")]
    public class TipoIdentificacion
    {
        [Key]
        [Column("TipoIdentificacionId")]
        public int TipoIdentificacionId { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Alias")]
        public string Alias { get; set; }
    }
}