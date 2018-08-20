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
            SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=LAPTOP-LN2ROB9J\\SQLEXPRESS01;Initial Catalog=Tienda; Integrated Security=True");
            conn.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM Producto", conn);
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


        void cargarProductos(byte id)
        {
            dcTiendaDataContext st = new dcTiendaDataContext();

            var r = from con in st.consultarProductos(id)
                    select con;

            foreach (var n in r)
            {

             

                dtai.Rows.Add(n.idProducto, n.nombreDepa, n.nombreProducto,n.descripcion,n.precio,n.cantidad               );
              
                
            
            }
        }

        private void dtai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void di_Load(object sender, EventArgs e)
        {
            //cargarProductos(Variables.idDep);
            listarProductos(dtai);
        }
    }
}
