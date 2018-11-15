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
    public partial class Cuelectrodomestico : UserControl
    {
        public Cuelectrodomestico()
        {
            InitializeComponent();
        }


        public void listarProductos(DataGridView data)
        {
            try
            {


                SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-8C15TUM;Initial Catalog=Tienda;Integrated Security=True");
                conn.Open();

                SqlCommand comando = new SqlCommand("consultarElectrodomesticos", conn);
                comando.CommandType = CommandType.StoredProcedure;
                //comando.Parameters.Add("@idDepartamento", SqlDbType.Int).Value = Variables.idDep;
                comando.Connection = conn;
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                data.DataSource = dt;
                dtELE.Columns[2].DefaultCellStyle.Format = "$#,##0.00";

                conn.Close();


                Variables.conElec = true;
                MessageBox.Show("Se paso la Var en CuElectrodomesticos");
            }
            catch(System.Exception)
            {

                Variables.conElec = false;
                MessageBox.Show("No se paso la Var en CuElectrodomesticos");
            }
        }
        private void Cuelectrodomestico_Load(object sender, EventArgs e)
        {
            listarProductos(dtELE);
        }

        private void Cuelectrodomestico_DoubleClick(object sender, EventArgs e)
        {

            Variables.idProd = byte.Parse(dtELE.CurrentRow.Cells[3].Value.ToString());

    
            Form A = new FormComprar();
            A.Show();

        }
    }
}
