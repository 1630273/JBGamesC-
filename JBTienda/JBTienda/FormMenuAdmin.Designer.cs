namespace JBTienda
{
    partial class FormMenuAdmin
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
            BunifuAnimatorNS.Animation animation23 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdmin));
            BunifuAnimatorNS.Animation animation24 = new BunifuAnimatorNS.Animation();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnmenubar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnSalud = new System.Windows.Forms.Button();
            this.btnEle = new System.Windows.Forms.Button();
            this.btnCel = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.LogoAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ainicio1 = new JBTienda.Ainicio();
            this.ajuegos1 = new JBTienda.Ajuegos();
            this.ael1 = new JBTienda.Ael();
            this.aej1 = new JBTienda.Aej();
            this.acom1 = new JBTienda.Acom();
            this.ac1 = new JBTienda.Ac();
            this.panel2.SuspendLayout();
            this.sidemenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnmenubar);
            this.panel2.Controls.Add(this.label2);
            this.LogoAnimation.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 37);
            this.panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.PanelAnimation.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(769, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 21);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmenubar
            // 
            this.btnmenubar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimation.SetDecoration(this.btnmenubar, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.btnmenubar, BunifuAnimatorNS.DecorationType.None);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.PanelAnimation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(522, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carrito";
            // 
            // PanelAnimation
            // 
            this.PanelAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimation.Cursor = null;
            animation23.AnimateOnlyDifferences = true;
            animation23.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.BlindCoeff")));
            animation23.LeafCoeff = 0F;
            animation23.MaxTime = 1F;
            animation23.MinTime = 0F;
            animation23.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.MosaicCoeff")));
            animation23.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation23.MosaicShift")));
            animation23.MosaicSize = 1;
            animation23.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation23.RotateCoeff = 0F;
            animation23.RotateLimit = 0F;
            animation23.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.ScaleCoeff")));
            animation23.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.SlideCoeff")));
            animation23.TimeCoeff = 2F;
            animation23.TransparencyCoeff = 0F;
            this.PanelAnimation.DefaultAnimation = animation23;
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
            this.LogoAnimation.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.Custom);
            this.PanelAnimation.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.Custom);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 37);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(262, 413);
            this.sidemenu.TabIndex = 9;
            this.sidemenu.TabStop = true;
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.LogoAnimation.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Location = new System.Drawing.Point(3, 11);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(159, 46);
            this.logo.TabIndex = 9;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.LogoAnimation.SetDecoration(this.SidePanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.SidePanel, BunifuAnimatorNS.DecorationType.None);
            this.SidePanel.Location = new System.Drawing.Point(2, 63);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 51);
            this.SidePanel.TabIndex = 3;
            // 
            // btnSalud
            // 
            this.PanelAnimation.SetDecoration(this.btnSalud, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.btnSalud, BunifuAnimatorNS.DecorationType.None);
            this.btnSalud.FlatAppearance.BorderSize = 0;
            this.btnSalud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnSalud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalud.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalud.Image = ((System.Drawing.Image)(resources.GetObject("btnSalud.Image")));
            this.btnSalud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalud.Location = new System.Drawing.Point(12, 293);
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
            this.PanelAnimation.SetDecoration(this.btnEle, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.btnEle, BunifuAnimatorNS.DecorationType.None);
            this.btnEle.FlatAppearance.BorderSize = 0;
            this.btnEle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnEle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEle.Image = ((System.Drawing.Image)(resources.GetObject("btnEle.Image")));
            this.btnEle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEle.Location = new System.Drawing.Point(12, 244);
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
            this.PanelAnimation.SetDecoration(this.btnCel, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.btnCel, BunifuAnimatorNS.DecorationType.None);
            this.btnCel.FlatAppearance.BorderSize = 0;
            this.btnCel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCel.Image = ((System.Drawing.Image)(resources.GetObject("btnCel.Image")));
            this.btnCel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCel.Location = new System.Drawing.Point(12, 197);
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
            this.PanelAnimation.SetDecoration(this.btnJuego, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.btnJuego, BunifuAnimatorNS.DecorationType.None);
            this.btnJuego.FlatAppearance.BorderSize = 0;
            this.btnJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuego.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuego.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJuego.Image = ((System.Drawing.Image)(resources.GetObject("btnJuego.Image")));
            this.btnJuego.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJuego.Location = new System.Drawing.Point(12, 152);
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
            this.PanelAnimation.SetDecoration(this.btnCom, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.btnCom, BunifuAnimatorNS.DecorationType.None);
            this.btnCom.FlatAppearance.BorderSize = 0;
            this.btnCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCom.Image = ((System.Drawing.Image)(resources.GetObject("btnCom.Image")));
            this.btnCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCom.Location = new System.Drawing.Point(12, 108);
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
            this.PanelAnimation.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
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
            // LogoAnimation
            // 
            this.LogoAnimation.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlideAndRotate;
            this.LogoAnimation.Cursor = null;
            animation24.AnimateOnlyDifferences = true;
            animation24.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.BlindCoeff")));
            animation24.LeafCoeff = 0F;
            animation24.MaxTime = 1F;
            animation24.MinTime = 0F;
            animation24.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.MosaicCoeff")));
            animation24.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation24.MosaicShift")));
            animation24.MosaicSize = 0;
            animation24.Padding = new System.Windows.Forms.Padding(50);
            animation24.RotateCoeff = 0.3F;
            animation24.RotateLimit = 0.2F;
            animation24.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.ScaleCoeff")));
            animation24.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.SlideCoeff")));
            animation24.TimeCoeff = 0F;
            animation24.TransparencyCoeff = 0F;
            this.LogoAnimation.DefaultAnimation = animation24;
            // 
            // ainicio1
            // 
            this.PanelAnimation.SetDecoration(this.ainicio1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.ainicio1, BunifuAnimatorNS.DecorationType.None);
            this.ainicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ainicio1.Location = new System.Drawing.Point(262, 37);
            this.ainicio1.Name = "ainicio1";
            this.ainicio1.Size = new System.Drawing.Size(538, 413);
            this.ainicio1.TabIndex = 12;
            // 
            // ajuegos1
            // 
            this.ajuegos1.BackColor = System.Drawing.Color.White;
            this.PanelAnimation.SetDecoration(this.ajuegos1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.ajuegos1, BunifuAnimatorNS.DecorationType.None);
            this.ajuegos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajuegos1.Location = new System.Drawing.Point(262, 37);
            this.ajuegos1.Name = "ajuegos1";
            this.ajuegos1.Size = new System.Drawing.Size(538, 413);
            this.ajuegos1.TabIndex = 13;
            // 
            // ael1
            // 
            this.PanelAnimation.SetDecoration(this.ael1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.ael1, BunifuAnimatorNS.DecorationType.None);
            this.ael1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ael1.Location = new System.Drawing.Point(262, 37);
            this.ael1.Name = "ael1";
            this.ael1.Size = new System.Drawing.Size(538, 413);
            this.ael1.TabIndex = 14;
            // 
            // aej1
            // 
            this.PanelAnimation.SetDecoration(this.aej1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.aej1, BunifuAnimatorNS.DecorationType.None);
            this.aej1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aej1.Location = new System.Drawing.Point(262, 37);
            this.aej1.Name = "aej1";
            this.aej1.Size = new System.Drawing.Size(538, 413);
            this.aej1.TabIndex = 15;
            // 
            // acom1
            // 
            this.acom1.BackColor = System.Drawing.Color.White;
            this.PanelAnimation.SetDecoration(this.acom1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.acom1, BunifuAnimatorNS.DecorationType.None);
            this.acom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acom1.Location = new System.Drawing.Point(0, 0);
            this.acom1.Name = "acom1";
            this.acom1.Size = new System.Drawing.Size(800, 450);
            this.acom1.TabIndex = 16;
            // 
            // ac1
            // 
            this.PanelAnimation.SetDecoration(this.ac1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.ac1, BunifuAnimatorNS.DecorationType.None);
            this.ac1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ac1.Location = new System.Drawing.Point(0, 0);
            this.ac1.Name = "ac1";
            this.ac1.Size = new System.Drawing.Size(800, 450);
            this.ac1.TabIndex = 17;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aej1);
            this.Controls.Add(this.ael1);
            this.Controls.Add(this.ajuegos1);
            this.Controls.Add(this.ainicio1);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ac1);
            this.Controls.Add(this.acom1);
            this.PanelAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuAdmin";
            this.Load += new System.EventHandler(this.FormMenuAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sidemenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnmenubar;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition PanelAnimation;
        private BunifuAnimatorNS.BunifuTransition LogoAnimation;
        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnSalud;
        private System.Windows.Forms.Button btnEle;
        private System.Windows.Forms.Button btnCel;
        private System.Windows.Forms.Button btnJuego;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnInicio;
        private Ainicio ainicio1;
        private Ajuegos ajuegos1;
        private Ael ael1;
        private Aej aej1;
        private Acom acom1;
        private Ac ac1;
    }
}