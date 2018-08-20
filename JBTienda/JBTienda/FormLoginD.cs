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

        public byte idDepa;

        public FormLoginD()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);
        }

        void ConsultarDep(string id)
        {
            dcTiendaDataContext dc = new dcTiendaDataContext();
            var dep = from d in dc.ConsultarDep(id)
                      select d;
            foreach (var n in dep)
            {


                Variables.idDep = byte.Parse(n.idDepartamento.ToString());

                
                    
            }
        }

        public void login(String v_Usuario, String v_Contraseña)
        {

            bool bandera = false;
            dcTiendaDataContext dc = new dcTiendaDataContext();

            var log = from l in dc.LogearGerente(v_Usuario, v_Contraseña)
                      select new { l.idGerente, l.nombre, l.idTipoUsuario };



            foreach (var u in log)
            {
                bandera = true;



                switch (int.Parse(u.idTipoUsuario.ToString()))
                {
                    case 3:
                        MessageBox.Show("Bienvenido,Usted es Jefe de Departamento De Computación.");

                        Variables.idDep = idDepa;
                        ConsultarDep(txtUsuario.Text);
                        Form p = new FormMenuJ();
                        p.Show();
                        this.Hide();

                        break;
                    case 4:
                        MessageBox.Show("Bienvenido,Usted es Jefe de Departamento De VideoJuegos.");

                        Variables.idDep = idDepa;
                        ConsultarDep(txtUsuario.Text);
                        Form p1 = new FormMenuJ();
                        p1.Show();
                        this.Hide();
                        break;
                    case 5:
                        MessageBox.Show("Bienvenido,Usted es Jefe de Departamento De Celulares.");

                        Variables.idDep = idDepa;
                        ConsultarDep(txtUsuario.Text);
                        Form p2 = new FormMenuJ();
                        p2.Show();
                        this.Hide();
                        break;
                    case 6:
                        MessageBox.Show("Bienvenido,Usted es Jefe de Departamento De Electrodomesticos.");

                        Variables.idDep = idDepa;
                        ConsultarDep(txtUsuario.Text);
                        Form p3 = new FormMenuJ();
                        p3.Show();
                        this.Hide();
                        break;
                    case 7:
                        MessageBox.Show("Bienvenido,Usted es Jefe de Departamento De Gimnasio.");

                        Variables.idDep = idDepa;
                        ConsultarDep(txtUsuario.Text);
                        Form p4 = new FormMenuJ();
                        p4.Show();
                        this.Hide();
                        break;


                }

            }

            if (bandera == false)
            {
                MessageBox.Show("Usuario y contraseña incorrectos.");
            }



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
