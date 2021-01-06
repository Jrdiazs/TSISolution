namespace TSI.Services.ModelRequest
{
    public class EmpleadoRequest
    {
        public int EmpleadoId { get; set; }

        public int TipoIdentificacionId { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Genero { get; set; }

        public string Ciudad { get; set; }

        public string Direccion { get; set; }

        public string NumeroDocumento { get; set; }
    }
}