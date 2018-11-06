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
    public partial class RegistrarJefeCom : UserControl
    {
        public RegistrarJefeCom()
        {
            InitializeComponent();
        }

    

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            char idSexo = ' ';
            int idTipoUsuario = 3;
            int idDepartmaneto = 1;

            if (rdoHombre.Checked == true)
            {
                idSexo = 'H';
            }
            else if (rdoMujer.Checked == true)
            {
                idSexo = 'M';
            }

            BorrarMensajes();
            if (ValidarCampos())
            {



                dcTiendaDataContext dc = new dcTiendaDataContext();
                dc.agregarGerente(
                    txtUsuario.Text,
                    txtContraseña.Text,
                    txtContraseña2.Text,
                    txtNombre.Text,
                    txtApellidoPaterno.Text,
                    txtApellidoMaterno.Text,
                    idSexo,
                    byte.Parse(idTipoUsuario.ToString()),
                    byte.Parse(idDepartmaneto.ToString())

             );
                MessageBox.Show("Gerente Agregado");



                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtContraseña2.Text = "";
                txtNombre.Text = "";
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
            }
        }


        //Metodo para validar que los campos no esten vacios
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtUsuario.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtUsuario, "Campo Vacio, Ingrese Usuario");
            }

            if (txtContraseña.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtContraseña, "Campo Vacio, Ingrese Contraseña");
            }


            if (txtContraseña2.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtContraseña2, "Campo Vacio, Confirme Contraseña");
            }


            if (txtNombre.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtNombre, "Campo Vacio, Ingrese Nombre");
            }


            if (txtApellidoPaterno.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtApellidoPaterno, "Campo Vacio, Ingrese Apellido Paterno");
            }


            if (txtApellidoMaterno.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtApellidoMaterno, "Campo Vacio, Ingrese Apellido Materno");
            }



            if (!rdoHombre.Checked && !rdoMujer.Checked)
            {
                ok = false;
                ErrorCampos.SetError(rdoHombre, "Elija un Sexo");
                ErrorCampos.SetError(rdoMujer, "Elija un Sexo");

            }

            if (txtContraseña.Text != txtContraseña2.Text)
            {

                ok = false;
                ErrorCampos.SetError(txtContraseña2, "Las contraseñas no son Iguales.");

            }

            return ok;

        }

        //Metodo para borrar los mensajes cuando ya esten correctos
        private void BorrarMensajes()
        {


            ErrorCampos.SetError(txtUsuario, "");
            ErrorCampos.SetError(txtContraseña, "");
            ErrorCampos.SetError(txtContraseña2, "");
            ErrorCampos.SetError(txtNombre, "");
            ErrorCampos.SetError(txtApellidoPaterno, "");
            ErrorCampos.SetError(txtApellidoMaterno, "");
            ErrorCampos.SetError(rdoHombre, "");
            ErrorCampos.SetError(rdoMujer, "");
        }

        private void RegistrarJefeCom_Load(object sender, EventArgs e)
        {

        }
    }
}
