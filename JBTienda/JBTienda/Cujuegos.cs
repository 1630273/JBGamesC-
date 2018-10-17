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
    public partial class Cujuegos : UserControl
    {
        public Cujuegos()
        {
            InitializeComponent();
        }

        public void listarProductos(DataGridView data)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-8C15TUM;Initial Catalog=Tienda;Integrated Security=True");
            conn.Open();

            SqlCommand comando = new SqlCommand("consultarVideoJuegos", conn);
            comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.Add("@idDepartamento", SqlDbType.Int).Value = Variables.idDep;
            comando.Connection = conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            dtJu.Columns[2].DefaultCellStyle.Format = "$#,##0.00";


            conn.Close();
        }

        private void Cujuegos_Load(object sender, EventArgs e)
        {
            listarProductos(dtJu);
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void dtJu_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Variables.idProd = byte.Parse(dtJu.CurrentRow.Cells[3].Value.ToString());


            Form A = new FormComprar();
            A.Show();

        }
    }
}
