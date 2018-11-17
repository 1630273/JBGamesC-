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
    public partial class FromTC : MaterialSkin.Controls.MaterialForm
    {
        public FromTC()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple600, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple100, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form ir = new FormCarrito();
            ir.Show();
            this.Hide();
        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtNP.Text.Trim() == "")
            {


                ok = false;
                ErrorCampos.SetError(txtNP, "Campo Vacio, Ingrese Usuario");
            }

            if (txtFe.Text.Trim() == "")
            {

                ok = false;
                ErrorCampos.SetError(txtFe, "Campo Vacio, Ingrese Contraseña");
            }
            if (txtCod.Text.Trim() == "")
            {

                ok = false;
                ErrorCampos.SetError(txtCod, "Campo Vacio, Ingrese Contraseña");
            }






            return ok;

        }


        private void BorrarMensajes()
        {


            ErrorCampos.SetError(txtNP, "");
            ErrorCampos.SetError(txtCod, "");
            ErrorCampos.SetError(txtFe, "");
          
        }

        private void FromTC_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            BorrarMensajes();
            if(ValidarCampos())
            {

            }
          
        }
    }
}
