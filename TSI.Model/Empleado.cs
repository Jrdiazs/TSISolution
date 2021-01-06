using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TSI.Model
{
    [Table("Empleado")]
    public class Empleado
    {
        [Key]
        [Column("EmpleadoId")]
        public int EmpleadoId { get; set; }

        [Column("TipoIdentificacionId")]
        public int TipoIdentificacionId { get; set; }

        [Column("Nombres")]
        public string Nombres { get; set; }

        [Column("Apellidos")]
        public string Apellidos { get; set; }

        [Column("Genero")]
        public string Genero { get; set; }

        [Column("Ciudad")]
        public string Ciudad { get; set; }

        [Column("Direccion")]
        public string Direccion { get; set; }

        [Column("NumeroDocumento")]
        public string NumeroDocumento { get; set; }

        [Column("Telefono")]
        public string Telefono { get; set; }

        [NotMapped]
        public TipoIdentificacion TipoIdentificacion { get; set; }
    }
}