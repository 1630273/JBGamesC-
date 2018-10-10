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
            this.sidemenu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnSalud = new System.Windows.Forms.Button();
            this.btnEle = new System.Windows.Forms.Button();
            this.btnCel = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmenubar = new System.Windows.Forms.Button();
            this.cuEjercicio1 = new JBTienda.CuEjercicio();
            this.cucelulares1 = new JBTienda.Cucelulares();
            this.cujuegos1 = new JBTienda.Cujuegos();
            this.cuinicio1 = new JBTienda.Cuinicio();
            this.cuelectrodomestico1 = new JBTienda.Cuelectrodomestico();
            this.cucom1 = new JBTienda.Cucom();
            this.da1 = new JBTienda.da();
            this.sidemenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sidemenu.Controls.Add(this.logo);
            this.sidemenu.Controls.Add(this.SidePanel);
            this.sidemenu.Controls.Add(this.btnSalud);
            this.sidemenu.Controls.Add(this.btnEle);
            this.sidemenu.Controls.Add(this.btnCel);
            this.sidemenu.Controls.Add(this.btnJuego);
            this.sidemenu.Controls.Add(this.btnCom);
            this.sidemenu.Controls.Add(this.btnInicio);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 37);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(262, 413);
            this.sidemenu.TabIndex = 1;
            this.sidemenu.TabStop = true;
            this.sidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.sidemenu_Paint);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.Location = new System.Drawing.Point(3, 11);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(159, 46);
            this.logo.TabIndex = 9;
            this.logo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnSalud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnSalud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalud.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalud.Image = ((System.Drawing.Image)(resources.GetObject("btnSalud.Image")));
            this.btnSalud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalud.Location = new System.Drawing.Point(12, 196);
            this.btnSalud.Name = "btnSalud";
            this.btnSalud.Size = new System.Drawing.Size(240, 51);
            this.btnSalud.TabIndex = 7;
            this.btnSalud.Text = "   Ejercicio";
            this.btnSalud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalud.UseVisualStyleBackColor = true;
            this.btnSalud.Click += new System.EventHandler(this.btnSalud_Click);
            // 
            // btnEle
            // 
            this.btnEle.FlatAppearance.BorderSize = 0;
            this.btnEle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnEle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEle.Image = ((System.Drawing.Image)(resources.GetObject("btnEle.Image")));
            this.btnEle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEle.Location = new System.Drawing.Point(12, 239);
            this.btnEle.Name = "btnEle";
            this.btnEle.Size = new System.Drawing.Size(250, 51);
            this.btnEle.TabIndex = 6;
            this.btnEle.Text = "   Electrodomesticos";
            this.btnEle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEle.UseVisualStyleBackColor = true;
            this.btnEle.Click += new System.EventHandler(this.btnEle_Click);
            // 
            // btnCel
            // 
            this.btnCel.FlatAppearance.BorderSize = 0;
            this.btnCel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCel.Image = ((System.Drawing.Image)(resources.GetObject("btnCel.Image")));
            this.btnCel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCel.Location = new System.Drawing.Point(12, 109);
            this.btnCel.Name = "btnCel";
            this.btnCel.Size = new System.Drawing.Size(240, 51);
            this.btnCel.TabIndex = 5;
            this.btnCel.Text = "   Celulares";
            this.btnCel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCel.UseVisualStyleBackColor = true;
            this.btnCel.Click += new System.EventHandler(this.btnCel_Click);
            // 
            // btnJuego
            // 
            this.btnJuego.FlatAppearance.BorderSize = 0;
            this.btnJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuego.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuego.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJuego.Image = ((System.Drawing.Image)(resources.GetObject("btnJuego.Image")));
            this.btnJuego.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJuego.Location = new System.Drawing.Point(12, 282);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(250, 51);
            this.btnJuego.TabIndex = 4;
            this.btnJuego.Text = "  Juegos";
            this.btnJuego.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJuego.UseVisualStyleBackColor = true;
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // btnCom
            // 
            this.btnCom.FlatAppearance.BorderSize = 0;
            this.btnCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCom.Image = ((System.Drawing.Image)(resources.GetObject("btnCom.Image")));
            this.btnCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCom.Location = new System.Drawing.Point(12, 153);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(240, 51);
            this.btnCom.TabIndex = 3;
            this.btnCom.Text = "   Computadoras";
            this.btnCom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(12, 64);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(240, 51);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "   Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panel2.Controls.Add(this.btncar);
            this.panel2.Controls.Add(this.lbNombre);
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btnmenubar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 37);
            this.panel2.TabIndex = 4;
            // 
            // btncar
            // 
            this.btncar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncar.FlatAppearance.BorderSize = 0;
            this.btncar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btncar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncar.Image = ((System.Drawing.Image)(resources.GetObject("btncar.Image")));
            this.btncar.Location = new System.Drawing.Point(623, -3);
            this.btncar.Name = "btncar";
            this.btncar.Size = new System.Drawing.Size(38, 39);
            this.btncar.TabIndex = 16;
            this.btncar.UseVisualStyleBackColor = true;
            this.btncar.Click += new System.EventHandler(this.btncar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(65, 9);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(57, 20);
            this.lbNombre.TabIndex = 15;
            this.lbNombre.Text = "label1";
            // 
            // btnsalir
            // 
            this.btnsalir.CausesValidation = false;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsalir.Location = new System.Drawing.Point(667, -3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(133, 37);
            this.btnsalir.TabIndex = 14;
            this.btnsalir.Text = "Cerrar Sesión";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnmenubar
            // 
            this.btnmenubar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenubar.FlatAppearance.BorderSize = 0;
            this.btnmenubar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenubar.Image = ((System.Drawing.Image)(resources.GetObject("btnmenubar.Image")));
            this.btnmenubar.Location = new System.Drawing.Point(0, 0);
            this.btnmenubar.Name = "btnmenubar";
            this.btnmenubar.Size = new System.Drawing.Size(40, 40);
            this.btnmenubar.TabIndex = 8;
            this.btnmenubar.TabStop = false;
            this.btnmenubar.UseVisualStyleBackColor = true;
            this.btnmenubar.Click += new System.EventHandler(this.btnmenubar_Click);
            // 
            // cuEjercicio1
            // 
            this.cuEjercicio1.BackColor = System.Drawing.SystemColors.Window;
            this.cuEjercicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuEjercicio1.Location = new System.Drawing.Point(262, 37);
            this.cuEjercicio1.Name = "cuEjercicio1";
            this.cuEjercicio1.Size = new System.Drawing.Size(538, 413);
            this.cuEjercicio1.TabIndex = 19;
            // 
            // cucelulares1
            // 
            this.cucelulares1.BackColor = System.Drawing.SystemColors.Window;
            this.cucelulares1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cucelulares1.Location = new System.Drawing.Point(262, 37);
            this.cucelulares1.Name = "cucelulares1";
            this.cucelulares1.Size = new System.Drawing.Size(538, 413);
            this.cucelulares1.TabIndex = 18;
            // 
            // cujuegos1
            // 
            this.cujuegos1.BackColor = System.Drawing.SystemColors.Window;
            this.cujuegos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cujuegos1.Location = new System.Drawing.Point(0, 0);
            this.cujuegos1.Name = "cujuegos1";
            this.cujuegos1.Size = new System.Drawing.Size(800, 450);
            this.cujuegos1.TabIndex = 7;
            this.cujuegos1.Load += new System.EventHandler(this.cujuegos1_Load);
            // 
            // cuinicio1
            // 
            this.cuinicio1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cuinicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuinicio1.Location = new System.Drawing.Point(0, 0);
            this.cuinicio1.Name = "cuinicio1";
            this.cuinicio1.Size = new System.Drawing.Size(800, 450);
            this.cuinicio1.TabIndex = 9;
            // 
            // cuelectrodomestico1
            // 
            this.cuelectrodomestico1.BackColor = System.Drawing.SystemColors.Window;
            this.cuelectrodomestico1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cuelectrodomestico1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuelectrodomestico1.Location = new System.Drawing.Point(0, 0);
            this.cuelectrodomestico1.Name = "cuelectrodomestico1";
            this.cuelectrodomestico1.Size = new System.Drawing.Size(800, 450);
            this.cuelectrodomestico1.TabIndex = 17;
            // 
            // cucom1
            // 
            this.cucom1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cucom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cucom1.Location = new System.Drawing.Point(0, 0);
            this.cucom1.Name = "cucom1";
            this.cucom1.Size = new System.Drawing.Size(800, 450);
            this.cucom1.TabIndex = 8;
            // 
            // da1
            // 
            this.da1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.da1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.da1.Location = new System.Drawing.Point(0, 0);
            this.da1.Name = "da1";
            this.da1.Size = new System.Drawing.Size(800, 450);
            this.da1.TabIndex = 16;
            // 
            // FormMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cuEjercicio1);
            this.Controls.Add(this.cucelulares1);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cujuegos1);
            this.Controls.Add(this.cuinicio1);
            this.Controls.Add(this.cuelectrodomestico1);
            this.Controls.Add(this.cucom1);
            this.Controls.Add(this.da1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMCliente";
            this.Load += new System.EventHandler(this.FormMCliente_Load);
            this.sidemenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnSalud;
        private System.Windows.Forms.Button btnEle;
        private System.Windows.Forms.Button btnCel;
        private System.Windows.Forms.Button btnJuego;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel2;
        private Cujuegos cujuegos1;
        private Cucom cucom1;
        private Cuinicio cuinicio1;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button btnmenubar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnsalir;
        private da da1;
        private System.Windows.Forms.Button btncar;
        private Cuelectrodomestico cuelectrodomestico1;
        private Cucelulares cucelulares1;
        private CuEjercicio cuEjercicio1;
    }
}