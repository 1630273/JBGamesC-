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
                        MessageBox.Show("Bienvenido,Usted es Jefe de Departamento.");


                        ConsultarDep(txtUsuario.Text);
                        Form p = new FormMenuJ();
                        p.Show();
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
    }
}
