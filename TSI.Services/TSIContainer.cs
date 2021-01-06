using Ninject.Modules;
using TSI.Data;

namespace TSI.Services
{
    public class TSIContainer : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IDataConnections)).To(typeof(DataConnections));

            Bind(typeof(IEmpleadoData)).To(typeof(EmpleadoData));
            Bind(typeof(ITipoIdentificacionData)).To(typeof(TipoIdentificacionData));

            Bind(typeof(IEmpleadoServices)).To(typeof(EmpleadoServices));
        }
    }
}