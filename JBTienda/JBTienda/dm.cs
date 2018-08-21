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
    public partial class dm : UserControl
    {
        public dm()
        {
            InitializeComponent();
        }






        public void listarProductos(DataGridView data)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-4UDBD8N\\SQLEXPRESS;Initial Catalog=Tienda;Integrated Security=True");
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
          

            //data.Columns[7].Width = 125;

            conn.Close();
        }



        private void dm_Load(object sender, EventArgs e)
        {

            listarProductos(dtm);


        }

        private void dtm_DoubleClick(object sender, EventArgs e)
        {


            Variables.idProd = int.Parse(dtm.CurrentRow.Cells[7].Value.ToString());
            MessageBox.Show(Variables.idProd.ToString());
           
            Form p = new FormModificarP();
            p.Show();
            this.Hide();
        }



        //private void btnModificar_Click(object sender, EventArgs e)
        //{

        //    System.IO.MemoryStream ms = new System.IO.MemoryStream();
        //    pic1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

        //    dcTiendaDataContext mod = new dcTiendaDataContext();
        //    mod.modificarProducto(
        //        Byte.Parse(txtId.Text),
        //        txtNombre.Text,
        //        txtDescripcion.Text,
        //        int.Parse(txtPrecio.Text),
        //        byte.Parse(txtCantidad.Text),
        //        ms.GetBuffer(),
        //        byte.Parse(cboDesc.Text)



        // );
        //    MessageBox.Show("Producto Modificado");
        //}

        //private void lstModificar_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cargarProducto(byte.Parse(lstModificar.SelectedValue.ToString()));
        //}

        //private void lstModificar_Click(object sender, EventArgs e)
        //{
        //    txtId.Text = lstModificar.SelectedValue.ToString();
        //    txtNombre.Text = lstModificar.SelectedValue.ToString();
        //    txtDescripcion.Text = lstModificar.SelectedValue.ToString();
        //    txtPrecio.Text = lstModificar.SelectedValue.ToString();
        //    txtCantidad.Text = lstModificar.SelectedValue.ToString();
        //    cboDesc.Text = lstModificar.SelectedValue.ToString();
        //}
    }
}
