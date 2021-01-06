using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TSI.AppWindows.Modal.Info;
using TSI.AppWindows.Models;
using TSI.Utils.StringTools;

namespace TSI.AppWindows
{
    public partial class FRMEmpleadoTest : Form
    {
        private int _empleadoId = 0;

        public FRMEmpleadoTest()
        {
            InitializeComponent();
        }

        private void FRMEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboTiposIdentificacion();
                CargarComboGenero();
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }

        private void CargarComboTiposIdentificacion()
        {
            try
            {
                Dictionary<int, string> values = new Dictionary<int, string>();
                values.Add(1, "CEDULA DE CIUDADANIA");
                values.Add(2, "NIT");
                values.Add(3, "RUT");
                values.Add(4, "PASAPORTE");
                values.Add(5, "CÉDULA EXTRANJERA");
                values.Add(6, "TARJETA DE IDENTIDAD");
                values.Add(7, "REGISTRO CIVIL");

                cmbTipoIdentificacion.DataSource = values.Select(x => new { Nombre = x.Value, TipoIdentificacionId = x.Key }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Empleado ObtenerEmpleadoForm()
        {
            return new Empleado()
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

                var formDetail = new FRMEmpleadoDetalle(empleado);

                DialogResult dr = formDetail.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    formDetail.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    formDetail.Close();
                }
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }
    }
}