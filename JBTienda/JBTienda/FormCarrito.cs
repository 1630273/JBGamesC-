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
            ListarCarrito(Variables.usuario);
        }

        void ListarCarrito(string usu)
        {
            dcTiendaDataContext st = new dcTiendaDataContext();

            var r = from con in st.consultarCarrito(usu)
                    select con;

            foreach (var n in r)
            {

                dtcarro.Rows.Add(n.Nombre, n.Descripcion, n.Precio ,n.Cantidad ,n.Total
                    );
                dtcarro.Columns[2].DefaultCellStyle.Format = "$#,##0.00";
                dtcarro.Columns[4].DefaultCellStyle.Format = "$#,##0.00";

            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipalCliente ir = new MenuPrincipalCliente();
            ir.Show();
            this.Hide();

        }

        private void btncomp_Click(object sender, EventArgs e)
        {
            Form ir = new FromTC();
            ir.Show();
            this.Hide();
        }
    }
}
