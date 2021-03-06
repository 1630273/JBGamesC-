﻿namespace JBTienda
{
    partial class MenuPrincipalGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalGerente));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmenubar = new System.Windows.Forms.Button();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnel = new System.Windows.Forms.Button();
            this.btnmo = new System.Windows.Forms.Button();
            this.btnAg = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.da1 = new JBTienda.MenuAgregarProducto();
            this.de1 = new JBTienda.MenuEliminarProducto();
            this.di1 = new JBTienda.RegistrarProducto();
            this.dm1 = new JBTienda.MenuModificarP();
            this.panel2.SuspendLayout();
            this.sidemenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btnmenubar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 37);
            this.panel2.TabIndex = 7;
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
            this.btnHelp.Location = new System.Drawing.Point(631, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(28, 32);
            this.btnHelp.TabIndex = 38;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(67, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 20);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "label1";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
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
            this.btnsalir.Location = new System.Drawing.Point(665, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(133, 37);
            this.btnsalir.TabIndex = 9;
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
            this.sidemenu.Controls.Add(this.btnel);
            this.sidemenu.Controls.Add(this.btnmo);
            this.sidemenu.Controls.Add(this.btnAg);
            this.sidemenu.Controls.Add(this.btnInicio);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 37);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(189, 480);
            this.sidemenu.TabIndex = 8;
            this.sidemenu.TabStop = true;
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
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // btnel
            // 
            this.btnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnel.FlatAppearance.BorderSize = 0;
            this.btnel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnel.Image = ((System.Drawing.Image)(resources.GetObject("btnel.Image")));
            this.btnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnel.Location = new System.Drawing.Point(12, 189);
            this.btnel.Name = "btnel";
            this.btnel.Size = new System.Drawing.Size(177, 51);
            this.btnel.TabIndex = 5;
            this.btnel.Text = "   Eliminar";
            this.btnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnel.UseVisualStyleBackColor = true;
            this.btnel.Click += new System.EventHandler(this.btnel_Click);
            // 
            // btnmo
            // 
            this.btnmo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmo.FlatAppearance.BorderSize = 0;
            this.btnmo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmo.Image = ((System.Drawing.Image)(resources.GetObject("btnmo.Image")));
            this.btnmo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmo.Location = new System.Drawing.Point(12, 150);
            this.btnmo.Name = "btnmo";
            this.btnmo.Size = new System.Drawing.Size(177, 51);
            this.btnmo.TabIndex = 4;
            this.btnmo.Text = "  Modificar";
            this.btnmo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmo.UseVisualStyleBackColor = true;
            this.btnmo.Click += new System.EventHandler(this.btnmo_Click);
            // 
            // btnAg
            // 
            this.btnAg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAg.FlatAppearance.BorderSize = 0;
            this.btnAg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnAg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAg.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAg.Image = ((System.Drawing.Image)(resources.GetObject("btnAg.Image")));
            this.btnAg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAg.Location = new System.Drawing.Point(12, 108);
            this.btnAg.Name = "btnAg";
            this.btnAg.Size = new System.Drawing.Size(177, 51);
            this.btnAg.TabIndex = 3;
            this.btnAg.Text = "  Agregar";
            this.btnAg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAg.UseVisualStyleBackColor = true;
            this.btnAg.Click += new System.EventHandler(this.btnAg_Click);
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
            this.btnInicio.Size = new System.Drawing.Size(177, 51);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "   Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // da1
            // 
            this.da1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.da1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.da1.Location = new System.Drawing.Point(189, 37);
            this.da1.Name = "da1";
            this.da1.Size = new System.Drawing.Size(611, 480);
            this.da1.TabIndex = 13;
            this.da1.Load += new System.EventHandler(this.da1_Load);
            // 
            // de1
            // 
            this.de1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.de1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.de1.Location = new System.Drawing.Point(0, 0);
            this.de1.Name = "de1";
            this.de1.Size = new System.Drawing.Size(800, 517);
            this.de1.TabIndex = 10;
            // 
            // di1
            // 
            this.di1.BackColor = System.Drawing.Color.White;
            this.di1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.di1.Location = new System.Drawing.Point(0, 0);
            this.di1.Name = "di1";
            this.di1.Size = new System.Drawing.Size(800, 517);
            this.di1.TabIndex = 9;
            // 
            // dm1
            // 
            this.dm1.BackColor = System.Drawing.Color.White;
            this.dm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dm1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dm1.Location = new System.Drawing.Point(0, 0);
            this.dm1.Name = "dm1";
            this.dm1.Size = new System.Drawing.Size(800, 517);
            this.dm1.TabIndex = 12;
            // 
            // MenuPrincipalGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.da1);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.de1);
            this.Controls.Add(this.di1);
            this.Controls.Add(this.dm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MenuPrincipalGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMenuJ_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuPrincipalGerente_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sidemenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnmenubar;
        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnel;
        private System.Windows.Forms.Button btnmo;
        private System.Windows.Forms.Button btnAg;
        private System.Windows.Forms.Button btnInicio;
        private RegistrarProducto di1;
        private MenuEliminarProducto de1;
        private MenuModificarP dm1;
        private MenuAgregarProducto da1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnHelp;
    }
}