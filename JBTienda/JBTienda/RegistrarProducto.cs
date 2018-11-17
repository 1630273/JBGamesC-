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
    public partial class RegistrarProducto : UserControl
    {
        public RegistrarProducto()
        {
            InitializeComponent();
        }

      

        public void listarProductos(DataGridView data)
        {


            try
            {
               
                SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=LAPTOP-LN2ROB9J\\SQLEXPRESS01;Initial Catalog=Tienda;Integrated Security=True");
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                conn.Open();

              

                SqlCommand comando = new SqlCommand("consultarProductos", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idDepartamento", SqlDbType.Int).Value = Variables.idDep;
                comando.Connection = conn;
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                data.DataSource = dt;

              
                conn.Close();

                Variables.con1 = true;
               // MessageBox.Show("Se paso La variable de Registrar Producto");


            }

            catch (System.Exception)
            {
               // MessageBox.Show("No se paso la variable de Registrar Producto");
                Variables.con1 = false;


            }



}

        private void di_Load(object sender, EventArgs e)
        {

                listarProductos(dtai);

   }

       
    }
}
