namespace JBTienda
{
    partial class Acom
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdoMujer = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoHombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtApellidoMaterno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidoPaterno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoMujer
            // 
            this.rdoMujer.AutoSize = true;
            this.rdoMujer.Depth = 0;
            this.rdoMujer.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoMujer.Location = new System.Drawing.Point(322, 278);
            this.rdoMujer.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMujer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoMujer.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoMujer.Name = "rdoMujer";
            this.rdoMujer.Ripple = true;
            this.rdoMujer.Size = new System.Drawing.Size(64, 30);
            this.rdoMujer.TabIndex = 44;
            this.rdoMujer.TabStop = true;
            this.rdoMujer.Text = "Mujer";
            this.rdoMujer.UseVisualStyleBackColor = true;
            this.rdoMujer.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // rdoHombre
            // 
            this.rdoHombre.AutoSize = true;
            this.rdoHombre.Depth = 0;
            this.rdoHombre.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoHombre.Location = new System.Drawing.Point(166, 278);
            this.rdoHombre.Margin = new System.Windows.Forms.Padding(0);
            this.rdoHombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoHombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoHombre.Name = "rdoHombre";
            this.rdoHombre.Ripple = true;
            this.rdoHombre.Size = new System.Drawing.Size(78, 30);
            this.rdoHombre.TabIndex = 43;
            this.rdoHombre.TabStop = true;
            this.rdoHombre.Text = "Hombre";
            this.rdoHombre.UseVisualStyleBackColor = true;
            this.rdoHombre.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.White;
            this.txtApellidoMaterno.Depth = 0;
            this.txtApellidoMaterno.Hint = "Apellido Materno";
            this.txtApellidoMaterno.Location = new System.Drawing.Point(166, 234);
            this.txtApellidoMaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.PasswordChar = '\0';
            this.txtApellidoMaterno.SelectedText = "";
            this.txtApellidoMaterno.SelectionLength = 0;
            this.txtApellidoMaterno.SelectionStart = 0;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(236, 23);
            this.txtApellidoMaterno.TabIndex = 42;
            this.txtApellidoMaterno.UseSystemPasswordChar = false;
            this.txtApellidoMaterno.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.White;
            this.txtApellidoPaterno.Depth = 0;
            this.txtApellidoPaterno.Hint = "Apellido Paterno";
            this.txtApellidoPaterno.Location = new System.Drawing.Point(166, 194);
            this.txtApellidoPaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.PasswordChar = '\0';
            this.txtApellidoPaterno.SelectedText = "";
            this.txtApellidoPaterno.SelectionLength = 0;
            this.txtApellidoPaterno.SelectionStart = 0;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(236, 23);
            this.txtApellidoPaterno.TabIndex = 41;
            this.txtApellidoPaterno.UseSystemPasswordChar = false;
            this.txtApellidoPaterno.Click += new System.EventHandler(this.materialSingleLineTextField6_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(166, 155);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '*';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(236, 23);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.Click += new System.EventHandler(this.materialSingleLineTextField3_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(166, 77);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(236, 23);
            this.txtUsuario.TabIndex = 38;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Hint = "Contraseña";
            this.txtContraseña.Location = new System.Drawing.Point(166, 115);
            this.txtContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.Size = new System.Drawing.Size(236, 23);
            this.txtContraseña.TabIndex = 45;
            this.txtContraseña.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(104, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Departamento Computadoras";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnRegistrar.CausesValidation = false;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnRegistrar.Location = new System.Drawing.Point(166, 337);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(236, 28);
            this.btnRegistrar.TabIndex = 54;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Acom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.rdoMujer);
            this.Controls.Add(this.rdoHombre);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Acom";
            this.Size = new System.Drawing.Size(537, 417);
            this.Load += new System.EventHandler(this.Acom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton rdoMujer;
        private MaterialSkin.Controls.MaterialRadioButton rdoHombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidoMaterno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidoPaterno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
    }
}
