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
    public partial class di : UserControl
    {
        public di()
        {
            InitializeComponent();
        }

        public void listarProductos(DataGridView data)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-4UDBD8N\\SQLEXPRESS;Initial Catalog=Tienda;Integrated Security=True");
            conn.Open();
            SqlCommand comando = new SqlCommand("consultarProductos", conn);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@idDepartamento", SqlDbType.Int).Value =  Variables.idDep;
            comando.Connection = conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 60;
            data.Columns[1].Width = 165;
            data.Columns[2].Width = 165;
            data.Columns[3].Width = 90;
            data.Columns[4].Width = 50;
            data.Columns[5].Width = 165;
            data.Columns[6].Width = 100;
            
            //data.Columns[7].Width = 125;

            conn.Close();
        }




        private void di_Load(object sender, EventArgs e)
        {
            //cargarProductos(Variables.idDep);
            listarProductos(dtai);
        }

        private void dtai_DoubleClick(object sender, EventArgs e)
        {
            Form p = new FormModificarP();
            p.Show();
            this.Hide();
        }
    }
}
