namespace TSI.WebTest.Models
{
    public class Usuario
    {
        public int UserId { get; set; }

        public int TipoIdentificacionId { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string CorreoElectronico { get; set; }
    }

    public enum TipoIdentificacion
    {
        CEDULA_CIUDADANIA = 1,
        NIT = 2,
        RUT = 3,
        PASAPORTE = 4,
        CÉDULA_EXTRANJERA = 5,
        TARJETA_IDENTIDAD = 6,
        REGISTRO_CIVIL = 7
    }
}