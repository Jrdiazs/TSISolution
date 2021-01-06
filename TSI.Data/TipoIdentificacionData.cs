using System;
using TSI.Model;

namespace TSI.Data
{
    public class TipoIdentificacionData : Repository<TipoIdentificacion>, ITipoIdentificacionData, IDisposable
    {
        public TipoIdentificacionData() : base()
        {
        }
    }

    public interface ITipoIdentificacionData : IRepository<TipoIdentificacion>, IDisposable { }
}