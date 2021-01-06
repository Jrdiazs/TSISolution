using System;

namespace TSI.WebTest.Models
{
    public class Articulos
    {
        public int ArticuloId { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int TipoArticulo { get; set; }

        public decimal ValorUnidad { get; set; }

        public DateTime? FechaEvento { get; set; }

        public bool Activo { get; set; }
    }

    public enum TipoArticulo
    {
        Boletas = 1,
        TourGuiado = 2,
        ElemetosDeportivos = 3,
    }
}