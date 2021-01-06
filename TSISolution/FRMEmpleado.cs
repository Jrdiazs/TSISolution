using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TSI.AppWindows.Modal.Info;
using TSI.Services;
using TSI.Services.ModelRequest;
using TSI.Utils.StringTools;

namespace TSI.AppWindows
{
    public partial class FRMEmpleado : Form
    {
        private readonly IEmpleadoServices _services;
        private FRMEmpleadoBuscar _formBusqueda;
        private int _empleadoId = 0;

        public FRMEmpleado(IEmpleadoServices services)
        {
            _services = services;
            InitializeComponent();
        }

        private void FRMEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboTiposIdentificacion();
                CargarComboGenero();

                _formBusqueda = new FRMEmpleadoBuscar(_services);
                _formBusqueda.SelectEmpleadoEvent += FormBusqueda_SelectEmpleadoEvent;
                _formBusqueda.TopLevel = false;
                _formBusqueda.AutoScroll = true;
                pnlGrid.Controls.Add(_formBusqueda);
                _formBusqueda.FormBorderStyle = FormBorderStyle.None;
                _formBusqueda.Show();
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }

        private void FormBusqueda_SelectEmpleadoEvent(object sender, EventArgs e)
        {
            try
            {
                _empleadoId = _formBusqueda.EmpleadoSeleccionado;
                bttnCrearNuevo.Enabled = true;
                CargarFormularioEmpleado(_empleadoId);
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }

        private void CargarFormularioEmpleado(int empleadoId)
        {
            try
            {
                var empleado = _services.ConsultarEmpleadoPorId(empleadoId);

                if (empleado != null)
                {
                    _empleadoId = empleado.EmpleadoId;
                    txtApellidos.Text = empleado.Apellidos;
                    txtCiudad.Text = empleado.Ciudad;
                    txtDireccion.Text = empleado.Direccion;
                    txtNombres.Text = empleado.Nombres;
                    txtNumeroDocumento.Text = empleado.NumeroDocumento;
                    cmbGenero.SelectedValue = empleado.Genero;
                    cmbTipoIdentificacion.SelectedValue = empleado.TipoIdentificacionId;
                }
                else
                {
                    this.ShowInfo($"No se encontro el empleado por id {empleadoId}");
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LimpiarFormulario()
        {
            _empleadoId = 0;
            txtNumeroDocumento.Text = txtNombres.Text = txtDireccion.Text = txtCiudad.Text = txtApellidos.Text = string.Empty;
            cmbGenero.SelectedIndex = cmbTipoIdentificacion.SelectedIndex = -1;
            bttnCrearNuevo.Enabled = false;
        }

        private void CargarComboTiposIdentificacion()
        {
            try
            {
                var tiposIdentificacion = _services.ConsultarTiposIdentificacion();

                cmbTipoIdentificacion.DataSource = tiposIdentificacion.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private EmpleadoRequest ObtenerEmpleadoForm()
        {
            return new EmpleadoRequest()
            {
                TipoIdentificacionId = cmbTipoIdentificacion.SelectedValue == null ? 0 : (int)cmbTipoIdentificacion.SelectedValue,
                Apellidos = txtApellidos.Text.Trim(),
                Nombres = txtNombres.Text.Trim(),
                Ciudad = txtCiudad.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                EmpleadoId = _empleadoId,
                Genero = cmbGenero.SelectedValue == null ? string.Empty : (string)cmbGenero.SelectedValue,
                NumeroDocumento = txtNumeroDocumento.Text
            };
        }

        private void CargarComboGenero()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("M", "MASCULINO");
            values.Add("F", "FEMENINO");

            cmbGenero.DataSource = values.Select(x => new { Text = x.Value, Value = x.Key }).ToList();
        }

        private void bttnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                var empleado = ObtenerEmpleadoForm();

                if (empleado.NumeroDocumento.IsEmpty())
                {
                    this.ShowInfo("El Número de documento no puede ser vacio");
                    txtNumeroDocumento.Focus();
                    return;
                }

                if (empleado.Genero.IsEmpty())
                {
                    this.ShowInfo("Seleccione un genero válido");
                    cmbGenero.Focus();
                    return;
                }

                if (empleado.TipoIdentificacionId == 0)
                {
                    this.ShowInfo("Seleccione un tipo de identificación válido");
                    cmbTipoIdentificacion.Focus();
                    return;
                }

                if (empleado.Nombres.IsEmpty())
                {
                    this.ShowInfo("El Nombre no puede ser vacio");
                    txtNombres.Focus();
                    return;
                }

                if (empleado.Apellidos.IsEmpty())
                {
                    this.ShowInfo("El Apellido no puede ser vacio");
                    txtApellidos.Focus();
                    return;
                }

                var nuevoEmpleado = empleado.EmpleadoId > 0 ? _services.ModificarEmpleado(empleado) : _services.GuardarEmpleado(empleado);

                this.ShowInfo("Empleado guardado correctamente");
                LimpiarFormulario();

                _formBusqueda.CargarEmpleadosAll();
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }

        private void bttnCrearNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }
    }
}