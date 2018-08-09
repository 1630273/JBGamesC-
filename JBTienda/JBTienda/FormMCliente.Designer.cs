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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMCliente));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnSalud = new System.Windows.Forms.Button();
            this.btnEle = new System.Windows.Forms.Button();
            this.btnCel = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnmenubar = new System.Windows.Forms.Button();
            this.LogoAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.cujuegos1 = new JBTienda.Cujuegos();
            this.cuinicio1 = new JBTienda.Cuinicio();
            this.cucom1 = new JBTienda.Cucom();
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
            this.PanelAnimation.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
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
            this.PanelAnimation.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Location = new System.Drawing.Point(3, 11);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(159, 46);
            this.logo.TabIndex = 9;
            this.logo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.PanelAnimation.SetDecoration(this.SidePanel, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.SidePanel, BunifuAnimatorNS.DecorationType.None);
            this.SidePanel.Location = new System.Drawing.Point(2, 63);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 51);
            this.SidePanel.TabIndex = 3;
            // 
            // btnSalud
            // 
            this.LogoAnimation.SetDecoration(this.btnSalud, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.btnSalud, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimation.SetDecoration(this.btnEle, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.btnEle, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimation.SetDecoration(this.btnCel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.btnCel, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimation.SetDecoration(this.btnJuego, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.btnJuego, BunifuAnimatorNS.DecorationType.None);
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
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // btnCom
            // 
            this.LogoAnimation.SetDecoration(this.btnCom, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.btnCom, BunifuAnimatorNS.DecorationType.None);
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
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnInicio
            // 
            this.LogoAnimation.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.LogoAnimation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(700, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carrito";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnmenubar);
            this.PanelAnimation.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 37);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.LogoAnimation.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoAnimation.SetDecoration(this.btnmenubar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.btnmenubar, BunifuAnimatorNS.DecorationType.None);
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
            // LogoAnimation
            // 
            this.LogoAnimation.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlideAndRotate;
            this.LogoAnimation.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 0.3F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.LogoAnimation.DefaultAnimation = animation2;
            // 
            // PanelAnimation
            // 
            this.PanelAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimation.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimation.DefaultAnimation = animation1;
            // 
            // cujuegos1
            // 
            this.LogoAnimation.SetDecoration(this.cujuegos1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.cujuegos1, BunifuAnimatorNS.DecorationType.None);
            this.cujuegos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cujuegos1.Location = new System.Drawing.Point(0, 37);
            this.cujuegos1.Name = "cujuegos1";
            this.cujuegos1.Size = new System.Drawing.Size(800, 413);
            this.cujuegos1.TabIndex = 7;
            // 
            // cuinicio1
            // 
            this.LogoAnimation.SetDecoration(this.cuinicio1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.cuinicio1, BunifuAnimatorNS.DecorationType.None);
            this.cuinicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuinicio1.Location = new System.Drawing.Point(0, 0);
            this.cuinicio1.Name = "cuinicio1";
            this.cuinicio1.Size = new System.Drawing.Size(800, 450);
            this.cuinicio1.TabIndex = 9;
            // 
            // cucom1
            // 
            this.LogoAnimation.SetDecoration(this.cucom1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this.cucom1, BunifuAnimatorNS.DecorationType.None);
            this.cucom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cucom1.Location = new System.Drawing.Point(0, 0);
            this.cucom1.Name = "cucom1";
            this.cucom1.Size = new System.Drawing.Size(800, 450);
            this.cucom1.TabIndex = 8;
            // 
            // FormMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.cujuegos1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cuinicio1);
            this.Controls.Add(this.cucom1);
            this.LogoAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMCliente";
            this.Text = "FormMCliente";
            this.sidemenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Cujuegos cujuegos1;
        private Cucom cucom1;
        private Cuinicio cuinicio1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel logo;
        private BunifuAnimatorNS.BunifuTransition LogoAnimation;
        private BunifuAnimatorNS.BunifuTransition PanelAnimation;
        private System.Windows.Forms.Button btnmenubar;
    }
}