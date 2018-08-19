using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBTienda
{
    public partial class da : UserControl
    {
        public da()
        {
            InitializeComponent();
        }

      

        private void da_Load(object sender, EventArgs e)
        {

        }

      
      
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pic1.Image = Image.FromFile(dialog.FileName);
            }
        }


        void agregarProductos()
        {

           
            //int idDepartamento = 1;
            //////System.IO.MemoryStream ms = new System.IO.MemoryStream();
           

            //dcTiendaDataContext dc = new dcTiendaDataContext();
            //dc.agregarProducto(
            //    txtNombre.Text,
            //  txtDescripcion.Text,
            //    txtPrecio.Text,
            //   txtCantidad.Text,
            //   pic1.Image.ToString(),
               
            // byte.Parse(idDepartamento.ToString())

        //);

        //  MessageBox.Show("Capitán Agregado");

        }

        private void txtRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                // Objetos de conexión y comando
                SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=LAPTOP-LN2ROB9J\\SQLEXPRESS01;Initial Catalog=Tienda; Integrated Security=True");
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                int idDepartamento = 1;

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Producto(nombreProducto,descripcion,precio,cantidad,imagen,idDepartamento) VALUES(@nombreProducto, @descripcion, @precio, @cantidad, @imagen, @idDepartamento);";
                conn.Open();
                // Creando los parámetros necesarios
                cmd.Parameters.Add("@nombreProducto", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@descripcion", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@precio", System.Data.SqlDbType.Money);
                cmd.Parameters.Add("@cantidad", System.Data.SqlDbType.TinyInt);
                cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@idDepartamento", System.Data.SqlDbType.TinyInt);

                // Asignando los valores a los atributos
                cmd.Parameters["@nombreProducto"].Value = txtNombre.Text;
                cmd.Parameters["@descripcion"].Value = txtDescripcion.Text;
                cmd.Parameters["@precio"].Value = int.Parse(txtPrecio.Text);
                cmd.Parameters["@cantidad"].Value = int.Parse(txtCantidad.Text);
                cmd.Parameters["@idDepartamento"].Value = byte.Parse(idDepartamento.ToString()); 

                // Asignando el valor de la imagen

                // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                pic1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el 
                // parámetro.
                cmd.Parameters["@imagen"].Value = ms.GetBuffer();

                MessageBox.Show("Producto Agregado");
              
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
