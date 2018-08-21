namespace JBTienda
{
    partial class dm
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
            this.lblId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDesc = new System.Windows.Forms.ComboBox();
            this.btnExaminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lstModificar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Depth = 0;
            this.lblId.Hint = "ID";
            this.lblId.Location = new System.Drawing.Point(491, 183);
            this.lblId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblId.Name = "lblId";
            this.lblId.PasswordChar = '\0';
            this.lblId.SelectedText = "";
            this.lblId.SelectionLength = 0;
            this.lblId.SelectionStart = 0;
            this.lblId.Size = new System.Drawing.Size(29, 23);
            this.lblId.TabIndex = 56;
            this.lblId.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(193, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Descuento";
            // 
            // cboDesc
            // 
            this.cboDesc.FormattingEnabled = true;
            this.cboDesc.Location = new System.Drawing.Point(294, 186);
            this.cboDesc.Name = "cboDesc";
            this.cboDesc.Size = new System.Drawing.Size(179, 21);
            this.cboDesc.TabIndex = 54;
            this.cboDesc.SelectedIndexChanged += new System.EventHandler(this.cboDesc_SelectedIndexChanged);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Depth = 0;
            this.btnExaminar.Location = new System.Drawing.Point(407, 226);
            this.btnExaminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Primary = true;
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 53;
            this.btnExaminar.Text = "EXAMINAR";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(197, 226);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(204, 182);
            this.pic1.TabIndex = 52;
            this.pic1.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(196, 429);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(286, 23);
            this.btnModificar.TabIndex = 51;
            this.btnModificar.Text = "Registrar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(189, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 50;
            this.label1.Text = "Modificar Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Hint = "Cantidad";
            this.txtCantidad.Location = new System.Drawing.Point(196, 156);
            this.txtCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.Size = new System.Drawing.Size(277, 23);
            this.txtCantidad.TabIndex = 49;
            this.txtCantidad.UseSystemPasswordChar = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Hint = "Precio";
            this.txtPrecio.Location = new System.Drawing.Point(196, 127);
            this.txtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.Size = new System.Drawing.Size(277, 23);
            this.txtPrecio.TabIndex = 48;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Hint = "Descripcion";
            this.txtDescripcion.Location = new System.Drawing.Point(196, 97);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(277, 23);
            this.txtDescripcion.TabIndex = 47;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(196, 59);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(277, 23);
            this.txtNombre.TabIndex = 46;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            this.txtId.Depth = 0;
            this.txtId.Hint = "ID";
            this.txtId.Location = new System.Drawing.Point(138, 245);
            this.txtId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.Size = new System.Drawing.Size(29, 23);
            this.txtId.TabIndex = 58;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // lstModificar
            // 
            this.lstModificar.FormattingEnabled = true;
            this.lstModificar.Location = new System.Drawing.Point(16, 25);
            this.lstModificar.Name = "lstModificar";
            this.lstModificar.Size = new System.Drawing.Size(151, 160);
            this.lstModificar.TabIndex = 59;
            this.lstModificar.Click += new System.EventHandler(this.lstModificar_Click);
            this.lstModificar.SelectedIndexChanged += new System.EventHandler(this.lstModificar_SelectedIndexChanged);
            // 
            // dm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lstModificar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDesc);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "dm";
            this.Size = new System.Drawing.Size(521, 456);
            this.Load += new System.EventHandler(this.dm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDesc;
        private MaterialSkin.Controls.MaterialRaisedButton btnExaminar;
        private System.Windows.Forms.PictureBox pic1;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtId;
        private System.Windows.Forms.ListBox lstModificar;
    }
}
