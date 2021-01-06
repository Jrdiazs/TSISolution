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
    }

    public interface IEmpleadoData : IRepository<Empleado>, IDisposable
    {
        IEnumerable<Empleado> ConsultarEmpleados(int? id = null, IDbTransaction transaction = null);
    }
}