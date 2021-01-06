using System;
using System.Linq;
using System.Windows.Forms;
using TSI.AppWindows.Modal.Info;
using TSI.Services;

namespace TSI.AppWindows
{
    public partial class FRMEmpleadoBuscar : Form
    {
        private readonly IEmpleadoServices _services;

        public int EmpleadoSeleccionado { get; set; }

        public FRMEmpleadoBuscar(IEmpleadoServices services)
        {
            _services = services;
            InitializeComponent();
        }

        public event EventHandler SelectEmpleadoEvent;

        protected virtual void OnSelectEmpleadoEvent(EventArgs e)
        {
            var handler = SelectEmpleadoEvent;
            if (handler != null)
                handler(this, e);
        }

        private void FRMEmpleadoBuscar_Load(object sender, EventArgs e)
        {
            try
            {
                grdEmpleados.AutoGenerateColumns = false;
                CargarEmpleadosAll();
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }

        public void CargarEmpleadosAll()
        {
            try
            {
                var empleados = _services.ConsultarEmpleadosAll();
                grdEmpleados.DataSource = empleados.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void grdEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var rowsCount = grdEmpleados.SelectedRows.Count;
                if (rowsCount == 0 || rowsCount > 1) return;

                var row = grdEmpleados.SelectedRows[0];
                if (row == null) return;

                EmpleadoSeleccionado = int.Parse(row.Cells["clnIEmpleadoId"].Value.ToString());

                OnSelectEmpleadoEvent(e);
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }
    }
}