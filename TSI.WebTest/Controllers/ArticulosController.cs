using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TSI.WebTest.Models;

namespace TSI.WebTest.Controllers
{
    [RoutePrefix("api/Articulos")]
    public class ArticulosController : ApiController
    {
        [HttpGet]
        [Route("ListarArticulos")]
        public IHttpActionResult ListarArticulos()
        {
            try
            {
                var articulos = new List<Articulos>() {
                    new Articulos()
                    {
                        ArticuloId = 1,
                        Nombre = "Maleta Deportiva NIKE",
                        TipoArticulo = (int)TipoArticulo.ElemetosDeportivos,
                        ValorUnidad = 120000,
                        Activo = true
                    },
                    new Articulos()
                    {
                        ArticuloId = 2,
                        Nombre = "Tenis BASKETBALL ADIDAS",
                        TipoArticulo = (int)TipoArticulo.ElemetosDeportivos,
                        ValorUnidad = 220000,
                        Activo = true
                    },
                    new Articulos()
                    {
                        ArticuloId = 3,
                        Nombre = "Guayos NIKE",
                        TipoArticulo = (int)TipoArticulo.ElemetosDeportivos,
                        ValorUnidad = 550000,
                        Activo = false
                    },
                    new Articulos()
                    {
                        ArticuloId = 4,
                        Nombre = "Tour Guiado",
                        TipoArticulo = (int)TipoArticulo.TourGuiado,
                        ValorUnidad = 20000,
                        FechaEvento = new DateTime(2021,1,12,18,0,23),
                        Activo = true
                    },
                    new Articulos()
                    {
                        ArticuloId = 5,
                        Nombre = "Boletas Partido Nacional VS Patriotas",
                        TipoArticulo = (int)TipoArticulo.Boletas,
                        FechaEvento = new DateTime(2021,1,15,18,0,23),
                        ValorUnidad = 10000,
                        Activo = true
                    }
                };

                var articulosActivos = articulos.Where(x => x.Activo).ToList();

                return Ok(articulosActivos);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}