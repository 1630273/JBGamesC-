namespace JBTienda
{
    partial class FormLogin
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            System.Windows.Forms.PictureBox pictureBox1;
            this.lblUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblcontraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnIncio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.linkRC = new System.Windows.Forms.LinkLabel();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(28, 162);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(24, 24);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(28, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(24, 24);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Hint = "Usuario";
            this.lblUsuario.Location = new System.Drawing.Point(82, 108);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.PasswordChar = '\0';
            this.lblUsuario.SelectedText = "";
            this.lblUsuario.SelectionLength = 0;
            this.lblUsuario.SelectionStart = 0;
            this.lblUsuario.Size = new System.Drawing.Size(277, 23);
            this.lblUsuario.TabIndex = 28;
            this.lblUsuario.UseSystemPasswordChar = false;
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.BackColor = System.Drawing.Color.White;
            this.lblcontraseña.Depth = 0;
            this.lblcontraseña.Hint = "Contraseña";
            this.lblcontraseña.Location = new System.Drawing.Point(82, 162);
            this.lblcontraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.PasswordChar = '*';
            this.lblcontraseña.SelectedText = "";
            this.lblcontraseña.SelectionLength = 0;
            this.lblcontraseña.SelectionStart = 0;
            this.lblcontraseña.Size = new System.Drawing.Size(277, 23);
            this.lblcontraseña.TabIndex = 29;
            this.lblcontraseña.UseSystemPasswordChar = false;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.BackColor = System.Drawing.Color.White;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(28, 201);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(153, 30);
            this.materialCheckBox1.TabIndex = 30;
            this.materialCheckBox1.Text = "Mostrar Contraseña";
            this.materialCheckBox1.UseVisualStyleBackColor = false;
            // 
            // btnIncio
            // 
            this.btnIncio.BackColor = System.Drawing.Color.Transparent;
            this.btnIncio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncio.Depth = 0;
            this.btnIncio.FlatAppearance.BorderSize = 0;
            this.btnIncio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.btnIncio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIncio.Location = new System.Drawing.Point(198, 260);
            this.btnIncio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIncio.Name = "btnIncio";
            this.btnIncio.Primary = true;
            this.btnIncio.Size = new System.Drawing.Size(152, 28);
            this.btnIncio.TabIndex = 31;
            this.btnIncio.Text = "Inicio";
            this.btnIncio.UseVisualStyleBackColor = false;
            this.btnIncio.Click += new System.EventHandler(this.btnIncio_Click);
            // 
            // linkRC
            // 
            this.linkRC.ActiveLinkColor = System.Drawing.Color.DarkBlue;
            this.linkRC.AutoSize = true;
            this.linkRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRC.LinkColor = System.Drawing.Color.Purple;
            this.linkRC.Location = new System.Drawing.Point(195, 207);
            this.linkRC.Name = "linkRC";
            this.linkRC.Size = new System.Drawing.Size(164, 16);
            this.linkRC.TabIndex = 32;
            this.linkRC.TabStop = true;
            this.linkRC.Text = "Recuperar Contraseña";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.White;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.Purple;
            this.btnRegistrarse.Location = new System.Drawing.Point(23, 260);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(157, 28);
            this.btnRegistrarse.TabIndex = 33;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(357, 34);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 21);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 316);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.linkRC);
            this.Controls.Add(this.btnIncio);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicias sesión";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField lblUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblcontraseña;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnIncio;
        private System.Windows.Forms.LinkLabel linkRC;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnSalir;
    }
}

