namespace JBTienda
{
    partial class MenuPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalAdmin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmenubar = new System.Windows.Forms.Button();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnSalud = new System.Windows.Forms.Button();
            this.btnEle = new System.Windows.Forms.Button();
            this.btnCel = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.aej1 = new JBTienda.RegistrarJefeGym();
            this.ael1 = new JBTienda.RegistrarJefeElec();
            this.ajuegos1 = new JBTienda.RegistrarJefeJuegos();
            this.ainicio1 = new JBTienda.MenuInicioAdmin();
            this.ac1 = new JBTienda.RegistrarJefeCelular();
            this.acom1 = new JBTienda.RegistrarJefeCom();
            this.panel2.SuspendLayout();
            this.sidemenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btnmenubar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 37);
            this.panel2.TabIndex = 6;
            this.panel2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panel2_PreviewKeyDown);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHelp.Location = new System.Drawing.Point(633, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(28, 32);
            this.btnHelp.TabIndex = 37;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsalir.Location = new System.Drawing.Point(667, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(133, 34);
            this.btnsalir.TabIndex = 10;
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
            this.sidemenu.TabIndex = 9;
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
            this.btnSalud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalud.FlatAppearance.BorderSize = 0;
            this.btnSalud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnSalud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalud.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalud.Image = ((System.Drawing.Image)(resources.GetObject("btnSalud.Image")));
            this.btnSalud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalud.Location = new System.Drawing.Point(12, 213);
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
            this.btnEle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEle.FlatAppearance.BorderSize = 0;
            this.btnEle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnEle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEle.Image = ((System.Drawing.Image)(resources.GetObject("btnEle.Image")));
            this.btnEle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEle.Location = new System.Drawing.Point(12, 260);
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
            this.btnCel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCel.FlatAppearance.BorderSize = 0;
            this.btnCel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCel.Image = ((System.Drawing.Image)(resources.GetObject("btnCel.Image")));
            this.btnCel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCel.Location = new System.Drawing.Point(12, 116);
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
            this.btnJuego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJuego.FlatAppearance.BorderSize = 0;
            this.btnJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuego.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuego.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJuego.Image = ((System.Drawing.Image)(resources.GetObject("btnJuego.Image")));
            this.btnJuego.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJuego.Location = new System.Drawing.Point(12, 305);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(240, 51);
            this.btnJuego.TabIndex = 4;
            this.btnJuego.Text = "  Juegos";
            this.btnJuego.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJuego.UseVisualStyleBackColor = true;
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click_1);
            // 
            // btnCom
            // 
            this.btnCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCom.FlatAppearance.BorderSize = 0;
            this.btnCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCom.Image = ((System.Drawing.Image)(resources.GetObject("btnCom.Image")));
            this.btnCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCom.Location = new System.Drawing.Point(12, 160);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(240, 51);
            this.btnCom.TabIndex = 3;
            this.btnCom.Text = "   Computadoras";
            this.btnCom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click_1);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAyuda.Location = new System.Drawing.Point(386, 209);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(28, 32);
            this.btnAyuda.TabIndex = 37;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // aej1
            // 
            this.aej1.BackColor = System.Drawing.Color.White;
            this.aej1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aej1.Location = new System.Drawing.Point(262, 37);
            this.aej1.Name = "aej1";
            this.aej1.Size = new System.Drawing.Size(538, 413);
            this.aej1.TabIndex = 15;
            this.aej1.Load += new System.EventHandler(this.aej1_Load);
            this.aej1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aej1_KeyDown);
            // 
            // ael1
            // 
            this.ael1.BackColor = System.Drawing.Color.White;
            this.ael1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ael1.Location = new System.Drawing.Point(262, 37);
            this.ael1.Name = "ael1";
            this.ael1.Size = new System.Drawing.Size(538, 413);
            this.ael1.TabIndex = 14;
            // 
            // ajuegos1
            // 
            this.ajuegos1.BackColor = System.Drawing.Color.White;
            this.ajuegos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajuegos1.Location = new System.Drawing.Point(262, 37);
            this.ajuegos1.Name = "ajuegos1";
            this.ajuegos1.Size = new System.Drawing.Size(538, 413);
            this.ajuegos1.TabIndex = 13;
            // 
            // ainicio1
            // 
            this.ainicio1.BackColor = System.Drawing.Color.White;
            this.ainicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ainicio1.Location = new System.Drawing.Point(262, 37);
            this.ainicio1.Name = "ainicio1";
            this.ainicio1.Size = new System.Drawing.Size(538, 413);
            this.ainicio1.TabIndex = 12;
            // 
            // ac1
            // 
            this.ac1.BackColor = System.Drawing.Color.White;
            this.ac1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ac1.Location = new System.Drawing.Point(0, 0);
            this.ac1.Name = "ac1";
            this.ac1.Size = new System.Drawing.Size(800, 450);
            this.ac1.TabIndex = 17;
            // 
            // acom1
            // 
            this.acom1.BackColor = System.Drawing.Color.White;
            this.acom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acom1.Location = new System.Drawing.Point(0, 0);
            this.acom1.Name = "acom1";
            this.acom1.Size = new System.Drawing.Size(800, 450);
            this.acom1.TabIndex = 16;
            // 
            // MenuPrincipalAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.aej1);
            this.Controls.Add(this.ael1);
            this.Controls.Add(this.ajuegos1);
            this.Controls.Add(this.ainicio1);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ac1);
            this.Controls.Add(this.acom1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "MenuPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuAdmin";
            this.Load += new System.EventHandler(this.FormMenuAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.sidemenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnmenubar;
  
        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnSalud;
        private System.Windows.Forms.Button btnEle;
        private System.Windows.Forms.Button btnCel;
        private System.Windows.Forms.Button btnJuego;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnInicio;
        private MenuInicioAdmin ainicio1;
        private RegistrarJefeJuegos ajuegos1;
        private RegistrarJefeElec ael1;
        private RegistrarJefeGym aej1;
        private RegistrarJefeCom acom1;
        private RegistrarJefeCelular ac1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAyuda;
    }
}