using System;
using System.Collections.Generic;
using System.Web.Http;
using TSI.WebTest.Models;

namespace TSI.WebTest.Controllers
{
    [RoutePrefix("api/Usuarios")]
    public class UsuariosController : ApiController
    {
        [HttpGet]
        [Route("ListarUsuarios")]
        public IHttpActionResult ListarUsuarios()
        {
            try
            {
                var usuarios = new List<Usuario>() {
                    new Usuario()
                    {
                        UserId = 1,
                        Nombres = "Juan Ricardo",
                        Apellidos ="Diaz Suancha",
                        CorreoElectronico = "juanricardo200@hotmail.com",
                        TipoIdentificacionId =(int) TipoIdentificacion.CEDULA_CIUDADANIA
                    },
                    new Usuario()
                    {
                        UserId = 2,
                        Nombres = "Andres Eduardo",
                        Apellidos ="Alavarez",
                        CorreoElectronico = "andres.alvarez@hotmail.com",
                        TipoIdentificacionId = (int) TipoIdentificacion.CEDULA_CIUDADANIA
                    },
                };

                return Ok(usuarios);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}