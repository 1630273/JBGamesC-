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
    public partial class FormLoginA : MaterialSkin.Controls.MaterialForm
    {
        public FormLoginA()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);
        }

        public void login(String v_Usuario, String v_Contraseña)
        {

            bool bandera = false;
            dcTiendaDataContext dc = new dcTiendaDataContext();

            var log = from l in dc.Logear(v_Usuario, v_Contraseña)
                      select new { l.nombre, l.idTipoUSuario, l.idUsuario };



            foreach (var u in log)
            {
                bandera = true;



                switch (int.Parse(u.idTipoUSuario.ToString()))
                {
                    case 1:
                        MessageBox.Show("Bienvenido,Usted es Administrador.");

                        // Variables.usuario = txtUsuario.Text; 

                        Form Menu = new FormMenuAdmin();
                        Menu.Show();
                        this.Hide();

                        break;



                }

            }

            if (bandera == false)
            {
                MessageBox.Show("Usuario y contraseña incorrectos.");
            }



        }

        private void FormLoginA_Load(object sender, EventArgs e)
        {
           
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form p = new FormMenuM();
            p.Show();
            this.Hide();
        }

        private void btnIncio_Click_1(object sender, EventArgs e)
        {
            login(txtUsuario.Text,txtContraseña.Text);
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
