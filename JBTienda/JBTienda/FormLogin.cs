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
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        public FormLogin()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

        }

        public void login(String v_usuario, String v_contraseña)
        {
            bool bandera = false;
            dcTiendaDataContext dc = new dcTiendaDataContext();

            var log = from l in dc.Logear(v_usuario, v_contraseña)
                      select new { l.nombre, l.idTipoUSuario, l.idUsuario };



            foreach (var u in log)
            {
                bandera = true;

         

                switch (int.Parse(u.idTipoUSuario.ToString()))
                {
                    case 2:
               //         MessageBox.Show("Bienvenido,Usted es Cliente.");

                        Variables.usuario = txtUsuario.Text;

                        FormMCliente ir = new FormMCliente();
                        ir.Show();
                        this.Hide();
                        break;

                  

                }

            }

            if (bandera == false)
            {
                MessageBox.Show("Usuario y contraseña incorrectos");
            }

        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
            

        }

   

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistro Registro = new FormRegistro();
            Registro.Show();
            this.Hide();
        }

        private void btnIncio_Click(object sender, EventArgs e)
        {
            login(txtUsuario.Text,txtContraseña.Text);

            txtUsuario.Text = "";
            txtContraseña.Text = "";
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form p = new FormPortada();
            p.Show();
            this.Hide();
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
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

        private void linkRC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContra ir = new RecuperarContra();
            ir.ShowDialog();
        }
    }
}
