namespace JBTienda
{
    partial class MenuAgregarProducto
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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecio2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new System.Windows.Forms.OpenFileDialog();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboDesc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.ErrorCampos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(43, 69);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(277, 23);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Hint = "Descripcion";
            this.txtDescripcion.Location = new System.Drawing.Point(43, 107);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(277, 23);
            this.txtDescripcion.TabIndex = 35;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Hint = "Cantidad";
            this.txtCantidad.Location = new System.Drawing.Point(43, 166);
            this.txtCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.Size = new System.Drawing.Size(277, 23);
            this.txtCantidad.TabIndex = 37;
            this.txtCantidad.UseSystemPasswordChar = false;
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.BackColor = System.Drawing.Color.White;
            this.txtPrecio2.Depth = 0;
            this.txtPrecio2.Hint = "";
            this.txtPrecio2.Location = new System.Drawing.Point(43, 137);
            this.txtPrecio2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.PasswordChar = '\0';
            this.txtPrecio2.SelectedText = "";
            this.txtPrecio2.SelectionLength = 0;
            this.txtPrecio2.SelectionStart = 0;
            this.txtPrecio2.Size = new System.Drawing.Size(84, 23);
            this.txtPrecio2.TabIndex = 36;
            this.txtPrecio2.Text = "Precio";
            this.txtPrecio2.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "Agregar Producto";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.Location = new System.Drawing.Point(43, 432);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Primary = true;
            this.btnRegistrar.Size = new System.Drawing.Size(286, 30);
            this.btnRegistrar.TabIndex = 40;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.txtRegistrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FileName = "openFileDialog1";
            // 
            // pic1
            // 
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic1.Location = new System.Drawing.Point(44, 236);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(204, 182);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 41;
            this.pic1.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Depth = 0;
            this.btnExaminar.Location = new System.Drawing.Point(254, 236);
            this.btnExaminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Primary = true;
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 42;
            this.btnExaminar.Text = "EXAMINAR";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // cboDesc
            // 
            this.cboDesc.FormattingEnabled = true;
            this.cboDesc.Location = new System.Drawing.Point(141, 196);
            this.cboDesc.Name = "cboDesc";
            this.cboDesc.Size = new System.Drawing.Size(179, 21);
            this.cboDesc.TabIndex = 43;
            this.cboDesc.SelectedIndexChanged += new System.EventHandler(this.cboDesc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(40, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Descuento";
            // 
            // lblId
            // 
            this.lblId.Depth = 0;
            this.lblId.Hint = "ID";
            this.lblId.Location = new System.Drawing.Point(338, 196);
            this.lblId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblId.Name = "lblId";
            this.lblId.PasswordChar = '\0';
            this.lblId.SelectedText = "";
            this.lblId.SelectionLength = 0;
            this.lblId.SelectionStart = 0;
            this.lblId.Size = new System.Drawing.Size(29, 23);
            this.lblId.TabIndex = 45;
            this.lblId.UseSystemPasswordChar = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(141, 140);
            this.txtPrecio.Mask = "99999$";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(89, 20);
            this.txtPrecio.TabIndex = 46;
            this.txtPrecio.ValidatingType = typeof(int);
            // 
            // ErrorCampos
            // 
            this.ErrorCampos.ContainerControl = this;
            // 
            // MenuAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDesc);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Name = "MenuAgregarProducto";
            this.Size = new System.Drawing.Size(370, 529);
            this.Load += new System.EventHandler(this.da_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrar;
        private System.Windows.Forms.OpenFileDialog btnBuscar;
        private System.Windows.Forms.PictureBox pic1;
        private MaterialSkin.Controls.MaterialRaisedButton btnExaminar;
        private System.Windows.Forms.ComboBox cboDesc;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblId;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.ErrorProvider ErrorCampos;
    }
}
