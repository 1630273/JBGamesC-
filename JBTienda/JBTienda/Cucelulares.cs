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
    public partial class Cucelulares: UserControl
    {
        public Cucelulares()
        {
            InitializeComponent();
        }



        public void listarProductos(DataGridView data)
        {
            try
            {


                SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=LAPTOP-LN2ROB9J\\SQLEXPRESS01;Initial Catalog=Tienda;Integrated Security=True");
                conn.Open();

                SqlCommand comando = new SqlCommand("consultarCelulares", conn);
                comando.CommandType = CommandType.StoredProcedure;
                //comando.Parameters.Add("@idDepartamento", SqlDbType.Int).Value = Variables.idDep;
                comando.Connection = conn;
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                data.DataSource = dt;
                dtCel.Columns[2].DefaultCellStyle.Format = "$#,##0.00";
                conn.Close();
            }
            catch
            {
                Variables.con2 = false;
            }
        }

        private void Cucelulares_Load(object sender, EventArgs e)
        {
            listarProductos(dtCel);
        }

        private void dtCel_DoubleClick(object sender, EventArgs e)
        {
            Variables.idProd = byte.Parse(dtCel.CurrentRow.Cells[3].Value.ToString());


            Form A = new FormComprar();
            A.Show();

        }
    }
}
