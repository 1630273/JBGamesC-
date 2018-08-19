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
    public partial class FormLoginD : MaterialSkin.Controls.MaterialForm
    {
        public FormLoginD()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);
        }

        private void FormLoginD_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Form Menu = new FormMenuM();
            Menu.Show();
            this.Hide();
        }

        private void btnIncio_Click(object sender, EventArgs e)
        {
            Form p = new FormMenuJ();
            p.Show();
            this.Hide();
        }

        private void Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (Mostrar.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }

        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text.Trim().Length <= 0)
            {
                MessageBox.Show("El Campo nombre es requerido!", "campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (txtContraseña.Text.Trim().Length <= 0)
            {
                MessageBox.Show("El Campo nombre es requerido!", "campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                btnInicio.Focus();
            }
        }
    }
}
