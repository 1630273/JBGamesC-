using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBTienda
{
    public partial class Ael : UserControl
    {
        public Ael()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            char idSexo = ' ';
            int idTipoUsuario = 6;
            int idDepartmaneto = 4;

            if (rdoHombre.Checked == true)
            {
                idSexo = 'H';
            }
            else if (rdoMujer.Checked == true)
            {
                idSexo = 'M';
            }

            dcTiendaDataContext dc = new dcTiendaDataContext();
            dc.agregarGerente(
                txtUsuario.Text,
                txtContraseña.Text,
                txtNombre.Text,
                txtApellidoPaterno.Text,
                txtApellidoMaterno.Text,
                idSexo,
                byte.Parse(idTipoUsuario.ToString()),
                byte.Parse(idDepartmaneto.ToString())

         );
            MessageBox.Show("Gerente Agregado");

        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (txtContraseña.Text.Trim() == "")
            {

                error.SetError(txtContraseña, "Campo Vacio, Introdusca Contraseña");
                e.Cancel = true;

            }
            else
            {

                error.Clear();
                e.Cancel = false;
                txtNombre.Focus();

            }
        }

        

        private void Ael_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {

                error.SetError(txtNombre, "Campo Vacio, Introdusca Nombre");
                e.Cancel = true;

            }
            else
            {

                error.Clear();
                e.Cancel = false;
                txtApellidoPaterno.Focus();

            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtApellidoMaterno_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {

                error.SetError(txtNombre, "Campo Vacio, Introdusca Nombre");
                e.Cancel = true;

            }
            else
            {

                error.Clear();
                e.Cancel = false;
                txtApellidoPaterno.Focus();

            }
        }

        private void txtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoPaterno.Text.Trim() == "")
            {

                error.SetError(txtApellidoPaterno, "Campo Vacio, Introdusca Apellido Paterno");
                e.Cancel = true;

            }
            else
            {

                error.Clear();
                e.Cancel = false;
                txtApellidoMaterno.Focus();

            }

        }

        private void txtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoMaterno.Text.Trim() == "")
            {

                error.SetError(txtApellidoMaterno, "Campo Vacio, Introdusca Apellido Materno");
                e.Cancel = true;

            }
            else
            {

                error.Clear();
                e.Cancel = false;
                btnRegistrar.Focus();


            }
        }
    }
}
