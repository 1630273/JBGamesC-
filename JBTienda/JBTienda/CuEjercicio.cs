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
    public partial class CuEjercicio : UserControl
    {
        public void listarProductos(DataGridView data)
        {
            try
            {


                SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=LAPTOP-LN2ROB9J\\SQLEXPRESS01;Initial Catalog=Tienda;Integrated Security=True");
                conn.Open();

                SqlCommand comando = new SqlCommand("consultarSalud", conn);
                comando.CommandType = CommandType.StoredProcedure;
                //comando.Parameters.Add("@idDepartamento", SqlDbType.Int).Value = Variables.idDep;
                comando.Connection = conn;
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                data.DataSource = dt;
                dtej.Columns[2].DefaultCellStyle.Format = "$#,##0.00";
                conn.Close();
            }

            catch
            {
                Variables.con2 = false;
            }
        }
        public CuEjercicio()
        {
            InitializeComponent();
            listarProductos(dtej);
        }

        private void dtej_DoubleClick(object sender, EventArgs e)
        {
            Variables.idProd = byte.Parse(dtej.CurrentRow.Cells[3].Value.ToString());


            Form A = new FormComprar();
            A.Show();

        }
    }
}
