﻿namespace JBTienda
{
    partial class RegistrarUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuarios));
            this.txtContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContraseña2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidoMaterno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidoPaterno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rdoHombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoMujer = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialSingleLineTextField7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField8 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.materialSingleLineTextField9 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcodigop = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ErrorCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContraseña2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAp = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAm = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSexo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCp = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCp = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCampos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Hint = "Contraseña";
            this.txtContraseña.Location = new System.Drawing.Point(52, 157);
            this.txtContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.Size = new System.Drawing.Size(251, 23);
            this.txtContraseña.TabIndex = 31;
            this.txtContraseña.UseSystemPasswordChar = false;
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña_Validating);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.White;
            this.txtNombreUsuario.Depth = 0;
            this.txtNombreUsuario.Hint = "Usuario";
            this.txtNombreUsuario.Location = new System.Drawing.Point(52, 116);
            this.txtNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.SelectionLength = 0;
            this.txtNombreUsuario.SelectionStart = 0;
            this.txtNombreUsuario.Size = new System.Drawing.Size(251, 23);
            this.txtNombreUsuario.TabIndex = 30;
            this.txtNombreUsuario.UseSystemPasswordChar = false;
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.BackColor = System.Drawing.Color.White;
            this.txtContraseña2.Depth = 0;
            this.txtContraseña2.Hint = "Confirmar Contraseña";
            this.txtContraseña2.Location = new System.Drawing.Point(52, 200);
            this.txtContraseña2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.SelectedText = "";
            this.txtContraseña2.SelectionLength = 0;
            this.txtContraseña2.SelectionStart = 0;
            this.txtContraseña2.Size = new System.Drawing.Size(251, 23);
            this.txtContraseña2.TabIndex = 33;
            this.txtContraseña2.UseSystemPasswordChar = false;
            this.txtContraseña2.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña2_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(52, 240);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(251, 23);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.White;
            this.txtApellidoMaterno.Depth = 0;
            this.txtApellidoMaterno.Hint = "Apellido Materno";
            this.txtApellidoMaterno.Location = new System.Drawing.Point(52, 325);
            this.txtApellidoMaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.PasswordChar = '\0';
            this.txtApellidoMaterno.SelectedText = "";
            this.txtApellidoMaterno.SelectionLength = 0;
            this.txtApellidoMaterno.SelectionStart = 0;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(251, 23);
            this.txtApellidoMaterno.TabIndex = 35;
            this.txtApellidoMaterno.UseSystemPasswordChar = false;
            this.txtApellidoMaterno.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            this.txtApellidoMaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoMaterno_Validating);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.White;
            this.txtApellidoPaterno.Depth = 0;
            this.txtApellidoPaterno.Hint = "Apellido Paterno";
            this.txtApellidoPaterno.Location = new System.Drawing.Point(52, 282);
            this.txtApellidoPaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.PasswordChar = '\0';
            this.txtApellidoPaterno.SelectedText = "";
            this.txtApellidoPaterno.SelectionLength = 0;
            this.txtApellidoPaterno.SelectionStart = 0;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(251, 23);
            this.txtApellidoPaterno.TabIndex = 34;
            this.txtApellidoPaterno.UseSystemPasswordChar = false;
            this.txtApellidoPaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoPaterno_Validating);
            // 
            // rdoHombre
            // 
            this.rdoHombre.AutoSize = true;
            this.rdoHombre.Depth = 0;
            this.rdoHombre.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoHombre.Location = new System.Drawing.Point(52, 523);
            this.rdoHombre.Margin = new System.Windows.Forms.Padding(0);
            this.rdoHombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoHombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoHombre.Name = "rdoHombre";
            this.rdoHombre.Ripple = true;
            this.rdoHombre.Size = new System.Drawing.Size(78, 30);
            this.rdoHombre.TabIndex = 36;
            this.rdoHombre.TabStop = true;
            this.rdoHombre.Text = "Hombre";
            this.rdoHombre.UseVisualStyleBackColor = true;
            // 
            // rdoMujer
            // 
            this.rdoMujer.AutoSize = true;
            this.rdoMujer.Depth = 0;
            this.rdoMujer.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoMujer.Location = new System.Drawing.Point(239, 523);
            this.rdoMujer.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMujer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoMujer.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoMujer.Name = "rdoMujer";
            this.rdoMujer.Ripple = true;
            this.rdoMujer.Size = new System.Drawing.Size(64, 30);
            this.rdoMujer.TabIndex = 37;
            this.rdoMujer.TabStop = true;
            this.rdoMujer.Text = "Mujer";
            this.rdoMujer.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField7
            // 
            this.materialSingleLineTextField7.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField7.Depth = 0;
            this.materialSingleLineTextField7.Enabled = false;
            this.materialSingleLineTextField7.Hint = "";
            this.materialSingleLineTextField7.Location = new System.Drawing.Point(52, 570);
            this.materialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField7.Name = "materialSingleLineTextField7";
            this.materialSingleLineTextField7.PasswordChar = '\0';
            this.materialSingleLineTextField7.SelectedText = "";
            this.materialSingleLineTextField7.SelectionLength = 0;
            this.materialSingleLineTextField7.SelectionStart = 0;
            this.materialSingleLineTextField7.Size = new System.Drawing.Size(137, 23);
            this.materialSingleLineTextField7.TabIndex = 39;
            this.materialSingleLineTextField7.Text = "Estado";
            this.materialSingleLineTextField7.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField8
            // 
            this.materialSingleLineTextField8.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField8.Depth = 0;
            this.materialSingleLineTextField8.Enabled = false;
            this.materialSingleLineTextField8.Hint = "";
            this.materialSingleLineTextField8.Location = new System.Drawing.Point(52, 609);
            this.materialSingleLineTextField8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField8.Name = "materialSingleLineTextField8";
            this.materialSingleLineTextField8.PasswordChar = '\0';
            this.materialSingleLineTextField8.SelectedText = "";
            this.materialSingleLineTextField8.SelectionLength = 0;
            this.materialSingleLineTextField8.SelectionStart = 0;
            this.materialSingleLineTextField8.Size = new System.Drawing.Size(137, 23);
            this.materialSingleLineTextField8.TabIndex = 41;
            this.materialSingleLineTextField8.Text = "Ciudad ";
            this.materialSingleLineTextField8.UseSystemPasswordChar = false;
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(239, 611);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(121, 21);
            this.cboCiudad.TabIndex = 40;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(222, 490);
            this.txtTelefono.Mask = "(999)000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(124, 20);
            this.txtTelefono.TabIndex = 42;
            this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefono_Validating);
            // 
            // materialSingleLineTextField9
            // 
            this.materialSingleLineTextField9.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField9.Depth = 0;
            this.materialSingleLineTextField9.Enabled = false;
            this.materialSingleLineTextField9.Hint = "";
            this.materialSingleLineTextField9.Location = new System.Drawing.Point(52, 487);
            this.materialSingleLineTextField9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField9.Name = "materialSingleLineTextField9";
            this.materialSingleLineTextField9.PasswordChar = '\0';
            this.materialSingleLineTextField9.SelectedText = "";
            this.materialSingleLineTextField9.SelectionLength = 0;
            this.materialSingleLineTextField9.SelectionStart = 0;
            this.materialSingleLineTextField9.Size = new System.Drawing.Size(137, 23);
            this.materialSingleLineTextField9.TabIndex = 43;
            this.materialSingleLineTextField9.Text = "Telefono";
            this.materialSingleLineTextField9.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "Dirección";
            this.txtDireccion.Location = new System.Drawing.Point(52, 363);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(251, 23);
            this.txtDireccion.TabIndex = 44;
            this.txtDireccion.UseSystemPasswordChar = false;
            this.txtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDireccion_Validating);
            // 
            // txtcodigop
            // 
            this.txtcodigop.BackColor = System.Drawing.Color.White;
            this.txtcodigop.Depth = 0;
            this.txtcodigop.Enabled = false;
            this.txtcodigop.Hint = "";
            this.txtcodigop.Location = new System.Drawing.Point(52, 446);
            this.txtcodigop.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcodigop.Name = "txtcodigop";
            this.txtcodigop.PasswordChar = '\0';
            this.txtcodigop.SelectedText = "";
            this.txtcodigop.SelectionLength = 0;
            this.txtcodigop.SelectionStart = 0;
            this.txtcodigop.Size = new System.Drawing.Size(137, 23);
            this.txtcodigop.TabIndex = 45;
            this.txtcodigop.Text = "Codigo Postal";
            this.txtcodigop.UseSystemPasswordChar = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.CausesValidation = false;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Purple;
            this.btnVolver.Location = new System.Drawing.Point(52, 690);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(137, 28);
            this.btnVolver.TabIndex = 47;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(222, 690);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Primary = true;
            this.btnRegistrar.Size = new System.Drawing.Size(141, 28);
            this.btnRegistrar.TabIndex = 46;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(239, 572);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 48;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Hint = "Correo";
            this.txtCorreo.Location = new System.Drawing.Point(52, 401);
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(251, 23);
            this.txtCorreo.TabIndex = 49;
            this.txtCorreo.UseSystemPasswordChar = false;
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // ErrorCampos
            // 
            this.ErrorCampos.ContainerControl = this;
            this.ErrorCampos.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorCampos.Icon")));
            // 
            // errorUsuario
            // 
            this.errorUsuario.ContainerControl = this;
            this.errorUsuario.Icon = ((System.Drawing.Icon)(resources.GetObject("errorUsuario.Icon")));
            // 
            // errorContraseña
            // 
            this.errorContraseña.ContainerControl = this;
            this.errorContraseña.Icon = ((System.Drawing.Icon)(resources.GetObject("errorContraseña.Icon")));
            // 
            // errorContraseña2
            // 
            this.errorContraseña2.ContainerControl = this;
            this.errorContraseña2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorContraseña2.Icon")));
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            this.errorNombre.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNombre.Icon")));
            // 
            // errorAp
            // 
            this.errorAp.ContainerControl = this;
            this.errorAp.Icon = ((System.Drawing.Icon)(resources.GetObject("errorAp.Icon")));
            // 
            // errorAm
            // 
            this.errorAm.ContainerControl = this;
            this.errorAm.Icon = ((System.Drawing.Icon)(resources.GetObject("errorAm.Icon")));
            // 
            // errorSexo
            // 
            this.errorSexo.ContainerControl = this;
            this.errorSexo.Icon = ((System.Drawing.Icon)(resources.GetObject("errorSexo.Icon")));
            // 
            // errorTelefono
            // 
            this.errorTelefono.ContainerControl = this;
            this.errorTelefono.Icon = ((System.Drawing.Icon)(resources.GetObject("errorTelefono.Icon")));
            // 
            // errorCorreo
            // 
            this.errorCorreo.ContainerControl = this;
            this.errorCorreo.Icon = ((System.Drawing.Icon)(resources.GetObject("errorCorreo.Icon")));
            // 
            // errorDireccion
            // 
            this.errorDireccion.ContainerControl = this;
            this.errorDireccion.Icon = ((System.Drawing.Icon)(resources.GetObject("errorDireccion.Icon")));
            // 
            // errorCp
            // 
            this.errorCp.ContainerControl = this;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(222, 449);
            this.txtCp.Mask = "00000";
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(46, 20);
            this.txtCp.TabIndex = 50;
            // 
            // RegistrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 734);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtcodigop);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.materialSingleLineTextField9);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.materialSingleLineTextField8);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.materialSingleLineTextField7);
            this.Controls.Add(this.rdoMujer);
            this.Controls.Add(this.rdoHombre);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreUsuario);
            this.KeyPreview = true;
            this.Name = "RegistrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuario";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegistrarUsuarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCampos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraseña;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraseña2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidoMaterno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidoPaterno;
        private MaterialSkin.Controls.MaterialRadioButton rdoHombre;
        private MaterialSkin.Controls.MaterialRadioButton rdoMujer;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField7;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField8;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcodigop;
        private System.Windows.Forms.Button btnVolver;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrar;
        private System.Windows.Forms.ComboBox cboEstado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private System.Windows.Forms.ErrorProvider ErrorCampos;
        private System.Windows.Forms.ErrorProvider errorUsuario;
        private System.Windows.Forms.ErrorProvider errorContraseña;
        private System.Windows.Forms.ErrorProvider errorContraseña2;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorAp;
        private System.Windows.Forms.ErrorProvider errorAm;
        private System.Windows.Forms.ErrorProvider errorSexo;
        private System.Windows.Forms.ErrorProvider errorTelefono;
        private System.Windows.Forms.ErrorProvider errorCorreo;
        private System.Windows.Forms.ErrorProvider errorDireccion;
        private System.Windows.Forms.ErrorProvider errorCp;
        private System.Windows.Forms.MaskedTextBox txtCp;
    }
}