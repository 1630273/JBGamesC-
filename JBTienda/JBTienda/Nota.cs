using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBTienda
{
    public partial class Nota : MaterialSkin.Controls.MaterialForm
    {
        public Nota()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);
        }

        void ListarCarrito(string usu)
        {
            dcTiendaDataContext st = new dcTiendaDataContext();

            var r = from con in st.consultarCarrito(usu)
                    select con;

            foreach (var n in r)
            {

                dtcarro.Rows.Add(n.Nombre, n.Descripcion, n.Precio, n.Cantidad, n.Total
                    );
                dtcarro.Columns[2].DefaultCellStyle.Format = "$#,##0.00";
                dtcarro.Columns[4].DefaultCellStyle.Format = "$#,##0.00";

            }

        }


        void CargarTotal(string usuario)
        {
            dcTiendaDataContext d = new dcTiendaDataContext();

            var total = from con in d.sumarPrecios(usuario)
                        select con;



            foreach (var n in total)
            {
                lblTotal.Text = n.TOTAL_PAGAR.ToString();

            }


        }

        private void Nota_Load(object sender, EventArgs e)
        {
            ListarCarrito(Variables.usuario);
            CargarTotal(Variables.usuario);
          
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            dcTiendaDataContext dc = new dcTiendaDataContext();
            dc.Limpiarcarrito();

            MenuPrincipalCliente ir = new MenuPrincipalCliente();
            ir.Show();
            this.Hide();
        }
    }
}
