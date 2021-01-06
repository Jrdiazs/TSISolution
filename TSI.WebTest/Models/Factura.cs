using System;
using System.Collections.Generic;

namespace TSI.WebTest.Models
{
    public class Factura
    {
        public int UsuarioId { get; set; }

        public int FacturaId { get; set; }

        public List<FacturaItem> FacturaItems { get; set; }

        public decimal TotalCompra { get; set; }

        public DateTime FechaCompra { get; set; }
    }

    public class FacturaItem
    {
        public int FacturaItemId { get; set; }

        public Articulos Articulo { get; set; }

        public int EstadoFacturaItem { get; set; }

        public int Cantidad { get; set; }

    }

    public enum EstadoFacturaItem
    {
        Realizado = 1,
        Cancelado = 2
    }
}