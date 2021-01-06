namespace TSI.AppWindows
{
    partial class FRMEmpleadoBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdEmpleados = new System.Windows.Forms.DataGridView();
            this.clnIEmpleadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEmpleados
            // 
            this.grdEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIEmpleadoId,
            this.clnTipoIdentificacion,
            this.clnNumeroDocumento,
            this.clnGenero,
            this.clnCiudad,
            this.clnDireccion,
            this.clnNombres,
            this.clnApellidos});
            this.grdEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEmpleados.Location = new System.Drawing.Point(0, 0);
            this.grdEmpleados.Name = "grdEmpleados";
            this.grdEmpleados.RowHeadersWidth = 51;
            this.grdEmpleados.RowTemplate.Height = 24;
            this.grdEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmpleados.Size = new System.Drawing.Size(800, 450);
            this.grdEmpleados.TabIndex = 0;
            this.grdEmpleados.SelectionChanged += new System.EventHandler(this.grdEmpleados_SelectionChanged);
            // 
            // clnIEmpleadoId
            // 
            this.clnIEmpleadoId.DataPropertyName = "EmpleadoId";
            this.clnIEmpleadoId.HeaderText = "Id";
            this.clnIEmpleadoId.MinimumWidth = 6;
            this.clnIEmpleadoId.Name = "clnIEmpleadoId";
            this.clnIEmpleadoId.Width = 125;
            // 
            // clnTipoIdentificacion
            // 
            this.clnTipoIdentificacion.DataPropertyName = "TipoIdentificacion";
            this.clnTipoIdentificacion.HeaderText = "Tipo Identificación";
            this.clnTipoIdentificacion.MinimumWidth = 6;
            this.clnTipoIdentificacion.Name = "clnTipoIdentificacion";
            this.clnTipoIdentificacion.Width = 125;
            // 
            // clnNumeroDocumento
            // 
            this.clnNumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.clnNumeroDocumento.HeaderText = "Documento";
            this.clnNumeroDocumento.MinimumWidth = 6;
            this.clnNumeroDocumento.Name = "clnNumeroDocumento";
            this.clnNumeroDocumento.Width = 125;
            // 
            // clnGenero
            // 
            this.clnGenero.DataPropertyName = "Genero";
            this.clnGenero.HeaderText = "Genero";
            this.clnGenero.MinimumWidth = 6;
            this.clnGenero.Name = "clnGenero";
            this.clnGenero.Width = 125;
            // 
            // clnCiudad
            // 
            this.clnCiudad.DataPropertyName = "Ciudad";
            this.clnCiudad.HeaderText = "Ciudad";
            this.clnCiudad.MinimumWidth = 6;
            this.clnCiudad.Name = "clnCiudad";
            this.clnCiudad.Width = 125;
            // 
            // clnDireccion
            // 
            this.clnDireccion.DataPropertyName = "Direccion";
            this.clnDireccion.HeaderText = "Direccion";
            this.clnDireccion.MinimumWidth = 6;
            this.clnDireccion.Name = "clnDireccion";
            this.clnDireccion.Width = 125;
            // 
            // clnNombres
            // 
            this.clnNombres.DataPropertyName = "Nombres";
            this.clnNombres.HeaderText = "Nombres";
            this.clnNombres.MinimumWidth = 6;
            this.clnNombres.Name = "clnNombres";
            this.clnNombres.Width = 125;
            // 
            // clnApellidos
            // 
            this.clnApellidos.DataPropertyName = "Apellidos";
            this.clnApellidos.HeaderText = "Apellidos";
            this.clnApellidos.MinimumWidth = 6;
            this.clnApellidos.Name = "clnApellidos";
            this.clnApellidos.Width = 125;
            // 
            // FRMEmpleadoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdEmpleados);
            this.Name = "FRMEmpleadoBuscar";
            this.Text = "Buscar Empleados";
            this.Load += new System.EventHandler(this.FRMEmpleadoBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIEmpleadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnApellidos;
    }
}