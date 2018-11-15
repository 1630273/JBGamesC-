using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JBTienda
{
    public partial class MenuModificarProducto : MaterialSkin.Controls.MaterialForm
    {
        public MenuModificarProducto()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

        }

        //// Se crea el OpenFileDialog
        OpenFileDialog dialog = new OpenFileDialog();
        //// Se muestra al usuario esperando una acción
        public DialogResult result; 

        private void btnExaminar_Click_1(object sender, EventArgs e)
        {

            result = dialog.ShowDialog();
            //// Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            //// la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pic1.Image = Image.FromFile(dialog.FileName);
            }

        }

        private void FormModificarP_Load(object sender, EventArgs e)
        {
            cargarProducto(Variables.idProd);
            cargarDescuentos();
            listarProductos();
        }




        void cargarDescuentos()
        {



            dcTiendaDataContext dc = new dcTiendaDataContext();
            var carreras = from c in dc.CargarDescuentos()
                           select new { c.idDescuento, c.descuento };

            cboDesc.DataSource = carreras.ToList();
            cboDesc.ValueMember = "idDescuento";
            cboDesc.DisplayMember = "descuento";


        }

        void cargarProducto(byte idProducto)
        {


            dcTiendaDataContext pro = new dcTiendaDataContext();
            var datosProducto = from con in pro.consultarDatosProductos2(idProducto)
                                select con;

            foreach (var c in datosProducto)
            {

                lblId.Text = c.idProducto.ToString();
                txtNombre.Text = c.nombreProducto;
                txtDescripcion.Text = c.descripcion;
                txtPrecio.Text = c.precio.ToString();
                txtCantidad.Text = c.cantidad.ToString();
                cboDesc.Text = c.idDescuento.ToString();
                //pic1.Image = c.imagen;


            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipalGerente p = new MenuPrincipalGerente();
            p.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {



            try
            {
                // Objetos de conexión y comando
                SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=LAPTOP-LN2ROB9J\\SQLEXPRESS01;Initial Catalog=Tienda;Integrated Security=True");
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                BorrarMensajes();

                if (ValidarCampos())
                {


                    // Estableciento propiedades
                    cmd.Connection = conn;

                    cmd.CommandText = "UPDATE Producto SET nombreProducto = @nomPro , descripcion = @descripcion,precio = @precio,cantidad = @cant ,imagen = @imagen,idDescuento = @desc WHERE idProducto = @idPro";
                    conn.Open();
                    // Creando los parámetros necesarios
                    cmd.Parameters.Add("@nomPro", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@descripcion", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@precio", System.Data.SqlDbType.Money);
                    cmd.Parameters.Add("@cant", System.Data.SqlDbType.TinyInt);
                    cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image);
                    cmd.Parameters.Add("@desc", System.Data.SqlDbType.TinyInt);
                    cmd.Parameters.Add("@idPro", System.Data.SqlDbType.TinyInt);

                    // Asignando los valores a los atributos
                    cmd.Parameters["@nomPro"].Value = txtNombre.Text;
                    cmd.Parameters["@descripcion"].Value = txtDescripcion.Text;
                    cmd.Parameters["@precio"].Value = int.Parse(txtPrecio.Text);
                    cmd.Parameters["@cant"].Value = int.Parse(txtCantidad.Text);
                    cmd.Parameters["@desc"].Value = txtId.Text;
                    cmd.Parameters["@idPro"].Value = lblId.Text;

                    // Asignando el valor de la imagen

                    // Stream usado como buffer
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    pic1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    // Se extraen los bytes del buffer para asignarlos como valor para el 
                    // parámetro.
                    cmd.Parameters["@imagen"].Value = ms.GetBuffer();

                    MessageBox.Show("Producto Modificado");

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            catch (System.Exception)
            {
                MessageBox.Show("Fallo en la conexion en AgregarProductos");
                //MenuIniciarSesion ir = new MenuIniciarSesion();
                //ir.Show();
                //this.Hide();
            }

        }

        private void listarProductos()
        {


            
                System.Data.DataSet ds = new System.Data.DataSet();
                System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("SELECT imagen FROM Producto WHERE idProducto = @idPro", "Data Source=LAPTOP-LN2ROB9J\\SQLEXPRESS01;Initial Catalog=Tienda;Integrated Security=True");

                da.SelectCommand.Parameters.Add("@idPro", System.Data.SqlDbType.TinyInt);
                da.SelectCommand.Parameters["@idPro"].Value = lblId.Text;

                // Se recuperan los datos
                da.Fill(ds, "Producto");




                // El campo productImage primero se almacena en un buffer
                byte[] imageBuffer = (byte[])ds.Tables["Producto"].Rows[0]["imagen"];
                // Se crea un MemoryStream a partir de ese buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                // Se utiliza el MemoryStream para extraer la imagen
                pic1.Image = Image.FromStream(ms);

            
          

        }

      

        private void cboDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = cboDesc.SelectedValue.ToString();
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            int num;

            if (txtNombre.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtNombre, "Campo Vacio, Ingrese Nombre");
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtDescripcion, "Campo Vacio, Ingrese Descripcion");
            }


            if (txtPrecio.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtPrecio, "Campo Vacio, Ingrese Precio");
            }
            else if(!int.TryParse(txtPrecio.Text, out num))
            {
                ok = false;
                ErrorCampos.SetError(txtPrecio, "Formato Incorrecto, Ingrese solo numeros");

            }

            if (txtCantidad.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtCantidad, "Campo Vacio, Ingrese una Cantidad");
            }


            else if (!int.TryParse(txtCantidad.Text, out num))
            {
                ok = false;
                ErrorCampos.SetError(txtCantidad, "Formato incorrecto, Ingrese solo numeros");
            }

      



            return ok;

        }

        //Metodo para borrar los mensajes cuando ya esten correctos
        private void BorrarMensajes()
        {


            ErrorCampos.SetError(txtNombre, "");
            ErrorCampos.SetError(txtDescripcion, "");
            ErrorCampos.SetError(txtPrecio, "");
            ErrorCampos.SetError(txtCantidad, "");
     

        }
    }
}
