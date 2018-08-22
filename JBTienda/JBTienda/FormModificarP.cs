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
    public partial class FormModificarP : MaterialSkin.Controls.MaterialForm
    {
        public FormModificarP()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

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
            FormMenuJ p = new FormMenuJ();
            p.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {



            try
            {
                // Objetos de conexión y comando
                SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-4UDBD8N\\SQLEXPRESS;Initial Catalog=Tienda;Integrated Security=True");
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


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
                cmd.Parameters["@cant"].Value = byte.Parse(txtCantidad.Text);
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

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listarProductos()
        {


            
            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("SELECT imagen FROM Producto WHERE idProducto = @idPro", "Data Source=DESKTOP-4UDBD8N\\SQLEXPRESS;Initial Catalog=Tienda;Integrated Security=True");

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

    




        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
            //// Se crea el OpenFileDialog
           OpenFileDialog dialog = new OpenFileDialog();
            //// Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            //// Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            //// la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pic1.Image = Image.FromFile(dialog.FileName);
            }


           

        }

        private void cboDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = cboDesc.SelectedValue.ToString();
        }
    }
}
