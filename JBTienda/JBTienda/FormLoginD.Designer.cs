namespace JBTienda
{
    partial class FormLoginD
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
            System.Windows.Forms.PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginD));
            System.Windows.Forms.PictureBox pictureBox1;
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Mostrar = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(25, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(24, 24);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(25, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(24, 24);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Depth = 0;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Location = new System.Drawing.Point(25, 257);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(322, 28);
            this.btnInicio.TabIndex = 45;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnIncio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(341, 34);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 21);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.AutoSize = true;
            this.Mostrar.BackColor = System.Drawing.Color.White;
            this.Mostrar.Depth = 0;
            this.Mostrar.Font = new System.Drawing.Font("Roboto", 10F);
            this.Mostrar.Location = new System.Drawing.Point(25, 200);
            this.Mostrar.Margin = new System.Windows.Forms.Padding(0);
            this.Mostrar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Mostrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Ripple = true;
            this.Mostrar.Size = new System.Drawing.Size(153, 30);
            this.Mostrar.TabIndex = 50;
            this.Mostrar.Text = "Mostrar Contraseña";
            this.Mostrar.UseVisualStyleBackColor = false;
            this.Mostrar.CheckedChanged += new System.EventHandler(this.Mostrar_CheckedChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Hint = "Contraseña";
            this.txtContraseña.Location = new System.Drawing.Point(79, 161);
            this.txtContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.Size = new System.Drawing.Size(277, 23);
            this.txtContraseña.TabIndex = 49;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña_Validating);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(79, 107);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(277, 23);
            this.txtUsuario.TabIndex = 48;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FormLoginD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 324);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox1);
            this.Name = "FormLoginD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jefe de Departamento";
            this.Load += new System.EventHandler(this.FormLoginD_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnInicio;
        private System.Windows.Forms.Button btnSalir;
        private MaterialSkin.Controls.MaterialCheckBox Mostrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraseña;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}