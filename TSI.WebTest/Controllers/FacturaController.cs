using System;
using System.Linq;
using System.Web.Http;
using TSI.WebTest.Models;

namespace TSI.WebTest.Controllers
{
    [RoutePrefix("api/Factura")]
    public class FacturaController : ApiController
    {
        [HttpPost]
        [Route("InsertarFactura")]
        public IHttpActionResult InsertarFactura(Factura factura)
        {
            try
            {
                factura.FechaCompra = DateTime.Now;

                foreach (var itemFactura in factura.FacturaItems)
                    itemFactura.EstadoFacturaItem = (int)EstadoFacturaItem.Realizado;
                

                factura.TotalCompra = factura.FacturaItems.Sum(x => x.Articulo.ValorUnidad * x.Cantidad);
                return Ok(factura);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("CancelarTour")]
        public IHttpActionResult CancelarTour(FacturaItem itemFactura)
        {
            try
            {
                Factura factura = new Factura();
                itemFactura.EstadoFacturaItem = (int)EstadoFacturaItem.Cancelado;
                
                return Ok(itemFactura);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}