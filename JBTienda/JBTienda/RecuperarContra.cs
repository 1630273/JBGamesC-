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
    public partial class RecuperarContra : MaterialSkin.Controls.MaterialForm
    {
        public RecuperarContra()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);
        }

        UsuarioNeg objNeg = new UsuarioNeg();


        private void txtRecuperar_Click(object sender, EventArgs e)
        {

            txtMensaje.Text = objNeg.recuContra(txtId.Text);


        }
    }
}