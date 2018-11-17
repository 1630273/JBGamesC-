namespace JBTienda
{
    partial class Cuinicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuinicio));
            this.btnOferta1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOferta1
            // 
            this.btnOferta1.BackColor = System.Drawing.Color.Transparent;
            this.btnOferta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOferta1.FlatAppearance.BorderSize = 0;
            this.btnOferta1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOferta1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOferta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOferta1.Image = ((System.Drawing.Image)(resources.GetObject("btnOferta1.Image")));
            this.btnOferta1.Location = new System.Drawing.Point(13, 16);
            this.btnOferta1.Name = "btnOferta1";
            this.btnOferta1.Size = new System.Drawing.Size(308, 157);
            this.btnOferta1.TabIndex = 35;
            this.btnOferta1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(167, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 157);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Cuinicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOferta1);
            this.Name = "Cuinicio";
            this.Size = new System.Drawing.Size(496, 362);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOferta1;
        private System.Windows.Forms.Button button1;
    }
}
