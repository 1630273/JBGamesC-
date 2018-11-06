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
    public partial class FormCarrito : MaterialSkin.Controls.MaterialForm
    {
        public FormCarrito()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            listarCarito(dtcarro);
        }

        public void listarCarito(DataGridView data)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-8C15TUM;Initial Catalog=Tienda;Integrated Security=True");
            conn.Open();
            SqlCommand comando = new SqlCommand("consultarCarrito", conn);
            comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.Add("@idDepartamento", SqlDbType.Int).Value = Variables.idDep;
            comando.Connection = conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;




            conn.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipalCliente ir = new MenuPrincipalCliente();
            ir.Show();
            this.Hide();

        }
    }
}
