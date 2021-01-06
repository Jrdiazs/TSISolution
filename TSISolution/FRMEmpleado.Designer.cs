namespace TSI.AppWindows
{
    partial class FRMEmpleado
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
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.cmbTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.bttnGuardarEmpleado = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.bttnCrearNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(79, 70);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(126, 17);
            this.lblTipoIdentificacion.TabIndex = 0;
            this.lblTipoIdentificacion.Text = "Tipo Identificación:";
            // 
            // cmbTipoIdentificacion
            // 
            this.cmbTipoIdentificacion.DisplayMember = "Nombre";
            this.cmbTipoIdentificacion.FormattingEnabled = true;
            this.cmbTipoIdentificacion.Location = new System.Drawing.Point(301, 67);
            this.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion";
            this.cmbTipoIdentificacion.Size = new System.Drawing.Size(227, 24);
            this.cmbTipoIdentificacion.TabIndex = 1;
            this.cmbTipoIdentificacion.ValueMember = "TipoIdentificacionId";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(67, 118);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(138, 17);
            this.lblNumeroDocumento.TabIndex = 2;
            this.lblNumeroDocumento.Text = "Número Documento:";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(301, 118);
            this.txtNumeroDocumento.MaxLength = 20;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(227, 22);
            this.txtNumeroDocumento.TabIndex = 3;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(301, 177);
            this.txtNombres.MaxLength = 100;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(227, 22);
            this.txtNombres.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(136, 177);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombres:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(301, 235);
            this.txtApellidos.MaxLength = 100;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(227, 22);
            this.txtApellidos.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(136, 235);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 17);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellidos:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(145, 288);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(60, 17);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Genero:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DisplayMember = "Text";
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(301, 288);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(227, 24);
            this.cmbGenero.TabIndex = 9;
            this.cmbGenero.ValueMember = "Value";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(301, 346);
            this.txtCiudad.MaxLength = 100;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(227, 22);
            this.txtCiudad.TabIndex = 11;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(149, 346);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(56, 17);
            this.lblCiudad.TabIndex = 10;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(301, 402);
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(227, 22);
            this.txtDireccion.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(134, 402);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 17);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Dirección:";
            // 
            // bttnGuardarEmpleado
            // 
            this.bttnGuardarEmpleado.Location = new System.Drawing.Point(98, 463);
            this.bttnGuardarEmpleado.Name = "bttnGuardarEmpleado";
            this.bttnGuardarEmpleado.Size = new System.Drawing.Size(172, 31);
            this.bttnGuardarEmpleado.TabIndex = 14;
            this.bttnGuardarEmpleado.Text = "Guardar Empleado";
            this.bttnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.bttnGuardarEmpleado.Click += new System.EventHandler(this.bttnGuardarEmpleado_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.AutoScroll = true;
            this.pnlGrid.Location = new System.Drawing.Point(568, 70);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(921, 472);
            this.pnlGrid.TabIndex = 15;
            // 
            // bttnCrearNuevo
            // 
            this.bttnCrearNuevo.Enabled = false;
            this.bttnCrearNuevo.Location = new System.Drawing.Point(577, 32);
            this.bttnCrearNuevo.Name = "bttnCrearNuevo";
            this.bttnCrearNuevo.Size = new System.Drawing.Size(124, 23);
            this.bttnCrearNuevo.TabIndex = 16;
            this.bttnCrearNuevo.Text = "Crear Nuevo";
            this.bttnCrearNuevo.UseVisualStyleBackColor = true;
            this.bttnCrearNuevo.Click += new System.EventHandler(this.bttnCrearNuevo_Click);
            // 
            // FRMEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 633);
            this.Controls.Add(this.bttnCrearNuevo);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.bttnGuardarEmpleado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.cmbTipoIdentificacion);
            this.Controls.Add(this.lblTipoIdentificacion);
            this.Name = "FRMEmpleado";
            this.Text = "Guardar Empleado";
            this.Load += new System.EventHandler(this.FRMEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.ComboBox cmbTipoIdentificacion;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button bttnGuardarEmpleado;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Button bttnCrearNuevo;
    }
}