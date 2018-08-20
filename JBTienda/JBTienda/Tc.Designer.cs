namespace JBTienda
{
    partial class Tc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tc));
            this.txtNP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFe = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNP
            // 
            this.txtNP.BackColor = System.Drawing.Color.White;
            this.txtNP.Depth = 0;
            this.txtNP.Hint = "Nombre y apellido";
            this.txtNP.Location = new System.Drawing.Point(24, 147);
            this.txtNP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNP.Name = "txtNP";
            this.txtNP.PasswordChar = '\0';
            this.txtNP.SelectedText = "";
            this.txtNP.SelectionLength = 0;
            this.txtNP.SelectionStart = 0;
            this.txtNP.Size = new System.Drawing.Size(236, 23);
            this.txtNP.TabIndex = 66;
            this.txtNP.UseSystemPasswordChar = false;
            this.txtNP.Click += new System.EventHandler(this.txtContraseña_Click);
            // 
            // txtFe
            // 
            this.txtFe.BackColor = System.Drawing.Color.White;
            this.txtFe.Depth = 0;
            this.txtFe.Hint = "Fecha  Ex.";
            this.txtFe.Location = new System.Drawing.Point(24, 187);
            this.txtFe.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFe.Name = "txtFe";
            this.txtFe.PasswordChar = '\0';
            this.txtFe.SelectedText = "";
            this.txtFe.SelectionLength = 0;
            this.txtFe.SelectionStart = 0;
            this.txtFe.Size = new System.Drawing.Size(86, 23);
            this.txtFe.TabIndex = 65;
            this.txtFe.UseSystemPasswordChar = false;
            // 
            // txtNumT
            // 
            this.txtNumT.BackColor = System.Drawing.Color.White;
            this.txtNumT.Depth = 0;
            this.txtNumT.Hint = "Número de Tarjeta";
            this.txtNumT.Location = new System.Drawing.Point(24, 109);
            this.txtNumT.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumT.Name = "txtNumT";
            this.txtNumT.PasswordChar = '\0';
            this.txtNumT.SelectedText = "";
            this.txtNumT.SelectionLength = 0;
            this.txtNumT.SelectionStart = 0;
            this.txtNumT.Size = new System.Drawing.Size(236, 23);
            this.txtNumT.TabIndex = 64;
            this.txtNumT.UseSystemPasswordChar = false;
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
            this.btnRegistrar.Location = new System.Drawing.Point(24, 263);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(249, 28);
            this.btnRegistrar.TabIndex = 67;
            this.btnRegistrar.Text = "Continuar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Transparent;
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnC.Image = ((System.Drawing.Image)(resources.GetObject("btnC.Image")));
            this.btnC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnC.Location = new System.Drawing.Point(3, 0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(251, 41);
            this.btnC.TabIndex = 68;
            this.btnC.Text = "        Tarjeta de crédito";
            this.btnC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.btnMod);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 45);
            this.panel1.TabIndex = 69;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.Transparent;
            this.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod.Location = new System.Drawing.Point(443, 1);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(94, 41);
            this.btnMod.TabIndex = 69;
            this.btnMod.Text = "Modificar";
            this.btnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMod.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Ingrese su tarjeta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.White;
            this.txtCod.Depth = 0;
            this.txtCod.Hint = "Codigo S.";
            this.txtCod.Location = new System.Drawing.Point(174, 187);
            this.txtCod.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCod.Name = "txtCod";
            this.txtCod.PasswordChar = '\0';
            this.txtCod.SelectedText = "";
            this.txtCod.SelectionLength = 0;
            this.txtCod.SelectionStart = 0;
            this.txtCod.Size = new System.Drawing.Size(86, 23);
            this.txtCod.TabIndex = 72;
            this.txtCod.UseSystemPasswordChar = false;
            // 
            // Tc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNP);
            this.Controls.Add(this.txtFe);
            this.Controls.Add(this.txtNumT);
            this.Name = "Tc";
            this.Size = new System.Drawing.Size(537, 310);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtNP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFe;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumT;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCod;
    }
}
