using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using TSI.Model;

namespace TSI.Data
{
    public class EmpleadoData : Repository<Empleado>, IDisposable, IEmpleadoData
    {
        public EmpleadoData() : base()
        {
        }

        public IEnumerable<Empleado> ConsultarEmpleados(int? id = null, IDbTransaction transaction = null)
        {
            try
            {
                var query = DataBase.Query<Empleado, TipoIdentificacion, Empleado>(
                    sql: "TSI_SP_EmpleadosConsultar",
                    map: (e, ti) => { e.TipoIdentificacion = ti; return e; }, transaction: transaction,
                    param: new { EmpleadoId = id }, splitOn: "split", commandType: CommandType.StoredProcedure);

                return query ?? new List<Empleado>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Empleado InsertarEmpleado(Empleado empleado, IDbTransaction transaction = null) 
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("EmpleadoId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                parameters.Add("TipoIdentificacionId", value: empleado.TipoIdentificacionId, direction: ParameterDirection.Input);
                parameters.Add("NumeroDocumento", value: empleado.NumeroDocumento, direction: ParameterDirection.Input);
                parameters.Add("Nombres", value: empleado.Nombres, direction: ParameterDirection.Input);
                parameters.Add("Apellidos", value: empleado.Apellidos, direction: ParameterDirection.Input);
                parameters.Add("Genero", value: empleado.Genero, direction: ParameterDirection.Input);
                parameters.Add("Ciudad", value: empleado.Ciudad, direction: ParameterDirection.Input);
                parameters.Add("Direccion", value: empleado.Direccion, direction: ParameterDirection.Input);
                parameters.Add("Telefono ", value: empleado.Telefono, direction: ParameterDirection.Input);

                var rowsAffected = DataBase.Execute("TSI_SP_EmpleadosInsertar",transaction: transaction, param: parameters, commandType: CommandType.StoredProcedure);

                empleado.EmpleadoId = parameters.Get<int>("EmpleadoId");

                return empleado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EliminarEmpleado(Empleado empleado, IDbTransaction transaction = null) 
        {
            try
            {
                var rowsAffected = ExecuteQuery("TSI_SP_EmpleadosEliminar", parameters: new { EmpleadoId = empleado.EmpleadoId }, transaction: transaction, typeCommand: CommandType.StoredProcedure);
                return rowsAffected;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Empleado ModificarEmpleado(Empleado empleado, IDbTransaction transaction = null)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("EmpleadoId", value: empleado.EmpleadoId, direction: ParameterDirection.Input);
                parameters.Add("TipoIdentificacionId", value: empleado.TipoIdentificacionId, direction: ParameterDirection.Input);
                parameters.Add("NumeroDocumento", value: empleado.NumeroDocumento, direction: ParameterDirection.Input);
                parameters.Add("Nombres", value: empleado.Nombres, direction: ParameterDirection.Input);
                parameters.Add("Apellidos", value: empleado.Apellidos, direction: ParameterDirection.Input);
                parameters.Add("Genero", value: empleado.Genero, direction: ParameterDirection.Input);
                parameters.Add("Ciudad", value: empleado.Ciudad, direction: ParameterDirection.Input);
                parameters.Add("Direccion", value: empleado.Direccion, direction: ParameterDirection.Input);
                parameters.Add("Telefono ", value: empleado.Telefono, direction: ParameterDirection.Input);

                var rowsAffected = DataBase.Execute("TSI_SP_EmpleadosModificar", transaction: transaction, param: parameters, commandType: CommandType.StoredProcedure);


                return empleado;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public interface IEmpleadoData : IRepository<Empleado>, IDisposable
    {
        IEnumerable<Empleado> ConsultarEmpleados(int? id = null, IDbTransaction transaction = null);

        Empleado InsertarEmpleado(Empleado empleado, IDbTransaction transaction = null);

        Empleado ModificarEmpleado(Empleado empleado, IDbTransaction transaction = null);

        int EliminarEmpleado(Empleado empleado, IDbTransaction transaction = null);
    }
}