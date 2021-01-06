using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TSI.AppWindows.Modal.Info;
using TSI.AppWindows.Models;

namespace TSI.AppWindows
{
    public partial class FRMEmpleadoDetalle : Form
    {
        private int _empleadoId = 0;
        private Empleado _empleado;

        public FRMEmpleadoDetalle(Empleado empleado)
        {
            _empleado = empleado;
            InitializeComponent();
        }

        private void FRMEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboTiposIdentificacion();
                CargarComboGenero();
                CargarFormulario(_empleado);
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }

        private void CargarFormulario(Empleado empleado)
        {
            try
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
            catch (Exception)
            {
                throw;
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

        private void CargarComboGenero()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("M", "MASCULINO");
            values.Add("F", "FEMENINO");

            cmbGenero.DataSource = values.Select(x => new { Text = x.Value, Value = x.Key }).ToList();
        }
    }
}