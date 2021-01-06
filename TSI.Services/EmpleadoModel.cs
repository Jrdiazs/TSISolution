using TSI.Model;
using TSI.Services.ModelRequest;
using TSI.Services.ModelResponse;

namespace TSI.Services.EmpleadoModel
{
    public static class EmpleadoModel
    {
        public static Empleado EmpleadoConvertData(this EmpleadoRequest empleado)
        {
            return new Empleado()
            {
                EmpleadoId = empleado.EmpleadoId,
                Apellidos = empleado.Apellidos,
                Ciudad = empleado.Ciudad,
                Direccion = empleado.Direccion,
                Genero = empleado.Genero,
                Nombres = empleado.Nombres,
                NumeroDocumento = empleado.NumeroDocumento,
                TipoIdentificacionId = empleado.TipoIdentificacionId
            };
        }

        public static EmpleadoResponse EmpleadoConvertResponse(this Empleado empleado)
        {
            return new EmpleadoResponse()
            {
                EmpleadoId = empleado.EmpleadoId,
                Apellidos = empleado.Apellidos,
                Ciudad = empleado.Ciudad,
                Direccion = empleado.Direccion,
                Genero = empleado.Genero,
                Nombres = empleado.Nombres,
                NumeroDocumento = empleado.NumeroDocumento,
                TipoIdentificacionId = empleado.TipoIdentificacionId
            };
        }
    }
}