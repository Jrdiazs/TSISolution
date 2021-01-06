using System;
using System.Collections.Generic;
using System.Linq;
using TSI.Data;
using TSI.Services.EmpleadoModel;
using TSI.Services.ModelRequest;
using TSI.Services.ModelResponse;

namespace TSI.Services
{
    public class EmpleadoServices : IEmpleadoServices, IDisposable
    {
        private readonly IEmpleadoData _data;
        private readonly ITipoIdentificacionData _tipoIdentificacion;
        private bool disposedValue;

        public EmpleadoServices(IEmpleadoData data, ITipoIdentificacionData tipoIdentificacion)
        {
            _data = data;
            _tipoIdentificacion = tipoIdentificacion;
        }

        public EmpleadoResponse ConsultarEmpleadoPorId(int empleadoId)
        {
            try
            {
                var empleados = _data.ConsultarEmpleados(id: empleadoId);
                if (empleados.Any()) return empleados.FirstOrDefault().EmpleadoConvertResponse();

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<EmpleadoResponse> ConsultarEmpleadosAll()
        {
            try
            {
                var empleados = _data.ConsultarEmpleados(null);

                var empleadosResponse = empleados.Select(x => new EmpleadoResponse()
                {
                    Apellidos = x.Apellidos,
                    Ciudad = x.Ciudad,
                    Direccion = x.Direccion,
                    EmpleadoId = x.EmpleadoId,
                    Genero = x.Genero,
                    Nombres = x.Nombres,
                    TipoIdentificacion = x.TipoIdentificacion.Nombre,
                    TipoIdentificacionId = x.TipoIdentificacionId,
                    NumeroDocumento = x.NumeroDocumento
                });

                return empleadosResponse ?? new List<EmpleadoResponse>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TipoIdentificacionResponse> ConsultarTiposIdentificacion()
        {
            try
            {
                var query = _tipoIdentificacion.GetModelList();

                var tiposIdentificacion = query.Select(x => new TipoIdentificacionResponse()
                {
                    Alias = x.Alias,
                    Nombre = x.Nombre,
                    TipoIdentificacionId = x.TipoIdentificacionId
                });
                return tiposIdentificacion ?? new List<TipoIdentificacionResponse>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EmpleadoResponse GuardarEmpleado(EmpleadoRequest empleado)
        {
            try
            {
                var empleadoData = empleado.EmpleadoConvertData();
                int id = _data.InsertGetKey<int>(empleadoData);

                empleadoData.EmpleadoId = id;

                var empleadoResponse = empleadoData.EmpleadoConvertResponse();
                return empleadoResponse;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EmpleadoResponse ModificarEmpleado(EmpleadoRequest empleado)
        {
            try
            {
                var empleadoData = empleado.EmpleadoConvertData();
                var oldEmpleado = _data.GetFindById(empleado.EmpleadoId);

                if (oldEmpleado == null) throw new Exception($"No existe el empleado por id {empleado.EmpleadoId}");

                oldEmpleado.Apellidos = empleadoData.Apellidos;
                oldEmpleado.Ciudad = empleadoData.Ciudad;
                oldEmpleado.Direccion = empleadoData.Direccion;
                oldEmpleado.Genero = empleadoData.Genero;
                oldEmpleado.Nombres = empleadoData.Nombres;
                oldEmpleado.NumeroDocumento = empleadoData.NumeroDocumento;
                oldEmpleado.TipoIdentificacionId = empleadoData.TipoIdentificacionId;

                _data.Update(oldEmpleado);

                var empleadoResponse = oldEmpleado.EmpleadoConvertResponse();
                return empleadoResponse;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region [Dispose]

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                    if (_tipoIdentificacion != null)
                        _tipoIdentificacion.Dispose();

                    if (_data != null)
                        _data.Dispose();
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~EmpleadoServices()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion [Dispose]
    }

    public interface IEmpleadoServices : IDisposable
    {
        IEnumerable<EmpleadoResponse> ConsultarEmpleadosAll();

        EmpleadoResponse GuardarEmpleado(EmpleadoRequest empleado);

        IEnumerable<TipoIdentificacionResponse> ConsultarTiposIdentificacion();

        EmpleadoResponse ModificarEmpleado(EmpleadoRequest empleado);

        EmpleadoResponse ConsultarEmpleadoPorId(int empleadoId);
    }
}