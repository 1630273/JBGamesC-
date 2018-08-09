namespace JBTienda
{
    partial class FormMCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnSalud = new System.Windows.Forms.Button();
            this.btnEle = new System.Windows.Forms.Button();
            this.btnCel = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cuinicio1 = new JBTienda.Cuinicio();
            this.cucom1 = new JBTienda.Cucom();
            this.cujuegos1 = new JBTienda.Cujuegos();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnSalud);
            this.panel1.Controls.Add(this.btnEle);
            this.panel1.Controls.Add(this.btnCel);
            this.panel1.Controls.Add(this.btnJuego);
            this.panel1.Controls.Add(this.btnCom);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 450);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "JB Store";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.SidePanel.Location = new System.Drawing.Point(2, 63);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 51);
            this.SidePanel.TabIndex = 3;
            // 
            // btnSalud
            // 
            this.btnSalud.FlatAppearance.BorderSize = 0;
            this.btnSalud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalud.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalud.Image = ((System.Drawing.Image)(resources.GetObject("btnSalud.Image")));
            this.btnSalud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalud.Location = new System.Drawing.Point(9, 293);
            this.btnSalud.Name = "btnSalud";
            this.btnSalud.Size = new System.Drawing.Size(182, 51);
            this.btnSalud.TabIndex = 7;
            this.btnSalud.Text = "   Salud";
            this.btnSalud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalud.UseVisualStyleBackColor = true;
            this.btnSalud.Click += new System.EventHandler(this.btnSalud_Click);
            // 
            // btnEle
            // 
            this.btnEle.FlatAppearance.BorderSize = 0;
            this.btnEle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEle.Image = ((System.Drawing.Image)(resources.GetObject("btnEle.Image")));
            this.btnEle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEle.Location = new System.Drawing.Point(9, 244);
            this.btnEle.Name = "btnEle";
            this.btnEle.Size = new System.Drawing.Size(182, 51);
            this.btnEle.TabIndex = 6;
            this.btnEle.Text = "   Electro";
            this.btnEle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEle.UseVisualStyleBackColor = true;
            this.btnEle.Click += new System.EventHandler(this.btnEle_Click);
            // 
            // btnCel
            // 
            this.btnCel.FlatAppearance.BorderSize = 0;
            this.btnCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCel.Image = ((System.Drawing.Image)(resources.GetObject("btnCel.Image")));
            this.btnCel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCel.Location = new System.Drawing.Point(8, 197);
            this.btnCel.Name = "btnCel";
            this.btnCel.Size = new System.Drawing.Size(182, 51);
            this.btnCel.TabIndex = 5;
            this.btnCel.Text = "   Celulares";
            this.btnCel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCel.UseVisualStyleBackColor = true;
            this.btnCel.Click += new System.EventHandler(this.btnCel_Click);
            // 
            // btnJuego
            // 
            this.btnJuego.FlatAppearance.BorderSize = 0;
            this.btnJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuego.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuego.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJuego.Image = ((System.Drawing.Image)(resources.GetObject("btnJuego.Image")));
            this.btnJuego.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJuego.Location = new System.Drawing.Point(9, 152);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(182, 51);
            this.btnJuego.TabIndex = 4;
            this.btnJuego.Text = "  Juegos";
            this.btnJuego.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJuego.UseVisualStyleBackColor = true;
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // btnCom
            // 
            this.btnCom.FlatAppearance.BorderSize = 0;
            this.btnCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCom.Image = ((System.Drawing.Image)(resources.GetObject("btnCom.Image")));
            this.btnCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCom.Location = new System.Drawing.Point(9, 108);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(182, 51);
            this.btnCom.TabIndex = 3;
            this.btnCom.Text = "   Comp";
            this.btnCom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(12, 64);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(182, 51);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "   INICIO";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carrito";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 15);
            this.panel2.TabIndex = 4;
            // 
            // cuinicio1
            // 
            this.cuinicio1.Location = new System.Drawing.Point(194, 52);
            this.cuinicio1.Name = "cuinicio1";
            this.cuinicio1.Size = new System.Drawing.Size(594, 359);
            this.cuinicio1.TabIndex = 9;
            // 
            // cucom1
            // 
            this.cucom1.Location = new System.Drawing.Point(194, 64);
            this.cucom1.Name = "cucom1";
            this.cucom1.Size = new System.Drawing.Size(594, 304);
            this.cucom1.TabIndex = 8;
            // 
            // cujuegos1
            // 
            this.cujuegos1.Location = new System.Drawing.Point(194, 64);
            this.cujuegos1.Name = "cujuegos1";
            this.cujuegos1.Size = new System.Drawing.Size(612, 306);
            this.cujuegos1.TabIndex = 7;
            // 
            // FormMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cuinicio1);
            this.Controls.Add(this.cucom1);
            this.Controls.Add(this.cujuegos1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMCliente";
            this.Text = "FormMCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnSalud;
        private System.Windows.Forms.Button btnEle;
        private System.Windows.Forms.Button btnCel;
        private System.Windows.Forms.Button btnJuego;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Cujuegos cujuegos1;
        private Cucom cucom1;
        private Cuinicio cuinicio1;
    }
}