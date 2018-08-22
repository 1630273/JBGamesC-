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
using System.IO;

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
            cargarDescuentos();
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



        private void txtRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                // Objetos de conexión y comando
                SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-4UDBD8N\\SQLEXPRESS;Initial Catalog=Tienda;Integrated Security=True");
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Producto(nombreProducto,descripcion,precio,cantidad,imagen,idDepartamento,idDescuento) VALUES(@nombreProducto, @descripcion, @precio, @cantidad, @imagen, @idDepartamento, @idDescuento);";
                conn.Open();
                // Creando los parámetros necesarios
                cmd.Parameters.Add("@nombreProducto", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@descripcion", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@precio", System.Data.SqlDbType.Money);
                cmd.Parameters.Add("@cantidad", System.Data.SqlDbType.TinyInt);
                cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@idDepartamento", System.Data.SqlDbType.TinyInt);
                cmd.Parameters.Add("@idDescuento", System.Data.SqlDbType.TinyInt);

                // Asignando los valores a los atributos
                cmd.Parameters["@nombreProducto"].Value = txtNombre.Text;
                cmd.Parameters["@descripcion"].Value = txtDescripcion.Text;
                cmd.Parameters["@precio"].Value = int.Parse(txtPrecio.Text);
                cmd.Parameters["@cantidad"].Value = int.Parse(txtCantidad.Text);
                cmd.Parameters["@idDepartamento"].Value = Variables.idDep;
                cmd.Parameters["@idDescuento"].Value = lblId.Text;

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

        void cargarDescuentos()
        {
            //cboDesc.SelectedIndexChanged -= new EventHandler(cboDesc_SelectedIndexChanged);


            dcTiendaDataContext dc = new dcTiendaDataContext();
            var carreras = from c in dc.CargarDescuentos()
                           select new { c.idDescuento, c.descuento };

            cboDesc.DataSource = carreras.ToList();
            cboDesc.ValueMember = "idDescuento";
            cboDesc.DisplayMember = "descuento";

            //cboDesc.SelectedIndexChanged += new EventHandler(cboDesc_SelectedIndexChanged);
        }

        private void cboDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblId.Text = cboDesc.SelectedValue.ToString();
        }
    }
}
