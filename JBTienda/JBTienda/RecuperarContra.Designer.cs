namespace JBTienda
{
    partial class RecuperarContra
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
            this.txtRecuperar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // txtRecuperar
            // 
            this.txtRecuperar.Depth = 0;
            this.txtRecuperar.Location = new System.Drawing.Point(360, 81);
            this.txtRecuperar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRecuperar.Name = "txtRecuperar";
            this.txtRecuperar.Primary = true;
            this.txtRecuperar.Size = new System.Drawing.Size(105, 23);
            this.txtRecuperar.TabIndex = 0;
            this.txtRecuperar.Text = "Recuperar";
            this.txtRecuperar.UseVisualStyleBackColor = true;
            this.txtRecuperar.Click += new System.EventHandler(this.txtRecuperar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(73, 85);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Ingrese ID.";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(77, 144);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(228, 75);
            this.txtMensaje.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Depth = 0;
            this.txtId.Hint = "";
            this.txtId.Location = new System.Drawing.Point(159, 85);
            this.txtId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.Size = new System.Drawing.Size(132, 23);
            this.txtId.TabIndex = 4;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // RecuperarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtRecuperar);
            this.Name = "RecuperarContra";
            this.Text = "RecuperarContra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton txtRecuperar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtMensaje;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtId;
    }
}