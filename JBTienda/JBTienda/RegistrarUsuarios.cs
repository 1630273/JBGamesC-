using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBTienda
{
    public partial class RegistrarUsuarios : MaterialSkin.Controls.MaterialForm
    {


        public RegistrarUsuarios()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple600, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple100, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

        }
        

        //Metodo para cargar los estados en el combobox

        void cargarEstados()
        {

           

                cboEstado.SelectedIndexChanged -= new EventHandler(cboEstado_SelectedIndexChanged);


                //OBJETO DEL TIPO DATA CONTEXT
                dcTiendaDataContext dc = new dcTiendaDataContext();

                //VARIABLE DESCRIPTIVA A LO QUE VOY A TREAER
                var Estado = from es in dc.cargarEstados()
                             select new { es.idEstado, es.desEstado };

                cboEstado.DataSource = Estado.ToList();
                cboEstado.ValueMember = "idEstado";
                cboEstado.DisplayMember = "desEstado";

                cboEstado.SelectedIndexChanged += new EventHandler(cboEstado_SelectedIndexChanged);

  
        }

               

        //Metodo para cargar las ciudades en el combobox
        void cargarCiudades(byte idEstado)
        {
            //OBJETO DEL TIPO DATA CONTEXT
            dcTiendaDataContext dc = new dcTiendaDataContext();

            //VARIABLE DESCRIPTIVA A LO QUE VOY A TREAER
            var Ciudad = from ec in dc.cargarCiudades(idEstado)
                         select new { ec.idCiudad, ec.desCiudad };

            cboCiudad.DataSource = Ciudad.ToList();
            cboCiudad.ValueMember = "idCiudad";
            cboCiudad.DisplayMember = "desCiudad";
        }


        private void FormRegistro_Load(object sender, EventArgs e)
        {
            cargarEstados();
            cargarCiudades(byte.Parse(cboEstado.SelectedValue.ToString()));
        }


        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCiudades(byte.Parse(cboEstado.SelectedValue.ToString()));
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
        

            char idSexo = ' ';
            int idTipoUsuario = 2;

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
                dc.agregarUsuarios(
                    txtNombreUsuario.Text,
                    txtContraseña.Text,
                    txtContraseña2.Text,
                    txtNombre.Text,
                    txtApellidoPaterno.Text,
                    txtApellidoMaterno.Text,
                    idSexo,
                    txtTelefono.Text,
                    txtCorreo.Text,
                    txtDireccion.Text,
                    txtcodigop.Text,
                    byte.Parse(cboCiudad.SelectedValue.ToString()),
                    byte.Parse(idTipoUsuario.ToString())

             );


                MessageBox.Show("Usuario Agregado");

                txtNombreUsuario.Text = "";
                txtContraseña.Text = "";
                txtContraseña2.Text = "";
                txtNombre.Text = "";
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                txtCp.Text = "";

            }


        }


        static bool validarEmail(String email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //Metodo para validar que los campos no esten vacios
        private bool ValidarCampos()
        {
            bool ok = true;

            if(txtNombreUsuario.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtNombreUsuario, "Campo Vacio, Ingrese Usuario");
            }

            if(txtContraseña.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtContraseña, "Campo Vacio, Ingrese Contraseña");
            }


            if (txtContraseña2.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtContraseña2, "Campo Vacio, Ingrese Contraseña2");
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


            if (txtCorreo.Text.Trim() == "" || !validarEmail(txtCorreo.Text))
            {
                ok = false;
                ErrorCampos.SetError(txtCorreo, "Formato Incorrecto, Utilize el siguiente formato: Correo@dominio.etc");
            }


            if (txtDireccion.Text.Trim() == "")
            {
                ok = false;
                ErrorCampos.SetError(txtDireccion, "Campo Vacio, Ingrese Direccion");
            }


            if (txtCp.MaskFull == false)
            {
                ok = false;
                ErrorCampos.SetError(txtCp, "Campo Vacio, Ingrese Codigo Postal");
            }


            if (txtTelefono.MaskFull == false)
            {
                ok = false;
                ErrorCampos.SetError(txtTelefono, "Campo Vacio, Ingrese Telefono");
            }

            if (!rdoHombre.Checked && !rdoMujer.Checked)
            {
                ok = false;
                ErrorCampos.SetError(rdoHombre, "Ejija Solo una Opcion.");
                ErrorCampos.SetError(rdoMujer, "Elija sollo una Opcion");

            }

            if (txtContraseña.Text != txtContraseña2.Text)
            {
                ok = false;
                errorContraseña2.SetError(txtContraseña2, "Las contraseñas no son Iguales.");
                
            }

            return ok;

        }

        //Metodo para borrar los mensajes cuando ya esten correctos
        private void BorrarMensajes()
        {
            

            ErrorCampos.SetError(txtNombreUsuario, "");
            ErrorCampos.SetError(txtContraseña, "");
            ErrorCampos.SetError(txtContraseña2, "");
            ErrorCampos.SetError(txtNombre, "");
            ErrorCampos.SetError(txtApellidoPaterno, "");
            ErrorCampos.SetError(txtApellidoMaterno, "");
            ErrorCampos.SetError(txtCorreo, "");
            ErrorCampos.SetError(txtDireccion, "");
            ErrorCampos.SetError(txtCp, "");
            ErrorCampos.SetError(txtTelefono, "");
            ErrorCampos.SetError(rdoHombre, "");
            ErrorCampos.SetError(rdoMujer, "");
        }


        //Metodo para volver al Frame de Login

        private void btnVolver_Click(object sender, EventArgs e)
        {

            string message = "Deseas Salir Sin Guardar?";
            string caption = "Salir";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                MenuIniciarSesion volver = new MenuIniciarSesion();
                volver.Show();
                this.Hide();

            }

        
        }

        private void txtNombreUsuario_Validating(object sender, CancelEventArgs e)
        {
           
            //if (txtNombreUsuario.Text.Trim() == "")
            //{
             
            //    errorUsuario.SetError(txtNombreUsuario, "Campo Vacio, Introdusca Usuario");
            //    e.Cancel = true;
               
            //}
            //else
            //{

            //    errorUsuario.Clear();
            //    e.Cancel = false;
            //    txtContraseña.Focus();
              
            //}
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            //if (txtContraseña.Text.Trim() == "")
            //{
              
            //    errorContraseña.SetError(txtContraseña, "Campo Vacio, Introdusca Contraseña");
            //    e.Cancel = true;
              
            //}
            //else
            //{
             
            //    errorContraseña.Clear();
            //    e.Cancel = false;
            //    txtContraseña2.Focus();
            //}
        }

        private void txtContraseña2_Validating(object sender, CancelEventArgs e)
        {

           //if(txtContraseña.Text != txtContraseña2.Text)
           // {
           //    errorContraseña2.SetError(txtContraseña2, "Las contraseñas no son Iguales.");
           //    e.Cancel = true;
           //}

           // else
           // {
               
           //     errorContraseña2.Clear();
           //     e.Cancel = false;
           //    txtNombre.Focus();
           // }

        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {

            //if (txtNombre.Text.Trim() == "")
            //{
                
            //    errorNombre.SetError(txtNombre, "Campo Vacio, Ingrese Nombre.");
            //    e.Cancel = true;
            //}

            //else
            //{
              
            //    errorNombre.Clear();
            //    e.Cancel = false;
            //    txtApellidoPaterno.Focus();

            //}

        }

      

        private void txtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            //if (txtApellidoPaterno.Text.Trim() == "")
            //{

            //    errorAp.SetError(txtApellidoPaterno, "Campo Vacio, Ingrese Apellido Paterno.");
            //    e.Cancel = true;
            //}

            //else
            //{

            //    errorAp.Clear();
            //    e.Cancel = false;
            //    txtApellidoMaterno.Focus();

            //}

        }


      

        private void txtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            //if (txtApellidoMaterno.Text.Trim() == "")
            //{

            //    errorAm.SetError(txtApellidoMaterno, "Campo Vacio, Ingrese Apellido Materno.");
            //    e.Cancel = true;
            //}

            //else
            //{

            //    errorAm.Clear();
            //    e.Cancel = false;
            //    txtCorreo.Focus();

            //}

        }


     

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            //if (txtCorreo.Text.Trim() == "")
            //{

            //    errorCorreo.SetError(txtCorreo, "Campo Vacio, Ingrese Correo.");
            //    e.Cancel = true;
            //}

            //else
            //{

            //    errorCorreo.Clear();
            //    e.Cancel = false;
            //    txtDireccion.Focus();

            //}

        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            //if (txtDireccion.Text.Trim() == "")
            //{

            //    errorDireccion.SetError(txtDireccion, "Campo Vacio, Ingrese Direccion.");
            //    e.Cancel = true;
            //}

            //else
            //{

            //    errorDireccion.Clear();
            //    e.Cancel = false;
            //    txtCp.Focus();

            //}
        }

        private void txtCp_Validating(object sender, CancelEventArgs e)
        {
            //if (txtCp.Text.Trim() == "")
            //{

            //    errorCp.SetError(txtCp, "Campo Vacio, Ingrese Codigo Postal.");
            //    e.Cancel = true;
            //}

            //else
            //{

            //    errorCp.Clear();
            //    e.Cancel = false;
            //    txtTelefono.Focus();

            //}
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
           //if (txtTelefono.Text.Trim() == "")
           // {

           //    errorTelefono.SetError(txtTelefono, "Campo Vacio, Ingrese Telefono.");
           //     e.Cancel = true;
           //}

           //else
           // {

           //    errorTelefono.Clear();
           //    e.Cancel = false;
               
               

           // }

        }





        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                char idSexo = ' ';
                int idTipoUsuario = 2;

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
                    dc.agregarUsuarios(
                        txtNombreUsuario.Text,
                        txtContraseña.Text,
                        txtContraseña2.Text,
                        txtNombre.Text,
                        txtApellidoPaterno.Text,
                        txtApellidoMaterno.Text,
                        idSexo,
                        txtTelefono.Text,
                        txtCorreo.Text,
                        txtDireccion.Text,
                        txtcodigop.Text,
                        byte.Parse(cboCiudad.SelectedValue.ToString()),
                        byte.Parse(idTipoUsuario.ToString())

                 );


                    MessageBox.Show("Usuario Agregado");

                    txtNombreUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtContraseña2.Text = "";
                    txtNombre.Text = "";
                    txtApellidoPaterno.Text = "";
                    txtApellidoMaterno.Text = "";
                    txtTelefono.Text = "";
                    txtCorreo.Text = "";
                    txtDireccion.Text = "";
                    txtCp.Text = "";

                }

            }


            if (e.KeyCode == Keys.Escape)
            {

                string message = "Deseas Salir Sin Guardar?";
                string caption = "Salir";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    MenuIniciarSesion volver = new MenuIniciarSesion();
                    volver.Show();
                    this.Hide();

                }
            }
        }
    }
}
